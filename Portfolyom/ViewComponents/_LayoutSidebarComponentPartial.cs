using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents
{
    public class _LayoutSidebarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
