using ProjectWeb.Data;
using ProjectWeb.Models;
using ProjectWeb.Repository.IRepository;
using ProjectWeb.Repository.Repository;
using System.Linq.Expressions;

namespace ProjectWeb.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
