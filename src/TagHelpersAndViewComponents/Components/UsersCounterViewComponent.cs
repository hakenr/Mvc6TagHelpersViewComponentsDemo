using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using TagHelpersAndViewComponents.Models;

namespace TagHelpersAndViewComponents.Components
{
	[ViewComponent(Name = "CountOfUsers")]
	public class UsersCounterViewComponent : ViewComponent
	{
		private readonly ApplicationDbContext dbContext;

		public UsersCounterViewComponent(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var count = await dbContext.ApplicationUser.CountAsync();

			return View(count);
		}
	}
}