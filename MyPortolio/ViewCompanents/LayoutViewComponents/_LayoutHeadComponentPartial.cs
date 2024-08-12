using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewCompanents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{ 
			return View();
		}

	}
}
