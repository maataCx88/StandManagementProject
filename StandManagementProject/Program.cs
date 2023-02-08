using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandManagementProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Dzoftware");

            if (key != null)
            {
                Application.Run(new LOGIN_());
            }
            else
            {
                Application.Run(new Start(true));
            }
        }
    }
}
