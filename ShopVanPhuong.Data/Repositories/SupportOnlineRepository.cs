using ShopVanPhuong.Data.Infrastructure;
using ShopVanPhuong.Model.Models;

namespace ShopVanPhuong.Data.Repositories
{
    public interface ISupportOnline : IRepository<SupportOnline>
    {

    }
    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnline
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
