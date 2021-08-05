using System;

namespace EjercicioMVC.Models
{
    public class Evaluación:ObjetoEscuelaBase
    {
        public float Nota { get; set; }

        #region Relaciones
        public Alumno Alumno { get; set; }
        public string AlumnoId { get; set; }
        public Asignatura AsignaturaId  { get; set; }
        public string Asignatura  { get; set; }
        
        #endregion

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}