using Pizzaria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Domain.Interfaces
{
    public interface IPizzaRepository
    {
       Task<IEnumerable<Pizza>> GetAllAsync();

        Task<Pizza?> GetByIdAsync(int id);

        Task<IEnumerable<Pizza>> GetFeaturedAsync();

        Task AddAsync(Pizza pizza);

        Task UpdateAsync(Pizza pizza);

        Task DeleteAsync(int id);

        Task<int> CountAsync();
        Task<IEnumerable<Pizza>> GetByCategoryAsync(int categoryId);
    }
}
