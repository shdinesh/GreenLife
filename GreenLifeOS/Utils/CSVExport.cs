using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace GreenLifeOS.Utils
{
    internal class CSVExport
    {
        public static void ExportGridToCsv(DataGridView grid, string filePath)
        {
            if (grid == null) throw new ArgumentNullException(nameof(grid));
            if (string.IsNullOrWhiteSpace(filePath)) throw new ArgumentNullException(nameof(filePath));

            var visibleColumns = grid.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible)
                .OrderBy(c => c.DisplayIndex)
                .ToList();

            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // 1) Write headers
                string headerLine = string.Join(",", visibleColumns.Select(c => CsvEscape(c.HeaderText)));
                writer.WriteLine(headerLine);

                // 2) Write rows
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.IsNewRow) continue;

                    string line = string.Join(",",
                        visibleColumns.Select(col => CsvEscape(row.Cells[col.Index].Value?.ToString() ?? string.Empty)));

                    writer.WriteLine(line);
                }
            }
        }

        private static string CsvEscape(string value)
        {
            if (value == null) return "";

            bool mustQuote = value.Contains(",") || value.Contains("\"") || value.Contains("\n") || value.Contains("\r");
            value = value.Replace("\"", "\"\""); // escape quotes

            return mustQuote ? $"\"{value}\"" : value;
        }
    }
}
