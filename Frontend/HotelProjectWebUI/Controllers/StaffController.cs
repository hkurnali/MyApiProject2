using Microsoft.AspNetCore.Mvc;

namespace HotelProjectWebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
