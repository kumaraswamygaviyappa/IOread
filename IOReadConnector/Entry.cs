using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace IORead
{
    public static class Entry
    {
        const string AmsId = null; // your ams id or set to 'null' if local
        const int Port = 851;
        public static IOReadTwinController IOReadPlc { get; } = new IOReadTwinController(Tc3ConnectorAdapter.Create(AmsId, Port));


    }
}
