using Newtonsoft.Json;
using System;

namespace PiNetworkNet.src.Dto
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class PiValidTime
    {
        [JsonProperty("timestamp")]
        public long TimeStamp { get; set; }
        [JsonProperty("iso8601")]
        public DateTimeOffset Iso8601 { get; set; }
    }
}
