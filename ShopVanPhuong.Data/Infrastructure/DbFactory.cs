using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopVanPhuong.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopVanPhuongDbContext dbContext;
        public ShopVanPhuongDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopVanPhuongDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
