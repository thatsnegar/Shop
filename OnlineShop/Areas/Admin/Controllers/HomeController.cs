using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
	[Area(areaName: nameof(Admin))]

	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
