using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.JsonPatch;

using ShopAcross.Web.Data;
using ShopAcross.Web.Repository.Cosmos;

namespace ShopAcross.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuctionsController : ODataController
    {

        private readonly ILogger<AuctionsController> _logger;

        public AuctionsController(ILogger<AuctionsController> logger)
        {
            _logger = logger;
        }

        // GET: api/Users
        [EnableQuery]
        public async Task<IActionResult> Get()
        {
            var cosmosCollection = new CosmosCollection<Auction>("AuctionsCollection");
            var items = await cosmosCollection.GetItemsAsync();

            return Ok(items.AsQueryable());
        }

        [EnableQuery]
        public async Task<IActionResult> Get(string key)
        {
            // Get the version stamp of the entity
            string entityTag = string.Empty;

            if (Request.Headers.ContainsKey("If-None-Match"))
            {
                entityTag = Request.Headers["If-None-Match"].First();
            }

            var cosmosCollection = new CosmosCollection<Auction>("AuctionsCollection");
            var resultantSet = await cosmosCollection.GetItemsAsync(item => item.Id == key);
            var auction = resultantSet.FirstOrDefault();

            if (auction == null)
            {
                return NotFound();
            }

            if (int.TryParse(entityTag, out int timeStamp) && auction.TimeStamp == timeStamp)
            {
                return StatusCode((int)HttpStatusCode.NotModified);


            }

            return Ok(auction);
        }

        [EnableQuery]
        [HttpPatch]
        public async Task<IActionResult> Patch(string key, [FromBody] JsonPatchDocument<Auction> auctionPatch)
        {
            var cosmosCollection = new CosmosCollection<Auction>("AuctionsCollection");
            var auction = (await cosmosCollection.GetItemsAsync(item => item.Id == key)).FirstOrDefault();

            if (auction == null)
            {
                return NotFound();
            }

            auctionPatch.ApplyTo(auction);

            await cosmosCollection.UpdateItemAsync(key, auction);

            return Accepted(auction);
        }

        [EnableQuery]
        [HttpPut]
        public async Task<IActionResult> Put([FromODataUri] string key, [FromBody] Auction auctionUpdate)
        {
            var cosmosCollection = new CosmosCollection<Auction>("AuctionsCollection");
            var auction = (await cosmosCollection.GetItemsAsync(item => item.Id == key)).FirstOrDefault();

            if (auction == null)
            {
                return NotFound();
            }

            if (auction.TimeStamp != auctionUpdate.TimeStamp)
            {
                return Conflict();
            }

            await cosmosCollection.UpdateItemAsync(key, auctionUpdate);

            return Accepted(auction);
        }
    }
}
