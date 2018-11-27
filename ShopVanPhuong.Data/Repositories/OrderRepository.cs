using ShopVanPhuong.Data.Infrastructure;
using ShopVanPhuong.Model.Models;

namespace ShopVanPhuong.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
