using Microsoft.EntityFrameworkCore;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces;
using Pizzaria.Infrasctuture.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Infrasctuture.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly PizzariaParaLanchesDbContext _context;

        public PizzaRepository(PizzariaParaLanchesDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Pizza>> GetAllAsync()
        {
            return await _context.Pizzas
                .Include(g => g.Category)  // Faz JOIN com a tabela Categories
                .OrderByDescending(g => g.CreatedAt)
                .ToListAsync();
        }
        public async Task<Pizza?> GetByIdAsync(int id)
        {
            return await _context.Pizzas
                .Include(g => g.Category)
                .FirstOrDefaultAsync(g => g.Id == id);
        }
        public async Task<IEnumerable<Pizza>> GetFeaturedAsync()
        {
            return await _context.Pizzas
                .Include(g => g.Category)
                .Where(g => g.IsFeatured)  // WHERE IsFeatured = true
                .ToListAsync();
        }
        public async Task<IEnumerable<Pizza>> GetByCategoryAsync(int categoryId)
        {
            return await _context.Pizzas
                .Include(g => g.Category)
                .Where(g => g.CategoryId == categoryId)
                .ToListAsync();
        }
        public async Task AddAsync(Pizza pizza)
        {
            await _context.Pizzas.AddAsync(pizza);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Pizza pizza)
        {
            _context.Pizzas.Update(pizza);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var pizza = await _context.Pizzas.FindAsync(id);
            if (pizza != null)
            {
                _context.Pizzas.Remove(pizza);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<int> CountAsync()
        {
            return await _context.Pizzas.CountAsync();
        }

    }
}