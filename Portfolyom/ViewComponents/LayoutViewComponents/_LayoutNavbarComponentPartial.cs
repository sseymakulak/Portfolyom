using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
