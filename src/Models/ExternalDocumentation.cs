using Newtonsoft.Json;

namespace SwaggerNet.Models
{
    public class ExternalDocumentation
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url", Required = Required.Always)]
        public string Url { get; set; }

    }
}
