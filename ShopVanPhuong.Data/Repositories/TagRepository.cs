using ShopVanPhuong.Data.Infrastructure;
using ShopVanPhuong.Model.Models;


namespace ShopVanPhuong.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {

    }
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
