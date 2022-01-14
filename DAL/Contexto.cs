using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_System_Win.Entidades;

namespace Tasks_System_Win.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Tareas> Tareas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA/Tasks.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tareas>().HasData(new Tareas
            {
                TareaId = 1,
                Nombre = "Análisis",
                Descripcion = "La persona X debe de analizar el area que su superior le asigno."
            });
        }
    }
}
