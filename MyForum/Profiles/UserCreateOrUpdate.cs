using AutoMapper;
using Models;
namespace MyForum.Profiles
{
    public class UserCreateOrUpdate : Profile
    {
        public UserCreateOrUpdate()
        {
            CreateMap<UserEntity, User>();
        }

    }
}