using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Desktop.DTOs
{
    public class PizzaResponseDto
    {
        public int Id { get; set; }
        public string Name{ get; set; } = string.Empty;
        public string Descrição { get; set; } = string.Empty;
        public DateTime Data { get; set; } = DateTime.Now;
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoriaId { get; set; } 
        public string CategoriaName { get; set; } = string.Empty;
        public bool IsFeatured { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CreatePizzaDto
    {
        public string Name { get; set; } = string.Empty;
        public string Descrição { get; set; } = string.Empty;
        public DateTime Data { get; set; } = DateTime.Now;
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoriaId { get; set; }
        public bool IsFeatured { get; set; }
    }

    public class UpdatePizzaDto
    {
        public string Name { get; set; } = string.Empty;
        public string Descrição { get; set; } = string.Empty;
        public DateTime Data { get; set; } = DateTime.Now;
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoriaId { get; set; }
        public bool IsFeatured { get; set; }
    }
}
