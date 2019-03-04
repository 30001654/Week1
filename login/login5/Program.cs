using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace login
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {

            Process.Start("https://moodle.toiohomai.ac.nz:");


            System.Threading.Thread.Sleep(1000);

            int hWnd = FindWindow(null, "Google - Mozilla Firefox");
            if (hWnd > 0) //If found
            {
                SetForegroundWindow(hWnd); //Activate it
            }
            else
            {
                Console.WriteLine("Window not found yet.");
            }


            Clipboard.SetText("30001654@student.toiohomai.ac.nz");

            SendKeys.SendWait("^{v}");
            SendKeys.SendWait("{TAB}");

            System.Threading.Thread.Sleep(10);

            Clipboard.SetText("prebuiltssuck");

            SendKeys.SendWait("^{v}");
            SendKeys.SendWait("{ENTER}");
        }

        //Import the FindWindow API to find our window
        [DllImportAttribute("User32.dll")]
        private static extern int FindWindow(String ClassName, String WindowName);

        //Import the SetForeground API to activate it
        [DllImportAttribute("User32.dll")]
        private static extern IntPtr SetForegroundWindow(int hWnd);

    }
}
