using ProjectWeb.Data;
using ProjectWeb.Models;
using ProjectWeb.Repository.IRepository;
using ProjectWeb.Repository.Repository;
using System.Linq.Expressions;

namespace ProjectWeb.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
