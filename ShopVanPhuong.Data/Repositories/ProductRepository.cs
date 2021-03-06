﻿using ShopVanPhuong.Data.Infrastructure;
using ShopVanPhuong.Model.Models;


namespace ShopVanPhuong.Data.Repositories
{
    public interface IProductRepository
    {

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
