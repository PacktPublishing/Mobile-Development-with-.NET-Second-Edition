using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopAcross.Web.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetItemAsync(string id);

        Task<IEnumerable<T>> GetItemsAsync(Expression<Func<T, bool>> predicate);
        
        Task<T> AddItemAsync(T item);
        
        Task DeleteItemAsync(string id);
        
        Task<T> UpdateItemAsync(string id, T item);
    }

}
