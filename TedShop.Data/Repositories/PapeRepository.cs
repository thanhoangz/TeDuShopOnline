using TedShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.Repositories
{
    public interface IPapeRepository : IRepository<Page>
    {
    }

    public class PapeRepository : RepositoryBase<Page>, IPapeRepository
    {
        public PapeRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}