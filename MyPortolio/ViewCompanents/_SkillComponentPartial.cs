

using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.ViewCompanents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }

}
