using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace VTS_Kinect
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Process.GetProcessesByName("VTube Studio").Any())
            {
                MessageBox.Show("VTube Studio is not running.", "Plugin not started.");
                Application.Exit();
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
