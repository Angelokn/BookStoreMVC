using ProjectWeb.Models;
using ProjectWeb.Repository.Repository;

namespace ProjectWeb.Repository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
    }
}
