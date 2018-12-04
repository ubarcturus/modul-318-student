using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using SwissTransportUI;

namespace SwissTransportUI
{
    class Start
    {
        Transport _transport = new Transport();

        public List<string> SearchStart(string textStart)
        {
            List<string> stationsList = new List<string>();
            Stations stations = _transport.GetStations(textStart);
            foreach (var item in stations.StationList)
            {
                if (item.Name != null)
                {
                    stationsList.Add(item.Name);
                }

                if (item.Id != string.Empty)
                {
                    Form1.IdList.Add(item.Id);
                }
            }

            return stationsList;
        }
    }
}