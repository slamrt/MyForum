using Microsoft.AspNetCore.Mvc;

namespace MyForum.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
