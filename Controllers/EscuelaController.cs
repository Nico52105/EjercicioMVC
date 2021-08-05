using System;
using System.Linq;
using EjercicioMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioMVC.Controllers
{
    public class EscuelaController : Controller
    { 
        private MyContext _context;

        public EscuelaController(MyContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            ViewBag.informacionAdicional="+ informacion";
            var escuela=_context.Escuelas.FirstOrDefault();
            return View(escuela);
        }
    }
}