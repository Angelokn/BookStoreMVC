using ProjectWeb.DataAccess.Data;
using ProjectWeb.DataAccess.Repository.IRepository;
using ProjectWeb.Models;
using System.Linq.Expressions;

namespace ProjectWeb.DataAccess.Repository
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
