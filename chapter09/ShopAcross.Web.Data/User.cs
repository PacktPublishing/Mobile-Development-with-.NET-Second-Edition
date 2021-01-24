using System.Collections.Generic;

using Newtonsoft.Json;

namespace ShopAcross.Web.Data
{
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("numberOfAuctions")]
        public int NumberOfAuctions { get; set; }

        [JsonProperty("auctions")]
        public List<AuctionInfo> Auctions { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}