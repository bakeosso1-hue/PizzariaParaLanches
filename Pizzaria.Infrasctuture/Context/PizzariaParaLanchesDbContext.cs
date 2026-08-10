using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Domain.Entities;
using Pizzaria.Infrasctuture.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Infrasctuture.Context
{
    public class PizzariaParaLanchesDbContext : IdentityDbContext
    {
        public PizzariaParaLanchesDbContext(DbContextOptions<PizzariaParaLanchesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Esfiha> Esfihas { get; set; }
        public DbSet<Fogazza> Fogazzas { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PizzaConfiguration());
            modelBuilder.ApplyConfiguration(new FogazzaConfiguration());
            modelBuilder.ApplyConfiguration(new EsfihaConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

        }
    }
}
