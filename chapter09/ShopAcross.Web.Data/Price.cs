using Newtonsoft.Json;

namespace ShopAcross.Web.Data
{
    public class Price
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("currency")]
        public Currency Currency { get; set; }
    }
}