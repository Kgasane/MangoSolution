using AutoMapper;
using Mango.Services.ProductAPI.Model;
using Mango.Services.ProductAPI.Model.Dto;

namespace Mango.Services.ProductAPI
{
    public class AutoMappingConfig
    {
        public static MapperConfiguration RegisterAutoMaps()
        {
            var mappingconfig = new MapperConfiguration(config => {
                config.CreateMap<ProductDto, Product>().ReverseMap();
                //config.CreateMap<Product, ProductDto>();
            });
            return mappingconfig;
        }
    }
}
