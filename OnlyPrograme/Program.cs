//#define _MUTEX 
#define _PROCESS 

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OnlyPrograme
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 主要说明如何使程序只运行一次，主流有两种方法：
        /// 1.互斥量方法
        /// 2.遍历进程方法
        /// 第一种方法简单效率高，但扩展性不强；
        /// 第二种方法扩展性好，但效率有点低。
        /// 两种方法的取舍，就看需求了，如果需要扩展的，如若程序已经运行则弹出到前面来，就需要
        /// 使用第二种方法；如果仅仅是为了程序只运行一次，可以简单地使用第一种方法。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if  _MUTEX
            bool bCreateNew = OnlyPrograme1();
            if (bCreateNew)
                Application.Run(new Form1());
#elif _PROCESS
            if (OnlyPrograme2() == null)
                Application.Run(new FormMain());
#else
            Application.Run(new Form1());
#endif
        }

        #region Mutex Method
        private static bool OnlyPrograme1()
        {
            bool bCreateNew = false;
            Mutex m = new Mutex(false, "OnlyPrograme_LSP", out bCreateNew);
            return bCreateNew;
        }
        #endregion

        #region Process Method
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);
        private const int SW_RESTORE = 9;

        private static Process OnlyPrograme2()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);

            foreach (Process process in processes)
            {
                if (process.Id != current.Id)
                {
                    if (Assembly.GetExecutingAssembly().Location.Replace("/","//")
                        == current.MainModule.FileName)
                    {
                        IntPtr hWnd = process.MainWindowHandle;
                        if (IsIconic(hWnd))
                            ShowWindowAsync(hWnd, SW_RESTORE);
                        SetForegroundWindow(hWnd);
                        return process;
                    }
                }
            }
            return null;
        }
        #endregion
    }
}
