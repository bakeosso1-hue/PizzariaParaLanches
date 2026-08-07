using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Domain.Entities
{
    public class Fogazza
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string CoverImageUrl { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public bool IsFeatured { get; set; }

        // X

        //---------------------------------------------------
        public virtual Category? Category { get; set; }
    }
}
