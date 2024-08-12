using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewCompanents
{
    public class _PortfolioComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
