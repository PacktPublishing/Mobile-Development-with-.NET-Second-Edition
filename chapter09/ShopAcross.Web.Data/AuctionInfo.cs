using Newtonsoft.Json;

namespace ShopAcross.Web.Data
{
    public class AuctionInfo
    {
        [JsonProperty("auctionId")]
        public string AuctionId { get; set; }

        [JsonProperty("auctionReview")]
        public int AuctionReview { get; set; }
    }
}