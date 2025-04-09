using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents
{
    public class _FaetureComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
