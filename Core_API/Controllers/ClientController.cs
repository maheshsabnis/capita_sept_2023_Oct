using Microsoft.AspNetCore.Mvc;

namespace Core_API.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
