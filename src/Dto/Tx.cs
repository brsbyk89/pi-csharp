using Newtonsoft.Json;

namespace PiNetworkNet.src.Dto
{

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class Tx
    {
        [JsonProperty("txid")]
        public string TxId { get; set; }
    }
}
