using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NasaApi.Models
{
    public class FeatureCollection
    {
        [JsonProperty("features")]
        public List<Feature> Features { get; set; }
    }
}
