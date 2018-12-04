using System.Collections.Generic;
using SwissTransport;

namespace SwissTransportUI
{
    class Dest
    {
        Transport _transport = new Transport();

        public List<string> SearchDest(string textDest)
        {
            var stationsList = new List<string>();
            var stations = _transport.GetStations(textDest);
            foreach (var item in stations.StationList)
                if (item.Name != null)
                    stationsList.Add(item.Name);

            return stationsList;
        }
    }
}