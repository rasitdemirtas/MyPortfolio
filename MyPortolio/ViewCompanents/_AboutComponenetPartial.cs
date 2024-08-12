using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.ViewCompanents
{
    public class _AboutComponenetPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext(); 
        public IViewComponentResult Invoke() 
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutdetail=portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}
