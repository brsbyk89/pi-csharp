using Newtonsoft.Json;

namespace PiNetworkNet.src.Dto
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class PiNetworkError
    {
        [JsonProperty("error")]
        public string ErrorName { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty("payment")]
        public PaymentDto Payment { get; set; }
    }
}
