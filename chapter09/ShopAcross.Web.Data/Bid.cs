using Newtonsoft.Json;

namespace ShopAcross.Web.Data
{
    public class Bid
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("offer")]
        public Price Offer { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }
}