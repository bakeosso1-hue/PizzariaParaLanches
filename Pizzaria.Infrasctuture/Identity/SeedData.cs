
//=========================================
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pizzaria.Domain.Entities;
using Pizzaria.Infrasctuture.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Infrasctuture.Identity
{
    public static class SeedData
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var content = scope.ServiceProvider.GetRequiredService<PizzariaParaLanchesDbContext>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            await content.Database.MigrateAsync();

            if (!content.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Name = "Queijo" },
                    new Category { Name = "Calabresa" },
                    new Category { Name = "Quatro Queijos" },
                    new Category { Name = "Portuguesa" },
                    new Category { Name = "Frango com Catupiry" },
                    new Category { Name = "Carne" },
                    new Category { Name = "Frango" },
                    new Category { Name = "Escarola" }
                };
                await content.Categories.AddRangeAsync(categories);
                await content.SaveChangesAsync();
            }

            // Seed pizzas only when there are no pizzas yet
            if (!content.Pizzas.Any())
            {
                var queijo = await content.Categories.FirstAsync(c => c.Name == "Queijo");
                var calabresa = await content.Categories.FirstAsync(c => c.Name == "Calabresa");
                var quatroQueijos = await content.Categories.FirstAsync(c => c.Name == "Quatro Queijos");
                var portuguesa = await content.Categories.FirstAsync(c => c.Name == "Portuguesa");
                var frangoCatu = await content.Categories.FirstAsync(c => c.Name == "Frango com Catupiry");

                // Only add pizzas if required categories are present

                var pizzas = new List<Pizza>
                    {
                    new Pizza {
                            Name = "Pizza de Queijo",
                            Description = "Deliciosa pizza de queijo com molho especial",
                            CoverImageUrl = "https://cdn0.tudoreceitas.com/pt/posts/2/8/4/pizza_4_queijos_caseira_2482_orig.jpg",
                            CategoryId = queijo.Id,
                            IsFeatured = true },

                    new Pizza {
                        Name = "Pizza de Calabresa",
                        Description = "Saborosa pizza de calabresa com cebola e azeitonas",
                        CoverImageUrl = "https://swiftbr.vteximg.com.br/arquivos/618283-PIZZA-ARTESANAL-DE-CALABRESA-SWIFT_3.jpg",
                        CategoryId = calabresa.Id,
                        IsFeatured = true },
                    new Pizza {
                        Name = "Pizza Quatro Queijos",
                        Description = "Pizza com quatro tipos de queijo: mussarela, provolone, gorgonzola e parmesão",
                        CoverImageUrl = "https://s2-receitas.glbimg.com/IioKJjsRT8nIuv2q8nzcypphLPk=/0x0:1200x675/984x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_1f540e0b94d8437dbbc39d567a1dee68/internal_photos/bs/2024/V/2/rafz5yTJuSiHGDoolkpg/pizza-de-4-queijos.jpg",
                        CategoryId = quatroQueijos.Id,
                        IsFeatured = true },
                    new Pizza {
                        Name = "Pizza Portuguesa",
                        Description = "Pizza com presunto, ovos, cebola, azeitonas e queijo",
                        CoverImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR9TE6EZTJFu8JLr0Gte7Qwx_9BbWt7Ibvrun6-BvkvxZdf3l1I7N_8TRbj&s=10",
                        CategoryId = portuguesa.Id,
                        IsFeatured = true },
                    new Pizza {
                        Name = "Pizza de Frango com Catupiry",
                        Description = "Pizza com frango desfiado e catupiry cremoso",
                        CoverImageUrl = "https://www.receiteria.com.br/wp-content/uploads/receitas-de-pizza-de-frango-com-catupiry.jpg",
                        CategoryId = frangoCatu.Id,
                        IsFeatured = true },
                    };

                await content.Pizzas.AddRangeAsync(pizzas);
                await content.SaveChangesAsync();
            }

            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            var adminEmail = "admin@paralanches.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(adminUser, "Admin@123");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}

