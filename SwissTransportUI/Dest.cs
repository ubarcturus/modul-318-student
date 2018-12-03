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
        Transport Transport = new Transport();

        public List<string> SearchDest(string TextDest)
        {
            List<string> StationsList = new List<string>();
            Stations stations = Transport.GetStations(TextDest);
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
