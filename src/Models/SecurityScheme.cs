using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwaggerNet.Models
{
    public class SecurityScheme
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("in")]
        public string _in { get; set; }

        [JsonProperty("flow")]
        public string Flow { get; set; }

        [JsonProperty("authorizationUrl")]
        public string AuthorizationUrl { get; set; }

        [JsonProperty("tokenUrl")]
        public string TokenUrl { get; set; }

        [JsonProperty("scopes")]
        public Dictionary<string, string> Scopes { get; set; }
    }
}
