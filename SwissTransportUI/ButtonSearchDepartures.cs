using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;

namespace SwissTransportUI
{
    class ButtonSearchDepartures
    {
        Transport Transport = new Transport();
        ButtonSearchConnections ButtonSearch = new ButtonSearchConnections();

        public List<string> SearchDepartures(string Destination, string ID )
        {
            List<string> DeparturesList = new List<string>();
            StationBoardRoot departures = Transport.GetStationBoard(Destination, ID);
            foreach (var item in departures.Entries)
            {
                DeparturesList.Add("Verbindung nach:\t" + item.To + " um " + ButtonSearch.FormatTime(item.Stop.Departure.ToString()));
            }

            return DeparturesList;
        }
    }
}
