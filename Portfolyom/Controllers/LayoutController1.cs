using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.Controllers
{
    public class LayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
