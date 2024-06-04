using AutoMapper;
using InventoryServiceAPI.Models;
using InventoryServiceAPI.Models.Dto;

namespace InventoryServiceAPI
{
    public class MappingConfiguration
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>()
                    .ForMember(dto => dto.Category, conf => conf.MapFrom(p => p.Category.Name))
                    .ForMember(dto => dto.Provider, conf => conf.MapFrom(p => p.Provider.Name))
                    .ForMember(dto => dto.Warehouse, conf => conf.MapFrom(p => p.Warehouse.Name))
                    .ReverseMap();
                config.CreateMap<Provider, ProviderDto>();
                config.CreateMap<ProviderDto, Provider>();
                config.CreateMap<Warehouse, WarehouseDto>();
                config.CreateMap<WarehouseDto, Warehouse>();
            });

            return mappingConfig;
        }
    }
}
