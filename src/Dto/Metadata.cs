using Newtonsoft.Json;
using System;

namespace PiNetworkNet.src.Dto
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class Metadata
    {
        [JsonProperty("id")]
        public Guid? Id { get; set; }
        [JsonProperty("cat")]
        public string Category { get; set; }
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
