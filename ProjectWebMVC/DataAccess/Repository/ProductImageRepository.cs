using ProjectWeb.DataAccess.Data;
using ProjectWeb.DataAccess.Repository.IRepository;
using ProjectWeb.Models;
using System.Linq.Expressions;

namespace ProjectWeb.DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private ApplicationDbContext _db;

        public ProductImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}
