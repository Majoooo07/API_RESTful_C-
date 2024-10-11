using Microsoft.EntityFrameworkCore;
using Evaluacion.Models;
using System.Collections.Generic;


namespace Evaluacion.Data
{
    public class YourDbContext
    {
        public class YourDbContext : DbContext
        {
            public YourDbContext(DbContextOptions<YourDbContext> options)
                : base(options)
            {
            }

            public DbSet<Usuario> Users { get; set; }
            public DbSet<Departamentos> Departments { get; set; }
            public DbSet<Proyectos> Projects { get; set; }
        }
}
