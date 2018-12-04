﻿using Newtonsoft.Json;

namespace SwissTransport
{
    public class Coordinate
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("x")]
        public double XCoordinate { get; set; }

        [JsonProperty("y")]
        public double YCoordinate { get; set; }
    }
}