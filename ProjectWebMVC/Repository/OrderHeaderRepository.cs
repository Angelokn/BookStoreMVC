using ProjectWeb.Data;
using ProjectWeb.Models;
using ProjectWeb.Repository.IRepository;
using ProjectWeb.Repository.Repository;
using System.Linq.Expressions;

namespace ProjectWeb.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderHeader obj)
        {
            _db.OrderHeaders.Update(obj);
        }
    }
}
