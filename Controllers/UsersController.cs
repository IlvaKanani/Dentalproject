using Microsoft.AspNetCore.Mvc;

namespace PROJECT.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
