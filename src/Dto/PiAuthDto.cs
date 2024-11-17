using Newtonsoft.Json;

namespace PiNetworkNet.src.Dto
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class PiAuthDto
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("user")]
        public PiUser User { get; set; }
    }
}
