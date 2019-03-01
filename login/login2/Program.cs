using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login2
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p = Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe");
            p.WaitForInputIdle();
            IntPtr h = p.MainWindowHandle;
            SetForegroundWindow(h);
            SendKeys.SendWait("k");
        }
    }
}
