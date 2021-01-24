using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Linq;

namespace ShopAcross.Web.Repository.Cosmos
{
    public class CosmosCollection<T> : IRepository<T> where T : class
    {
        private Container _cosmosContainer;

        public CosmosCollection(string collectionName)
        {
            CollectionId = collectionName;

            var client = new CosmosClient(Endpoint, Key);
            var database = client.GetDatabase(DatabaseId);
            _cosmosContainer = database.GetContainer(CollectionId);
        }

        public string DatabaseId { get; set; }

        public string CollectionId { get; set; }

        public string Endpoint { get; set; }

        public string Key { get; set; }

        public async Task<T> GetItemAsync(string id)
        {
            // Query for items by a property other than Id
            QueryDefinition queryDefinition = new QueryDefinition(
                    $"select * from {CollectionId} c where c.Id = @EntityId")
                .WithParameter("@EntityId", id);

            using FeedIterator<T> resultSet = _cosmosContainer.GetItemQueryIterator<T>(queryDefinition);
            var response = await resultSet.ReadNextAsync();
            return response.FirstOrDefault();
        }

        public async Task<IEnumerable<T>> GetItemsAsync()
        {
            using FeedIterator<T> resultSet = _cosmosContainer.GetItemLinqQueryable<T>(
                    requestOptions: new QueryRequestOptions
                                        {
                                            MaxItemCount = -1,
                                            PartitionKey = new PartitionKey("USA")
                                        })
                .ToFeedIterator();

            List<T> results = new List<T>();

            while (resultSet.HasMoreResults)
            {
                FeedResponse<T> response = await resultSet.ReadNextAsync();
                results.AddRange(response);
            }

            return results;
        }

        public async Task<IEnumerable<T>> GetItemsAsync(
            Expression<Func<T, bool>> predicate)
        {
            using FeedIterator<T> resultSet = _cosmosContainer.GetItemLinqQueryable<T>(
                    requestOptions: new QueryRequestOptions
                    {
                        MaxItemCount = -1,
                        PartitionKey = new PartitionKey("USA")
                    })
                .Where(predicate)
                .ToFeedIterator();
            
            List<T> results = new List<T>();

            while (resultSet.HasMoreResults)
            {
                FeedResponse<T> response = await resultSet.ReadNextAsync();
                results.AddRange(response);
            }

            return results;
        }

        public async Task<T> AddItemAsync(T item)
        {
            var resp = await _cosmosContainer.CreateItemAsync(item);
            return resp.Resource;
        }

        public async Task<T> UpdateItemAsync(string id, T item)
        {
            var resp = await _cosmosContainer.ReplaceItemAsync(item, id);
            return resp.Resource;
        }

        public async Task DeleteItemAsync(string id)
        {
            _ = await _cosmosContainer.DeleteItemAsync<T>(id, PartitionKey.None);
        }

    }
}
