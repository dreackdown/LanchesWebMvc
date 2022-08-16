using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebMvc.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
