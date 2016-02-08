using Microsoft.AspNet.Mvc;
using TagHelpersAndViewComponents.Services;

namespace TagHelpersAndViewComponents.Components
{
	public class LastVisitsViewComponent : ViewComponent
	{
		private readonly IUserVisitsHistoryService userVisitsHistoryService;

		public LastVisitsViewComponent(IUserVisitsHistoryService userVisitsHistoryService)
		{
			this.userVisitsHistoryService = userVisitsHistoryService;
		}

		public IViewComponentResult Invoke(int historyDepth)
		{
			var model = userVisitsHistoryService.GetLastUserVisits(historyDepth);

			return View(model);
			//return Content("bla bla");
			//return View("Alternative", model);
		}

	}
}