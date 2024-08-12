using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.ViewCompanents
{
    public class _ExperiencesComponentPartial : ViewComponent
    {
        MyPortfolioContext context =new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
    
}
