using System;
using System.Collections.Generic;
using System.Globalization;
using SwissTransport;

namespace SwissTransportUI
{
    class ButtonSearchConnections
    {
        Transport _transport = new Transport();

        public List<string> SearchConnections(string textStart, string textDest)
        {
            var connectionsList = new List<string>();
            var connections = _transport.GetConnections(textStart, textDest);
            foreach (var item in connections.ConnectionList)
                connectionsList.Add("Abfahrt:\t" + FormatTime(item.From.Departure) + "\t" + item.From.Station.Name +
                                    "\t\t" +
                                    "Ankunft:\t" + FormatTime(item.To.Arrival) + "\t" + item.To.Station.Name);

            return connectionsList;
        }

        /// <summary>
        ///     Formatiert den String vom ISO-Format in ein DateTime Format und gibt die Uhrzeit nach europäischem Standart mit der korrekten Zeitzohne aus.
        /// </summary>
        /// <param name="timeToFormat"></param>
        /// <returns></returns>
        public string FormatTime(string timeToFormat)
        {
            var iso8601String = timeToFormat;

            var tempdate = DateTime.Parse(iso8601String);
            timeToFormat = tempdate.ToString("t", CultureInfo.InvariantCulture);

            return timeToFormat;
        }
    }
}