using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models;
using MyForum.Controllers.Models;
using Services;

namespace MyForum.Controllers
{
    [Route("/api[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersService _service;
        private readonly IMapper _mapper;

        public UsersController(IUsersService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public List<User> GetUsers()
        {
            return _service.GetUsers();
        }

        [HttpPost]
        public void Add(CreateOrUpdateRequest newUser)
        {
            var user = _mapper.Map<User>(newUser);
            _service.Add(user);
        }

        [HttpPut]
        public void Update(User user)
        {
            _service.Update(user);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }

    }
}
