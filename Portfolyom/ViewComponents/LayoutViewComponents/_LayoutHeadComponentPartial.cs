using Microsoft.AspNetCore.Mvc;

namespace Portfolyom.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {  
            return View(); 
        }
    }
}
