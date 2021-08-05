using System;
using System.Collections.Generic;

namespace EjercicioMVC.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        #region Relaciones
        public Curso Curso { get; set; }
        public string CursoId { get; set; }
        public List<Evaluación> Evaluaciones { get; set; }
        #endregion

    }
}