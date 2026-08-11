using Pizzaria.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Application.Interfaces
{
    public interface IPizzaService
    {
        Task<IEnumerable<PizzaDto>> GetAllAsync();
        Task<PizzaDto?> GetByIdAsync(int id);
        Task<IEnumerable<PizzaDto>> GetFeaturedAsync();
        Task<IEnumerable<PizzaDto>> GetByCategoryAsync(int categoryId);
        Task<PizzaDto> CreateAsync(CreatePizzaDto dto);
        Task<PizzaDto> UpdateAsync(int id, UpdatePizzaDto dto);
        Task<bool> DeleteAsync(int id);
        Task<int> CountAsync();
    }
}
