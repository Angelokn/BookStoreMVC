using ProjectWeb.Data;
using ProjectWeb.Repository;

namespace ProjectWeb.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public ICompanyRepository Company { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
