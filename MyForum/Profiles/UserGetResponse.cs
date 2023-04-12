using AutoMapper;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForum.Profiles
{
    public class UserGetResponse: Profile
    {
        public UserGetResponse()
        {
            CreateMap<User, UserEntity>();    
        }    
        
    }
}
