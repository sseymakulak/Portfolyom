using Microsoft.AspNetCore.Mvc;
using Portfolyom.DAL.Context;

namespace Portfolyom.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context= new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
           return View(values);
        }
    }
}
