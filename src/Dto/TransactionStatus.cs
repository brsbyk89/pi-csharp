using Newtonsoft.Json;

namespace PiNetworkNet.src.Dto
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class TransactionStatus
    {
        [JsonProperty("txid")]
        public string TxId { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("_link")]
        public string Link { get; set; }
    }
}
