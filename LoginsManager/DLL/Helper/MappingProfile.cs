using AutoMapper;
using DLL.DTO;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Helper
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>();

            CreateMap<Privilege, PrivilegeDTO>();

            CreateMap<Models.Profile, ProfileDTO>();

            CreateMap<ProfileDTO, Models.Profile>();

            CreateMap<ProfilePrivilege, ProfilePrivilegeDTO>();
        }

    }
    public static class AutoMapperConfiguration
    {
        public static IMapper Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            return config.CreateMapper();
        }
    }
}
