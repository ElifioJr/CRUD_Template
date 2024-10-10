using Microsoft.AspNetCore.Mvc;

namespace API_Template.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
