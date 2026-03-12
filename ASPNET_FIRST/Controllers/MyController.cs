using Microsoft.AspNetCore.Mvc;

namespace ASPNET_FIRST.Controllers
{
    public class MyController : Controller
    {

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
