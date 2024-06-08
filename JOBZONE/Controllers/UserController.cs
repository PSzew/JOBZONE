using Microsoft.AspNetCore.Mvc;

namespace JOBZONE.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
