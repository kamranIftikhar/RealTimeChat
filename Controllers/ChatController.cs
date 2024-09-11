using Microsoft.AspNetCore.Mvc;

namespace RealTimeChat.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
