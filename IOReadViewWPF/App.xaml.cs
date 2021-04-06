using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using IORead;

namespace IOReadViewWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IORead.IOReadTwinController Connector;

        public App()
        {
            Connector = Entry.IOReadPlc;
            Connector.Connector.BuildAndStart();
            Connector.Connector.ReadWriteCycleDelay = 100;
        }
    }
}
