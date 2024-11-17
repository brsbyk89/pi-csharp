using Newtonsoft.Json;

namespace PiNetworkNet.src.Dto
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class PiUser
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("credentials")]
        public Credentials Credentials { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
