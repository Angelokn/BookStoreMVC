using ProjectWeb.Models;
using ProjectWeb.Repository.Repository;

namespace ProjectWeb.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);

    }
}
