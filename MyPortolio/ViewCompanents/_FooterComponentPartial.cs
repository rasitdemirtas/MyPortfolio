using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;
using NuGet.Protocol;

namespace MyPortolio.ViewCompanents
{
    public class _FooterComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }

    }
}
