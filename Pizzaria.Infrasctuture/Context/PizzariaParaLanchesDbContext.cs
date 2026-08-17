using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Domain.Entities;
using Pizzaria.Infrasctuture.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Infrasctuture.Context
{
    public class PizzariaParaLanchesDbContext : IdentityDbContext<IdentityUser>
    {
        public PizzariaParaLanchesDbContext(
            DbContextOptions<PizzariaParaLanchesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PizzaConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

        }
    }
}
