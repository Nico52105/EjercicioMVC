using System;
using System.Collections.Generic;
using System.Linq;
using EjercicioMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioMVC.Controllers
{
    public class AlumnoController: Controller
    {
        private MyContext _context;
        public AlumnoController(MyContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            ViewBag.informacionAdicional="+ informacion de Asignatura";
            Alumno alumno=_context.Alumnos.FirstOrDefault();
            return View(alumno);
        }

        public IActionResult Listado()
        {
            ViewBag.informacionAdicional="+ informacion de todas los Alumnos";
            List<Alumno> listaAlumnos=_context.Alumnos.OrderBy((al) => al.Id).ToList();
            return View(listaAlumnos);
        }

        
    }
}