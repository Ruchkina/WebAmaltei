using AppAmalt.Dto;
using Microsoft.EntityFrameworkCore;
using System;

namespace DatabaseContext
{
    public class DatabaseContext : DbContext
    {
        //public DbSet<GraphCityDto> Cities { get; set; }
        public DbSet<GraphGenderDto> Gender { get; set; }
        public DbSet<GraphLifeMainDto> LifeMain { get; set; }
        public DbSet<GraphPoliticalDto> Political { get; set; }
        public DbSet<GraphsAgeDto> Age { get; set; }
        public DbSet<PortraitDto> Portrait { get; set; }

        public DatabaseContext()
        { }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString: "User ID=postgres; Password=123; Server=localhost; Port=5432; Database=App"); 
        }

    }
}
