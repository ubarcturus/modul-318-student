using System.Collections.Generic;
using SwissTransport;

namespace SwissTransportUI
{
    class Start
    {
        Transport _transport = new Transport();

        public List<string> SearchStart(string textStart)
        {
            var stationsList = new List<string>();
            var stations = _transport.GetStations(textStart);
            foreach (var item in stations.StationList)
            {
                if (item.Name != null) stationsList.Add(item.Name);

                if (item.Id != string.Empty) Form1.IdList.Add(item.Id);
            }

            return stationsList;
        }
    }
}