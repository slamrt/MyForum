using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace MyForum.Controllers
{
    [Route("Users")]
    public class UsersController : Controller
    {
        private readonly IUsersService _service;
/*        private readonly IMapper _mapper;
*/
        public UsersController(IUsersService service/*, IMapper mapper*/)
        {
            _service = service;
            //_mapper = mapper;
        }

        [HttpGet("GetUsers")]
        public List<User> GetUsers()
        {
            List<User> users =  _service.GetUsers();
            return users;
        }

        [HttpGet("{id}", Name = "Get")]
        public User GetUser(int id)
        {
/*            User user = _service.GetUser(id);
*/           // var response = _mapper.Map<GetResponse>(user);
            return _service.GetUser(id);
        }

        [HttpPost]
        public void Add([FromBody]User newUser)
        {
            /* var user = _mapper.Map<User>(newUser);
             _service.Add(user);*/
            _service.Add(newUser);
        }

        [HttpPut]
        public void Update(User newUser)
        {
            /*var user = _mapper.Map<User>(newUser);
            _service.Update(user);*/
            _service.Update(newUser);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }

    }
}
