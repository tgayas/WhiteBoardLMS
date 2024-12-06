using Microsoft.AspNetCore.Mvc;

namespace WhiteBoardLMS.Controllers
{
    public class Homelogin : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
