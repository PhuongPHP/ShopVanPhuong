using AutoMapper;
using ShopVanPhuong.Model.Models;
using ShopVanPhuong.Web.Models;


namespace ShopVanPhuong.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
            });
        }
    }
}