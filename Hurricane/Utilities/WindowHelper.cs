﻿using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Interop;
using Hurricane.Utilities.Native;

namespace Hurricane.Utilities
{
    static class WindowHelper
    {
        private const int GWL_STYLE = -16,
                  WS_MAXIMIZEBOX = 0x10000,
                  WS_MINIMIZEBOX = 0x20000;

        private const int WS_EX_TOOLWINDOW = 0x00000080;
        private const int GWL_EXSTYLE = (-20);

        public static string GetActiveWindowTitle(IntPtr handle)
        {
            const int nChars = 256;
            StringBuilder buffer = new StringBuilder(nChars);

            if (UnsafeNativeMethods.GetWindowText(handle, buffer, nChars) > 0)
            {
                return buffer.ToString();
            }
            return null;
        }

        public static bool WindowIsFullscreen(IntPtr window)
        {
            var placement = new WINDOWPLACEMENT();
            placement.length = Marshal.SizeOf(placement);
            UnsafeNativeMethods.GetWindowPlacement(window, ref placement);
            var workarea = SystemParameters.WorkArea;
            string cname = GetClassName(window);
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return ((placement.showCmd == 1 && placement.minPosition.X == -1 && placement.minPosition.Y == -1 && placement.normalPosition.left == 0 && placement.normalPosition.top == 0 && placement.normalPosition.Width == workarea.Width && !(cname == "Progman" || cname == "WorkerW")));
        }

        public static RECT GetWindowRectangle(Window window)
        {
            RECT rect;
            UnsafeNativeMethods.GetWindowRect((new WindowInteropHelper(window)).Handle, out rect);
            return rect;
        }

        public static string GetClassName(IntPtr handle)
        {
            const int maxChars = 256;
            StringBuilder className = new StringBuilder(maxChars);
            if (UnsafeNativeMethods.GetClassName(handle, className, maxChars) > 0)
            {
                return className.ToString();
            }
            return string.Empty;
        }

        public static void HideFromAltTab(Window window)
        {
            var wndHelper = new WindowInteropHelper(window);
            int exStyle =
                UnsafeNativeMethods.GetWindowLong(wndHelper.Handle,
                    GWL_EXSTYLE);
            exStyle |= WS_EX_TOOLWINDOW;
            UnsafeNativeMethods.SetWindowLong(wndHelper.Handle, GWL_EXSTYLE, exStyle);
        }


        internal static void HideMinimizeAndMaximizeButtons(Window window)
        {
            var hwnd = new WindowInteropHelper(window).Handle;
            var currentStyle = UnsafeNativeMethods.GetWindowLong(hwnd, GWL_STYLE);

            UnsafeNativeMethods.SetWindowLong(hwnd, GWL_STYLE, (currentStyle & ~WS_MAXIMIZEBOX & ~WS_MINIMIZEBOX));

        }

        internal static void ShowMinimizeAndMaximizeButtons(Window window)
        {
            var hwnd = new WindowInteropHelper(window).Handle;
            var currentStyle = UnsafeNativeMethods.GetWindowLong(hwnd, GWL_STYLE);

            UnsafeNativeMethods.SetWindowLong(hwnd, GWL_STYLE, (currentStyle | WS_MAXIMIZEBOX | WS_MINIMIZEBOX));
        }
    }
}