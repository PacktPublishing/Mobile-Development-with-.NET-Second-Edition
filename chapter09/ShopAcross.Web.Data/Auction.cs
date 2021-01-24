using System;

using Newtonsoft.Json;

namespace ShopAcross.Web.Data
{
    public class Auction
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("vehicle")]
        public Vehicle Vehicle { get; set; }

        [JsonProperty("startingPrice")]
        public Price StartingPrice { get; set; }

        [JsonProperty("highestBids")]
        public Bid[] HighestBids { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("_ts")]
        public int TimeStamp { get; set; }
    }
}
