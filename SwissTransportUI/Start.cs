using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;

namespace SwissTransportUI
{
    class Start
    {
        Transport Transport = new Transport();

        public List<string> SearchStart(string TextStart)
        {
            List<string> StationsList = new List<string>();
            Stations stations = Transport.GetStations(TextStart);
            foreach (var item in stations.StationList)
            {
                if (item.Name != null)
                {
                    StationsList.Add(item.Name);
                }
            }

            return StationsList;
        }
    }
}