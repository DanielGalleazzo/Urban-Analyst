using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UrbanAnalyst_V1
{
    public class Localizador
    {
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }
    }
}
