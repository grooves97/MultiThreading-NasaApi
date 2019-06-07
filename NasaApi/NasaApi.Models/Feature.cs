using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NasaApi.Models
{
    public class Feature
    {
        [JsonProperty("copyright")]
        public string Copyright { get; set; }
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("explanation")]
        public string Explanation { get; set; }
        [JsonProperty("hdurl")]
        public string Hdurl { get; set; }
        [JsonProperty("media_type")]
        public string Media_type { get; set; }
        [JsonProperty("service_version")]
        public string Service_version { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
