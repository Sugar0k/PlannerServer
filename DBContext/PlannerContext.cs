using System;
using System.Collections.Generic;
using System.Linq;
using Planner.Entity;
using Microsoft.EntityFrameworkCore;

namespace Planner.DBContext
{
    public class PlannerContext : DbContext
    {
        public DbSet<Task> Task { get; set; }

        public PlannerContext()
        {
            //Database.EnsureDeleted();   // удаляем бд со старой схемой
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=taskdb;Trusted_Connection=True;");
        }
    }
}