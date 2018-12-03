using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;

namespace SwissTransportUI
{
    class Button
    {
        Transport Transport = new Transport();

        public List<string> SearchConnections(string TextStart, string TextDest)
        {
            List<string> ConnectionsList = new List<string>();
            Connections connections = Transport.GetConnections(TextStart, TextDest);
            foreach (var item in connections.ConnectionList)
            {
                ConnectionsList.Add(item.From.Departure + item.From.Station.Name + "\t" + item.To.Arrival + item.To.Station.Name);
            }

            return ConnectionsList;
        }
    }
}
