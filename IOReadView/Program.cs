using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using IORead;

namespace IOReadView
{
    class Program
    {

        private static void OutputDataToConsole(object o)
        {
            var IOData = IORead.Entry.IOReadPlc.MAIN.MainReadIO;

            Console.WriteLine("Time: " + DateTime.Now.ToString() + " | " +
                IOData.st_ReadIO.AttributeName + ": " + IOData.st_ReadIO.Cyclic.ToString() );
        }
        static void Main(string[] args)
        {
            Entry.IOReadPlc.Connector.ReadWriteCycleDelay = 100;
            Entry.IOReadPlc.Connector.BuildAndStart();
            Timer t = new Timer(OutputDataToConsole, null, 0, 1000);

            Console.ReadLine();
        }
    }
}
