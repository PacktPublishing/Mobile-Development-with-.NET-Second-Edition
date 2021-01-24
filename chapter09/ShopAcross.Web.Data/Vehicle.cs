using Newtonsoft.Json;

namespace ShopAcross.Web.Data
{
    public class Vehicle
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("engine")]
        public Engine Engine { get; set; }

        [JsonProperty("primaryPicture")]
        public string PrimaryPicture { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }
}