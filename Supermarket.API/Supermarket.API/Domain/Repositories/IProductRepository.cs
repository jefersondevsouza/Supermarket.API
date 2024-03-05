using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
        Task AddAsync(Product produto);
        Task<Product> FindByIdAsync(int id);
        void Update(Product produto);
        void Remove(Product produto);
    }
}