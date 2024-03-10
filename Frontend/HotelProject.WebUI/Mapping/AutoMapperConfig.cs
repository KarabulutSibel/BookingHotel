using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using HotelProject.WebUI.Dtos.TestimonialDto;

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

            CreateMap<ResultAboutDto, About>();
            CreateMap<UpdateAboutDto, About>();

            CreateMap<ResultTestimonialDto, Testimonial>();

            CreateMap<ResultStaffDto, Staff>();

            CreateMap<CreateSubscribeDto, Subscribe>();
		}
    }
}
