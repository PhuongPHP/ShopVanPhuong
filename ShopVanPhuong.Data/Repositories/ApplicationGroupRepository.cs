using ShopVanPhuong.Data.Infrastructure;
using ShopVanPhuong.Model.Models;

namespace ShopVanPhuong.Data.Repositories
{
    public interface IApplicationGroupRepository : IRepository<ApplicationGroup>
    {

    }
    public class ApplicationGroupRepository : RepositoryBase<ApplicationGroup>, IApplicationGroupRepository
    {
        public ApplicationGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
