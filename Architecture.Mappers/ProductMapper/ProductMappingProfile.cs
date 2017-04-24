﻿using Architecture.Database.Entities;
using AutoMapper;
using Architecture.Models;
using Architecture.Database.Entities.Shared;
using System.Collections.Generic;

namespace Architecture.Mappers.ProductMapper
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductBase>();
            CreateMap<Product, ProductMinimal>()
                .ForMember(
                    dest => dest.Brand,
                    prop => prop.MapFrom(x => x.Brand)
                );


            // TODO: Find another method to map all properties manually
            // Mapping Product.ProductCategories to ProductFull.Categories
            CreateMap<ProductCategory, CategoryBase>()
                .ForMember(
                    dest => dest.Id,
                    prop => prop.MapFrom(x => x.Category.Id)
                )
                .ForMember(
                    dest => dest.Title,
                    prop => prop.MapFrom(x => x.Category.Title)
                );

            CreateMap<ProductTag, TagBase>()
                .ForMember(
                    dest => dest.Id,
                    prop => prop.MapFrom(x => x.Tag.Id)
                )
                .ForMember(
                    dest => dest.Title,
                    prop => prop.MapFrom(x => x.Tag.Title)
                );

            CreateMap<Product, ProductFull>()
                .ForMember(
                    dest => dest.Brand,
                    prop => prop.MapFrom(x => x.Brand)
                )
                .ForMember(
                    dest => dest.Categories,
                    prop => prop.MapFrom(x => x.ProductCategories)
                );
            //.ForMember(
            //    dest => dest.Categories,
            //    prop => prop.ResolveUsing<ProductCategoriesResolver>()
            //);
            //.ForMember(
            //    dest => dest.Ratings,
            //    prop => prop.ResolveUsing<ProductRatingsResolver>()
            //);

            CreateMap<ProductBase, Product>();
        }
    }
}
