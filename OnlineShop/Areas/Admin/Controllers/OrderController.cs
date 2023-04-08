using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area(areaName: nameof(Admin))]
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
