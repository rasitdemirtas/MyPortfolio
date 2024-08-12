using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewCompanents.LayoutViewComponents
{
	public class _LayoutSidebarComponenetPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
