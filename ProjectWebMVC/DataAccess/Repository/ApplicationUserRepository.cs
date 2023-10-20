using ProjectWeb.DataAccess.Data;
using ProjectWeb.DataAccess.Repository.IRepository;
using ProjectWeb.Models;
using System.Linq.Expressions;

namespace ProjectWeb.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ApplicationUser applicationUser)
        {
            _db.ApplicationUsers.Update(applicationUser);
        }

    }
}
