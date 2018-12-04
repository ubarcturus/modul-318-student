using System.Collections.Generic;
using SwissTransport;

namespace SwissTransportUI
{
    class ButtonSearchDepartures
    {
        ButtonSearchConnections _buttonSearch = new ButtonSearchConnections();
        Transport _transport = new Transport();

        public List<string> SearchDepartures(string destination, string id)
        {
            var departuresList = new List<string>();
            var departures = _transport.GetStationBoard(destination, id);
            foreach (var item in departures.Entries)
                departuresList.Add("Verbindung nach:\t" + item.To + " um " +
                                   _buttonSearch.FormatTime(item.Stop.Departure.ToString()));

            return departuresList;
        }
    }
}