using AutoMapper;
using Models;
using MyForum.Controllers.Models;

namespace MyForum.Profiles
{
    public class CreateOrUpdateProfile : Profile
    {
        public CreateOrUpdateProfile()
        {
            CreateMap<UserEntity, User>();
        }

    }
}