using Newtonsoft.Json;
using System.Collections.Generic;

namespace PiNetworkNet.src.Dto
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class IncompleteServerPayments
    {
        [JsonProperty("incomplete_server_payments")]
        public List<PaymentDto> IncompletePayments { get; set; }
    }
}
