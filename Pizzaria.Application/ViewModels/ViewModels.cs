using Pizzaria.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Application.ViewModels
{
    public class HomeViewModels
    {
        public IEnumerable<PizzaDto> FeaturedPizzas { get; set; } = new List<PizzaDto>();
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        public IEnumerable<PizzaDto> Pizzas { get; set; } = new List<PizzaDto>();
    }

    public class PizzaDetailsViewModel
    {
        public PizzaDto Pizza { get; set; } = new PizzaDto();
        public IEnumerable<CategoryDto> RelatedPizzas { get; set; } = new List<CategoryDto>();
    }

    public class DashboardViewModel
    {
        public int TotalPizzas { get; set; }
        public int TotalCategories { get; set; }
        public int FeaturedPizzas { get; set; }
        public IEnumerable<PizzaDto> RecentPizzas { get; set; } = new List<PizzaDto>();
    }

    public class PizzaFormViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public bool IsFeatured { get; set; }
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
    }
    
    public class PizzaListViewModel
    {
        public IEnumerable<PizzaDto> Pizzas { get; set; } = new List<PizzaDto>();
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        public int? SelectedCategoryId { get; set; }
    }

}
