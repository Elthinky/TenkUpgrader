using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace TenkUpgraderv2
{
    public static class WinAPI
    {
        #region Virtuals Keys Codes
        public static int VK_TAB = 0x0009;
        public static int VK_RETURN = 0x000D;
        public static int VK_SPACE = 0x0020;
        public static int VK_ESCAPE = 0x001B;
        public static int VK_SHIFT = 0x0010;
        public static int VK_CAPITAL = 0x0014;
        #endregion
        #region Windows Messages
        public static int WM_NULL = 0x0000;
        public static int WM_CREATE = 0x0001;
        public static int KEYEVENTF_EXTENDEDKEY = 0x0001;
        public static int KEYEVENTF_KEYUP = 0x0002;
        public static int WM_DESTROY = 0x0002;
        public static int WM_MOVE = 0x0003;
        public static int WM_SIZE = 0x0005;
        public static int WM_ACTIVATE = 0x0006;
        public static int WM_SETFOCUS = 0x0007;
        public static int WM_KILLFOCUS = 0x0008;
        public static int WM_ENABLE = 0x000a;
        public static int WM_SETREDRAW = 0x000b;
        public static int WM_SETTEXT = 0x000c;
        public static int WM_GETTEXT = 0x000d;
        public static int WM_GETTEXTLENGTH = 0x000e;
        public static int WM_PAINT = 0x000f;
        public static int WM_CLOSE = 0x0010;
        public static int WM_QUERYENDSESSION = 0x0011;
        public static int WM_QUIT = 0x0012;
        public static int WM_QUERYOPEN = 0x0013;
        public static int WM_ERASEBKGN = 0x0014;
        public static int WM_SYSCOLORCHANGE = 0x0015;
        public static int WM_ENDSESSION = 0x0016;
        public static int WM_SHOWWINDOW = 0x0018;
        public static int WM_CTLCOLOR = 0x0019;
        public static int WM_WININICHANGE = 0x001a;
        public static int WM_DEVMODECHANGE = 0x001b;
        public static int WM_ACTIVATEAPP = 0x001c;
        public static int WM_FONTCHANGE = 0x001d;
        public static int WM_TIMECHANGE = 0x001e;
        public static int WM_CANCELMODE = 0x001f;
        public static int WM_SETCURSOR = 0x0020;
        public static int WM_MOUSEACTIVATE = 0x0021;
        public static int WM_CHILDACTIVATE = 0x0022;
        public static int WM_QUEUESYNC = 0x0023;
        public static int WM_GETMINMAXINFO = 0x0024;
        public static int WM_PAINTICON = 0x0026;
        public static int WM_ICONERASEBKGND = 0x0027;
        public static int WM_NEXTDLGCTL = 0x0028;
        public static int WM_SPOOLERSTATUS = 0x002a;
        public static int WM_DRAWITEM = 0x002b;
        public static int WM_MEASUREITEM = 0x002c;
        public static int WM_DELETEITEM = 0x002d;
        public static int WM_VKEYTOITEM = 0x002e;
        public static int WM_CHARTOITEM = 0x002f;
        public static int WM_SETFONT = 0x0030;
        public static int WM_GETFONT = 0x0031;
        public static int WM_SETHOTKEY = 0x0032;
        public static int WM_GETHOTKEY = 0x0033;
        public static int WM_QUERYDRAGICON = 0x0037;
        public static int WM_COMPAREITEM = 0x0039;
        public static int WM_GETOBJECT = 0x003d;
        public static int WM_COMPACTING = 0x0041;
        public static int WM_COMMNOTIFY = 0x0044;
        public static int WM_WINDOWPOSCHANGING = 0x0046;
        public static int WM_WINDOWPOSCHANGED = 0x0047;
        public static int WM_POWER = 0x0048;
        public static int WM_COPYGLOBALDATA = 0x0049;
        public static int WM_COPYDATA = 0x004a;
        public static int WM_CANCELJOURNAL = 0x004b;
        public static int WM_NOTIFY = 0x004e;
        public static int WM_INPUTLANGCHANGEREQUEST = 0x0050;
        public static int WM_INPUTLANGCHANGE = 0x0051;
        public static int WM_TCARD = 0x0052;
        public static int WM_HELP = 0x0053;
        public static int WM_USERCHANGED = 0x0054;
        public static int WM_NOTIFYFORMAT = 0x0055;
        public static int WM_CONTEXTMENU = 0x007b;
        public static int WM_STYLECHANGING = 0x007c;
        public static int WM_STYLECHANGED = 0x007d;
        public static int WM_DISPLAYCHANGE = 0x007e;
        public static int WM_GETICON = 0x007f;
        public static int WM_SETICON = 0x0080;
        public static int WM_NCCREATE = 0x0081;
        public static int WM_NCDESTROY = 0x0082;
        public static int WM_NCCALCSIZE = 0x0083;
        public static int WM_NCHITTEST = 0x0084;
        public static int WM_NCPAINT = 0x0085;
        public static int WM_NCACTIVATE = 0x0086;
        public static int WM_GETDLGCODE = 0x0087;
        public static int WM_SYNCPAINT = 0x0088;
        public static int WM_NCMOUSEMOVE = 0x00a0;
        public static int WM_LBUTTONDOWN = 0x0201;
        public static int WM_LBUTTONUP = 0x0202;
        public static int WM_LBUTTONDBLCLK = 0x0203;
        public static int WM_KEYDOWN = 0x0100;
        public static int WM_KEYUP = 0x0101;
        public static int WM_CHAR = 0x0102;
        public static int PBM_STEPPIT = 0x0404;
        public static int PBM_GETRANGE = 0x407;
        public static int PBM_GETPOS = 0x0408;
        #endregion
        #region External Input
        [DllImport("USER32.dll")] public static extern short GetKeyState(int nVirtKey);
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")][return: MarshalAs(UnmanagedType.Bool)] public static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll", SetLastError = true)] public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] public static extern IntPtr CreateRoundRectRgn(uint nLeftRect, uint nTopRect, int nRightRect, int nBottomRect, uint nWidthEllipse, uint nHeightEllipse);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] public static extern RectangleF CreateRoundRect(uint nLeftRect, uint nTopRect, int nRightRect, int nBottomRect, uint nWidthEllipse, uint nHeightEllipse);
        [DllImport("user32.dll")] public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")] public static extern bool ShowWindow(IntPtr hWnd, ShowWindowMode nCmdShow);
        [DllImport("user32.dll")] public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int nW, int nH, bool repaint);
        [DllImport("user32.dll")] public static extern IntPtr GetWindow(IntPtr hWnd, GetWindowType uCmd);
        [DllImport("user32.dll")] public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")] public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, string lParam);
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)] public static extern bool PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)] public static extern int PostMessage(IntPtr hWnd, int Msg, uint wParam, uint lParam);
        [DllImport("user32.dll")] public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("user32.dll")] public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")] public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")] public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")] public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")] public static extern bool EnableWindow(IntPtr hWnd, bool bEnable);
        [DllImport("user32.dll")] public static extern IntPtr GetActiveWindow();
        [DllImport("User32.dll")] public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")] public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);
        [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = System.Runtime.InteropServices.CharSet.Auto)] public static extern bool SendMessage(IntPtr hWnd, int Msg, int wParam, StringBuilder lParam);
        #endregion
        #region Enum
        public enum GetWindowType : uint
        {
            GW_HWNDFIRST = 0,
            GW_HWNDLAST = 1,
            GW_HWNDNEXT = 2,
            GW_HWNDPREV = 3,
            GW_OWNER = 4,
            GW_CHILD = 5,
            GW_ENABLEDPOPUP = 6
        }
        public enum ShowWindowMode : uint
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWWINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_FORCEMINIMIZE = 11
        }

        #endregion
        #region Struct
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
        #endregion
        #region Customs Functions
        public static void ClickByHandle(IntPtr Handle, int x, int y)
        {
            SendMessage(Handle, WinAPI.WM_LBUTTONDOWN, 0, MAKEPARAM(x, y));
            SendMessage(Handle, WinAPI.WM_LBUTTONUP, 0, MAKEPARAM(x, y));
        }
        private static int MAKEPARAM(int l, int h) { return ((l & 0xffff) | (h << 0x10)); }

        public static void SendKey(IntPtr Handle, Keys Key)
        {
            WinAPI.PostMessage(Handle, WinAPI.WM_KEYDOWN, (int)Key, 0);
            WinAPI.PostMessage(Handle, WinAPI.WM_KEYUP, (int)Key, 0);
        }
        public static List<IntPtr> GetAllComponnents(IntPtr GlobalHandle)
        {
            List<IntPtr> componnents = new List<IntPtr>();
            componnents.Add((WinAPI.GetWindow(GlobalHandle, WinAPI.GetWindowType.GW_HWNDFIRST)));
            for (int i = 0; i < 250000; i++)
            {
                if (hasNextHandle(componnents[i]))
                    componnents.Add(WinAPI.GetWindow(componnents[i], WinAPI.GetWindowType.GW_HWNDNEXT));
                else
                    break;
            }
            return componnents;
        }
        public static bool hasNextHandle(IntPtr Handle)
        {
            return WinAPI.GetWindow(Handle, WinAPI.GetWindowType.GW_HWNDNEXT) != IntPtr.Zero;
        }
        #endregion
    }
}
