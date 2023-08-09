using ProjectWeb.Models;
using ProjectWeb.Repository.Repository;

namespace ProjectWeb.Repository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
