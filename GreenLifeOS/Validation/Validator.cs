using System.Text.RegularExpressions;

namespace GreenLifeOS.Validation
{
    internal class Validator
    {

        private static readonly Regex EmailRegex =
            new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$", RegexOptions.Compiled);

        public static bool IsRequired(string v) => !string.IsNullOrWhiteSpace(v);

        public static bool MaxLen(string v, int max) => (v ?? "").Length <= max;

        public static bool MinLen(string v, int min) => (v ?? "").Trim().Length >= min;

        public static bool DigitsOnly(string v)
        {
            if (string.IsNullOrWhiteSpace(v)) return false;
            v = v.Trim();
            foreach (char c in v) if (!char.IsDigit(c)) return false;
            return true;
        }

        public static bool Email(string v) =>
            !string.IsNullOrWhiteSpace(v) && EmailRegex.IsMatch(v.Trim());

        public static bool Phone(string v, int min = 10, int max = 16)
        {
            if (string.IsNullOrWhiteSpace(v)) return false;
            v = v.Trim();
            return v.Length >= min && v.Length <= max && DigitsOnly(v);
        }
    }
}
