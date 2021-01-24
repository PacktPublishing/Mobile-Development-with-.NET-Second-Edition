using Newtonsoft.Json;

namespace ShopAcross.Web.Data
{
    public class Fuel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}