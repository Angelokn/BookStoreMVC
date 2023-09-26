using ProjectWeb.DataAccess.Data;
using ProjectWeb.DataAccess.Repository.IRepository;
using ProjectWeb.Models;
using System.Linq.Expressions;

namespace ProjectWeb.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
