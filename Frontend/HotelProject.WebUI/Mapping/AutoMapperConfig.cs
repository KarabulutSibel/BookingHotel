using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;

namespace HotelProject.WebUI.Mapping
{
	public class AutoMapperConfig : Profile
	{
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>();
            CreateMap<CreateServiceDto, Service>();
			CreateMap<UpdateServiceDto, Service>();
            CreateMap<CreateNewUserDto, AppUser>();
            CreateMap<LoginUserDto, AppUser>();
		}
    }
}
