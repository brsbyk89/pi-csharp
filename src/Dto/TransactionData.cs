using Newtonsoft.Json;

namespace PiNetworkNet.src.Dto
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class TransactionData
    {
        public double Amount;
        public string Identifier;
        public string FromAddress;
        public string ToAddress;
    }
}
