using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GreenLifeOS.Utils
{

    public static class TextBoxPlaceholder
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(
            IntPtr hWnd, int msg, int wParam, string lParam);

        public static void SetPlaceholder(TextBox textBox, string placeholder)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, placeholder);
        }
    }
}
