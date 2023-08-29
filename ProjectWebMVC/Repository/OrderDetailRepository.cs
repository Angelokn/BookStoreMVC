using ProjectWeb.Data;
using ProjectWeb.Models;
using ProjectWeb.Repository.IRepository;
using ProjectWeb.Repository.Repository;
using System.Linq.Expressions;

namespace ProjectWeb.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _db;

        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}
