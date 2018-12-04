using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;

namespace SwissTransportUI
{
    class ButtonSearchConnections
    {
        Transport Transport = new Transport();

        public List<string> SearchConnections(string TextStart, string TextDest)
        {
            List<string> ConnectionsList = new List<string>();
            Connections connections = Transport.GetConnections(TextStart, TextDest);
            foreach (var item in connections.ConnectionList)
            {
                ConnectionsList.Add("Abfahrt:\t" + FormatTime(item.From.Departure) + "\t" + item.From.Station.Name + "\t\t" + 
                                    "Ankunft:\t" + FormatTime(item.To.Arrival) + "\t" + item.To.Station.Name);
            }

            return ConnectionsList;
        }


        public string FormatTime(string timeToFormat)
        {
            string iso8601String = timeToFormat;

            DateTime tempdate = DateTime.Parse(iso8601String);
            timeToFormat = tempdate.ToString("t", System.Globalization.CultureInfo.InvariantCulture);

            return timeToFormat;
        }
    }
}
