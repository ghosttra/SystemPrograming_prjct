using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SystemPrograming_prjct {
    public static class Functions {
        public const long MB_OKCANCEL = 0x00000001L;

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);


        public const int WM_CLOSE = 16;
        public const int WM_SETTEXT = 12;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, UIntPtr wParam, StringBuilder lParam);

        public const int SW_SHOWMAXIMIZED = 3;

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public static long MB_ICONASTERISK = 0x00000040L;
        public static long MB_ICONEXCLAMATION = 0x00000030L;
        public static long MB_OK = 0x00000000L;
        public static long MB_ICONQUESTION = 0x00000020L;

        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern bool MessageBeep(uint type);

    }
}
