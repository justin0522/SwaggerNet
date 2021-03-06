﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace SwaggerNet.Models
{
    public class Response
    {
        [JsonProperty("description", Required = Required.Always)]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("schema")]
        public Schema Schema { get; set; }

        [JsonProperty("headers")]
        public Dictionary<string, Header> Headers { get; set; }

        [JsonProperty("examples")]
        public Examples Examples { get; set; }
    }
}
