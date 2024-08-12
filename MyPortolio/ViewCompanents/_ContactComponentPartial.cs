using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewCompanents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

        return View(); 
        }
    }
}
