using Newtonsoft.Json;
using SwaggerNet.Models;
using System.IO;

namespace SwaggerNet.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePaht = @"docs\petstore.json";
            string fileContent = File.ReadAllText(filePaht);
            var settings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore,
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore
            };

            var swaggerObj = JsonConvert.DeserializeObject<Service>(fileContent, settings);

            string newFilePath = @"docs\petstore2.json";
            File.WriteAllText(newFilePath, JsonConvert.SerializeObject(swaggerObj, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));
        }
    }
}
