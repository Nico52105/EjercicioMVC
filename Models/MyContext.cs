using Microsoft.EntityFrameworkCore;

namespace EjercicioMVC.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public MyContext(DbContextOptions<MyContext> options)
        {
            
        }
    }
}