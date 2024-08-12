using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.ViewCompanents
{
    public class _FeatureComponentPartial :ViewComponent
    {
        MyPortfolioContext portolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portolioContext.Features.ToList();
            return View(values); 
        }
    }
}
