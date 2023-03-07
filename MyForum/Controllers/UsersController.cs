using Microsoft.AspNetCore.Mvc;
using MyForum.DAL;
using MyForum.Services;

namespace MyForum.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService _service;

        public UsersController(IUsersService service)
        {
            _service = service;
        }
        

    }
}
