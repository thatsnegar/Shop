using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
	public class OrdersController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
