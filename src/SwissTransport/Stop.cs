using System;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Stop
    {
        [JsonProperty("departure")]
        public DateTime Departure { get; set; }
    }
}