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

//fuck off

namespace login
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;
                    // You can start any process, HelloWorld is a do-nothing example.
                    myProcess.StartInfo.FileName = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
                    myProcess.StartInfo.Arguments = "https://moodle.toiohomai.ac.nz";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                    // This code assumes the process you are starting will terminate itself. 
                    // Given that is is started without a window so you cannot terminate it 
                    // on the desktop, it must terminate itself or you can do it programmatically
                    // from this application using the Kill method.
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            System.Threading.Thread.Sleep(2500);

            int hWnd = FindWindow(null, "Sign In - Google Chrome");
            if (hWnd > 0) //If found
            {
                SetForegroundWindow(hWnd); //Activate it
            }
            else
            {
                MessageBox.Show("Window Not Found!");
            }

            

            Clipboard.SetText("30001654@student.toiohomai.ac.nz");

            SendKeys.SendWait("^{v}");
            SendKeys.SendWait("{TAB}");

            System.Threading.Thread.Sleep(10);

            Clipboard.SetText("");

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
