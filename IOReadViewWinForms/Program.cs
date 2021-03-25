using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IORead;

namespace IOReadViewWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Entry.IOReadPlc.Connector.BuildAndStart();
            Entry.IOReadPlc.Connector.ReadWriteCycleDelay = 100;            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IOSatus());
        }
    }
}
