using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewCompanents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
