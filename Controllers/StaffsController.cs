using Microsoft.AspNetCore.Mvc;

namespace PROJECT.Controllers
{
    public class StaffsController : Controller
    {
        //private readonly IStaffsService staffsService;

        public IActionResult Index()
        {
            return View();
        }
    }
}
