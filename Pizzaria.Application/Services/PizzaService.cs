using Pizzaria.Application.DTOs;
using Pizzaria.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Application.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly IPizzaService _pizzaRepository;

        public PizzaService(IPizzaService pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public async Task<IEnumerable<PizzaDto>> GetAllAsync()
        {
            var pizzas = await _pizzaRepository.GetAllAsync();
            return await _pizzaRepository.Select(MapToDto);
        }

        public async Task<PizzaDto?> GetByIdAsync(int id)
        {
            var pizza = await _pizzaRepository.GetByIdAsync(id);
            return pizza == null ? null : MapToDto(pizza);
        }

        public async Task<IEnumerable<PizzaDto>> GetFeaturedAsync()
        {
            var pizzas = await _pizzaRepository.GetFeaturedAsync();
            return pizzas.Select(MapToDto);
        }

        public async Task<IEnumerable<PizzaDto>> GetByCategoryAsync(int categoryId)
        {
            var pizzas = await _pizzaRepository.GetByCategoryAsync(categoryId);
            return pizzas.Select(MapToDto);
        }


        public async Task<PizzaDto> CreateAsync(CreatePizzaDto dto)
        {
            var pizza = new Pizza
            {
                Name = dto.Name,
                Description = dto.Description,
                CoverImageUrl = dto.CoverImageUrl,
                CategoryId = dto.CategoryId,
                IsFeatured = dto.IsFeatured
            };

            await _pizzaRepository.AddAsync(pizza);
            return MapToDto(pizza);
        }
        public async Task<PizzaDto> UpdateAsync(UpdatePizzaDto dto)
        {
            var pizza = await _pizzaRepository.GetByIdAsync(dto.Id);
            if (pizza == null) return null;

            pizza.Name = dto.Name;
            pizza.Description = dto.Description;
            pizza.CoverImageUrl = dto.CoverImageUrl;
            pizza.CategoryId = dto.CategoryId;
            pizza.IsFeatured = dto.IsFeatured;

            await _pizzaRepository.UpdateAsync(pizza);
            return MapToDto(pizza);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var pizza = await _pizzaRepository.GetByIdAsync(id);
            if (pizza == null) return false;
            await _pizzaRepository.DeleteAsync(id);
            return true;
        }

        public async Task<int> CountAsync()
        {
            return await _pizzaRepository.CountAsync();
        }

        private static PizzaDto MapToDto(Pizza pizza)
        {
            return new PizzaDto
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Description = pizza.Description,
                CoverImageUrl = pizza.CoverImageUrl,
                CategoryId = pizza.CategoryId,
                CategoryName = pizza.Category?.Name ?? string.Empty,
                IsFeatured = pizza.IsFeatured,
            };
        }
    }
}
