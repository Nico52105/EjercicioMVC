using System;
using System.Collections.Generic;
using System.Linq;
using EjercicioMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EjercicioMVC.Controllers
{
    public class AlumnoController: Controller
    {
        public IActionResult Index()
        {
            var alumno = new Alumno();
            alumno.Nombre="Alumno";
            alumno.UniqueId=Guid.NewGuid().ToString();
            
            ViewBag.informacionAdicional="+ informacion de Asignatura";
            
            return View(alumno);
        }

        public IActionResult Listado()
        {
            List<Alumno> alumnos= GenerarAlumnosAlAzar();
                        
            ViewBag.informacionAdicional="+ informacion de todas los Alumnos";
            
            return View(alumnos);
        }

        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { 
                                   Nombre = $"{n1} {n2} {a1}" ,
                                   UniqueId = Guid.NewGuid().ToString()
                                   };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }
    }
}