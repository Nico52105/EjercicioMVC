using System;
using System.Collections.Generic;


namespace EjercicioMVC.Models
{
    public class Curso : ObjetoEscuelaBase
    {
        public string Dirección { get; set; }

        #region Relaciones
        public Escuela Escuela { get; set; }
        public string EscuelaId { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        #endregion




    }
}