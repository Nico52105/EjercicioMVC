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
            //var escuela = new Escuela();
            //escuela.Nombre="Escuela Nicolas";
            //escuela.AñoDeCreación=2021;
            //escuela.UniqueId=Guid.NewGuid().ToString();
            //escuela.TipoEscuela=TiposEscuela.Secundaria;
            //escuela.Dirección="Calle 1 # 10 - 20";
            //escuela.Pais="Colombia";
            //escuela.Ciudad="Bogota";

            ViewBag.informacionAdicional="+ informacion";
            var escuela=_context.Escuelas.FirstOrDefault();
            return View(escuela);
        }
    }
}