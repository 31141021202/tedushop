﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.Mappings
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
                cfg.CreateMap<PostTag, PostTagViewModel>();

                cfg.CreateMap<Product, ProductViewModel>();
                cfg.CreateMap<ProductTag, ProductTagViewModel>();
                cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();

            });

            //var config = new MapperConfiguration(cfg => 
            //{
            //    cfg.CreateMap<Post, PostViewModel>();
            //    cfg.CreateMap<PostCategory, PostCategoryViewModel>();
            //    cfg.CreateMap<Tag, TagViewModel>();
            //    cfg.CreateMap<PostTag, PostTagViewModel>();
            //});
        }
    }
}