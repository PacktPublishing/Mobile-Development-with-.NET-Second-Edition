using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

using ShopAcross.Web.Data;
using ShopAcross.Web.Repository.Cosmos;

namespace ShopAcross.Web.Api.Controllers
{
    public class UsersController : ODataController
    {
        private readonly IDistributedCache _distributedCache;

        public UsersController(IDistributedCache distributedCacheInstance)
        {
            _distributedCache = distributedCacheInstance;
        }

        // GET: api/Users
        [EnableQuery]
        public async Task<IActionResult> Get()
        {
            var cosmosCollection = new CosmosCollection<User>("UsersCollection");
            var items = await cosmosCollection.GetItemsAsync();

            return Ok(items.AsQueryable());
        }

        [EnableQuery]
        public IActionResult Get(string key)
        {
            var cosmosCollection = new CosmosCollection<User>("UsersCollection");
            return Ok(cosmosCollection.GetItemAsync(key));
        }
    }
}
