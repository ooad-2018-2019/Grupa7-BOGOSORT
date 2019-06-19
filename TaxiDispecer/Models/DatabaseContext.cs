using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiDispecer.Models
{
    public class DatabaseContext : DbContext
    {
        public static DatabaseContext instance;

        public static DatabaseContext getInstance()
        {
            return instance;
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            instance = this;
        }

        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Osoba> Osoba { get; set; }
        public DbSet<Klijent> Klijent { get; set; }
        public DbSet<Vozac> Vozac { get; set; }
        public DbSet<Obavijest> Obavijest { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<Voznja> Voznja { get; set; }
        public DbSet<Logiranja> Logiranja { get; set; }
        public DbSet<OcjenaVozaca> OcjenaVozaca { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    
            modelBuilder.Entity<Administrator>().ToTable("Administrator");
            modelBuilder.Entity<Osoba>().ToTable("Osoba");
            modelBuilder.Entity<Klijent>().ToTable("Klijent");
            modelBuilder.Entity<Vozac>().ToTable("Vozac");
            modelBuilder.Entity<Obavijest>().ToTable("Obavijest");
            modelBuilder.Entity<Narudzba>().ToTable("Narudzba");
            modelBuilder.Entity<Voznja>().ToTable("Voznja");
            modelBuilder.Entity<Logiranja>().ToTable("Logiranja");
            modelBuilder.Entity<OcjenaVozaca>().ToTable("OcjenaVozaca");

        }
    }
}
