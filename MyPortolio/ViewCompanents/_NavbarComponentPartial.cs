using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewCompanents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
}
}
