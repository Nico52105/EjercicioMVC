using System;
using EjercicioMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioMVC.Controllers
{
    public class AsignaturaController: Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura();
            asignatura.Nombre="Programacion";
            asignatura.UniqueId=Guid.NewGuid().ToString();
            
            ViewBag.informacionAdicional="+ informacion de Asignatura";
            
            return View(asignatura);
        }
    }
}