using Newtonsoft.Json;

namespace PiNetworkNet.src.Dto
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class Status
    {
        [JsonProperty("developer_approved")]
        public bool DeveloperApproved { get; set; }

        [JsonProperty("transaction_verified")]
        public bool TransactionVerified { get; set; }

        [JsonProperty("developer_completed")]
        public bool DeveloperCompleted { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("user_cancelled")]
        public bool UserCancelled { get; set; }
    }
}
