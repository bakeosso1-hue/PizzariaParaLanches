using Pizzaria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Domain.Interfaces
{
    public interface IFogazzaRepository
    {
        Task<IEnumerable<Pizza>> GetAllPizzasAsync();

        Task<Pizza?> GetPizzaByIdAsync(int id);

        Task<IEnumerable<Pizza>> GetFeaturedPizzasAsync();

        Task AddAsync(Pizza pizza);

        Task UpdateAsync(Pizza pizza);

        Task DeleteAsync(int id);

        Task<int> CountAsync();

    }
}

