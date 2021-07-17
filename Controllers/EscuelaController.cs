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
            escuela.AñoFundacion=2021;
            escuela.EscuelaId=Guid.NewGuid().ToString();
            
            return View(escuela);
        }
    }
}