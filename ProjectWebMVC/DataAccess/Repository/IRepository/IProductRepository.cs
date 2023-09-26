using ProjectWeb.Models;

namespace ProjectWeb.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);

    }
}
