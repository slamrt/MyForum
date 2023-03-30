using AutoMapper;
using Models;
using MyForum.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForum.Profiles
{
    public class GetResponse: Profile
    {
        public GetResponse()
        {
            CreateMap<User, UserEntity>();    
        }    
        
    }
}
