using Hotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext {
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Quartos>Quartos { get; set; }
        public DbSet<Cliente>Clientes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Quartos>().HasData(
                new Quartos
                {
                    Id = 1,
                    Description = " Vista para o mar",
                    Type = "Suite",
                    Floor = 10
                },

                new Quartos
                {
                    Id = 2,
                    Description = " Vista para o parque",
                    Type = "Familia",
                    Floor = 5
                },

                new Quartos
                {
                    Id = 3,
                    Description = " Vista para as montanhas",
                    Type = "Solteiro",
                    Floor = 2
                }

                );
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
    
                    Id = 1,
                   Name = "jose",
                   QuartosId = 1
                },

                new Cliente
                {
                    Id = 2,
                    Name = "tainara",
                    QuartosId = 2
                },

                new Cliente
                {
                    Id = 3,
                    Name = "andre",
                    QuartosId = 3
                }
                
                );
        }
    }  
}
