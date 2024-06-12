using AutoMapper;
using UserServiceAPI.Models;
using UserServiceAPI.Models.Dto;

namespace UserServiceAPI
{
    public class MappingConfiguration
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Role, RoleDto>();
                config.CreateMap<RoleDto, Role>();
                config.CreateMap<User, UserDto>();
                config.CreateMap<UserDto, User>();
            });

            return mappingConfig;
        }
    }
}
