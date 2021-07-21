using System;
using System.Collections.Generic;
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

        public IActionResult Listado()
        {
            List<Asignatura> asignaturas= new List<Asignatura>();
            for (int i = 0; i < 5; i++)
            {
                var asignatura = new Asignatura();
                asignatura.Nombre="Asignatura "+i;
                asignatura.UniqueId=Guid.NewGuid().ToString();
                asignaturas.Add(asignatura);
            }
                        
            ViewBag.informacionAdicional="+ informacion de todas las Asignaturas";
            
            return View(asignaturas);
        }
    }
}