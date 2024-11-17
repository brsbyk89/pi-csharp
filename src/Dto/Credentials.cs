using Newtonsoft.Json;
using System.Collections.Generic;

namespace PiNetworkNet.src.Dto
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class Credentials
    {
        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; }
        [JsonProperty("valid_until")]
        public PiValidTime ValidTime { get; set; }
    };
}
