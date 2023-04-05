using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
	public class AdminPanelController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
