using System;
using System.Collections.Generic;
using System.Linq;
using EjercicioMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioMVC.Controllers
{
    public class AsignaturaController: Controller
    {
        private MyContext _context;
        public AsignaturaController(MyContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            ViewBag.informacionAdicional="+ informacion de Asignatura";
            var asignatura=_context.Asignaturas.FirstOrDefault();
            return View(asignatura);
        }

        public IActionResult Listado()
        {
            ViewBag.informacionAdicional="+ informacion de todas las Asignaturas";
            var asignaturas=_context.Asignaturas.ToList();
            return View(asignaturas);
        }
    }
}