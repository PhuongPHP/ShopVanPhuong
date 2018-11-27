using ShopVanPhuong.Data.Infrastructure;
using ShopVanPhuong.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopVanPhuong.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTagPaging(Func<object, object> p, out int totalRow, int page, int pageSize);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }  
    }
}
