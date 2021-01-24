using Newtonsoft.Json;

namespace ShopAcross.Web.Data
{
    public class Address
    {
        [JsonProperty("addressTypeId")]
        public int AddressTypeId { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("street1")]
        public string Street1 { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}