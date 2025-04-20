using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
