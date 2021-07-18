using System;
using EjercicioMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioMVC.Controllers
{
    public class EscuelaController : Controller
    { 
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.Nombre="Escuela Nicolas";
            escuela.AñoDeCreación=2021;
            escuela.UniqueId=Guid.NewGuid().ToString();

            ViewBag.informacionAdicional="+ informacion";
            
            return View(escuela);
        }
    }
}