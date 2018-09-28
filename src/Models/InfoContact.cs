using Newtonsoft.Json;

namespace SwaggerNet.Models
{
    public class InfoContact
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
