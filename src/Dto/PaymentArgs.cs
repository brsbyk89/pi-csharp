using Newtonsoft.Json;

namespace PiNetworkNet.src.Dto
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class PaymentArgs
    {
        [JsonProperty("amount")]
        public double Amount;
        [JsonProperty("memo")]
        public string Memo;
        [JsonProperty("metadata")]
        public object Metadata;
        [JsonProperty("uid")]
        public string Uid;
    }
}
