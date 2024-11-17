using Newtonsoft.Json;

namespace PiNetworkNet.src.Dto
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public sealed class CreatePaymentDto
    {
        [JsonProperty("payment")]
        public PaymentArgs Payment;
    }
}
