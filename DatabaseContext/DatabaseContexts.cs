using AppAmalt.Dto;
using AppAmalt.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace DatabaseContext
{
    public class DatabaseContexts : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<ValueCity> ValueCitis { get; set; }
        public DbSet<Party> Fractions { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<LifeMain> LifeMains { get; set; }
        public DbSet<Political> Politicals { get; set; }
        public DbSet<Age> Age { get; set; }
        public DbSet<Portrait> Portraits { get; set; }
        public DbSet<Relation> Relations { get; set; }
        public DbSet<Education> Educations { get; set; }

        public DatabaseContexts()
        { }
        public DatabaseContexts(DbContextOptions<DatabaseContexts> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString: "User ID=postgres; Password=123; Server=localhost; Port=5432; Database=App"); 
        }

    }
}
