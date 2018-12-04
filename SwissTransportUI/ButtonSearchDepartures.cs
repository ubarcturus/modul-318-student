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
        Transport _transport = new Transport();
        ButtonSearchConnections _buttonSearch = new ButtonSearchConnections();

        public List<string> SearchDepartures(string destination, string id )
        {
            List<string> departuresList = new List<string>();
            StationBoardRoot departures = _transport.GetStationBoard(destination, id);
            foreach (var item in departures.Entries)
            {
                departuresList.Add("Verbindung nach:\t" + item.To + " um " + _buttonSearch.FormatTime(item.Stop.Departure.ToString()));
            }

            return departuresList;
        }
    }
}
