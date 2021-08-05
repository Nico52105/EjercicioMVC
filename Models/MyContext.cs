using System;
using System.Collections.Generic;
using System.Linq;
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

        public MyContext(DbContextOptions<MyContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela();
            escuela.Nombre="Escuela Nicolas";
            escuela.AñoDeCreación=2021;
            escuela.Id=Guid.NewGuid().ToString();
            escuela.TipoEscuela=TiposEscuela.Secundaria;
            escuela.Dirección="Calle 1 # 10 - 20";
            escuela.Pais="Colombia";
            escuela.Ciudad="Bogota";

            modelBuilder.Entity<Escuela>().HasData(escuela);

            List<Asignatura> asignaturas= new List<Asignatura>();
            for (int i = 0; i < 5; i++)
            {
                var asignatura = new Asignatura();
                asignatura.Nombre="Asignatura "+i;
                asignatura.Id=Guid.NewGuid().ToString();
                asignaturas.Add(asignatura);
            }

            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());

            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { 
                                   Nombre = $"{n1} {n2} {a1}" ,
                                   Id = Guid.NewGuid().ToString()
                                   };
            
            modelBuilder.Entity<Alumno>().HasData(listaAlumnos.ToArray());
        }
    }
}