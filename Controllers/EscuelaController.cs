using Microsoft.AspNetCore.Mvc;

namespace EjercicioMVC.Controllers
{
    public class EscuelaController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
    }
}