using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewCompanents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
