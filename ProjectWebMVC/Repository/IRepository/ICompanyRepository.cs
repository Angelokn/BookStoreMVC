using ProjectWeb.Models;

namespace ProjectWeb.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
    }
}
