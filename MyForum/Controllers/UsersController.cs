using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models;
using MyForum.Controllers.Models;
using Services;

namespace MyForum.Controllers
{
    [Route("Users")]
    public class UsersController : Controller
    {
        private readonly IUsersService _service;
        private readonly IMapper _mapper;

        public UsersController(IUsersService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("GetUsers")]
        public List<GetResponse> GetUsers()
        {
            List<User> users =  _service.GetUsers();
            List<GetResponse> results = _mapper.Map<List<User>,List<GetResponse>>(users);
            return results;
        }

        [HttpGet("{id}", Name = "Get")]
        public GetResponse GetUser(int id)
        {
            User user = _service.GetUser(id);
            var response = _mapper.Map<GetResponse>(user);
            return response;
        }

        [HttpPost]
        public void Add([FromBody]CreateOrUpdateRequest newUser)
        {
            var user = _mapper.Map<User>(newUser);
            _service.Add(user);
        }

        [HttpPut]
        public void Update(CreateOrUpdateRequest newUser)
        {
            var user = _mapper.Map<User>(newUser);
            _service.Update(user);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }

    }
}
