using Newtonsoft.Json;
using System;

namespace PiNetworkNet.src.Dto
{

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class PaymentDto
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("user_uid")]
        public string Useruid { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("memo")]
        public string Memo { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("from_address")]
        public string FromAddress { get; set; }

        [JsonProperty("to_address")]
        public string ToAddress { get; set; }

        [JsonProperty("created_at")]
        //public string created_at { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("transaction")]
        public TransactionStatus Transaction { get; set; }
    }
}
