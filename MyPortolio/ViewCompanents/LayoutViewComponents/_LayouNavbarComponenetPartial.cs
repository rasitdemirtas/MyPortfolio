using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.ViewCompanents.LayoutViewComponents
{
	public class _LayouNavbarComponenetPartial : ViewComponent
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount=context.ToDoLists.Where(x => x.Status == false).Count();
			var values =context.ToDoLists.Where(x=>x.Status ==false).ToList();
			return View(values);
		}
	}
}
