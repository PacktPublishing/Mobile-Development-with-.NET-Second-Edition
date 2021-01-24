using Newtonsoft.Json;

namespace ShopAcross.Web.Data
{
    public class Engine
    {
        [JsonProperty("displacement")]
        public string Displacement { get; set; }

        [JsonProperty("power")]
        public int Power { get; set; }

        [JsonProperty("torque")]
        public int Torque { get; set; }

        [JsonProperty("fuel")]
        public Fuel Fuel { get; set; }
    }
}