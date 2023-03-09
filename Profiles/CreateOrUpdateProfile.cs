using AutoMapper;
using Models;
using MyForum.Controllers.Models;

namespace Profiles
{
    public class CreateOrUpdateProfile: Profile
    {
        public CreateOrUpdateProfile() 
        {
            CreateMap<CreateOrUpdateRequest, User>();
        }

    }
}