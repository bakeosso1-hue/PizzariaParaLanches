using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;


        // ---------------------------------------------------------------------------
        public virtual ICollection<Pizza> Pizzas { get; set; } = new List<Pizza>();
    }
}
