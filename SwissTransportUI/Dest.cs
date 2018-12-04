using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;

namespace SwissTransportUI
{
    class Dest
    {
        Transport _transport = new Transport();

        public List<string> SearchDest(string textDest)
        {
            List<string> stationsList = new List<string>();
            Stations stations = _transport.GetStations(textDest);
            foreach (var item in stations.StationList)
            {
                if (item.Name != null)
                {
                    stationsList.Add(item.Name);
                }
            }

            return stationsList;
        }
    }
}
