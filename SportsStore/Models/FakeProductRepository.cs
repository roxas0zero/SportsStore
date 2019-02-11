using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Football", Price = 25},
            new Product { Name = "Surf Board", Price = 40},
            new Product { Name = "Running Shoes", Price = 65}
        }.AsQueryable<Product>();
    }
}
