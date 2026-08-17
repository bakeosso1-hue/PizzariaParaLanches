using Pizzaria.Desktop.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria.Desktop.Forms
{
    public partial class PizzaFormDialog2 : Form
    {
        public CreatePizzaDto? PizzaDto { get; private set; }
        public UpdatePizzaDto? UpdateDto { get; private set; }

        private List<CategoriaResponseDto> _categorias;
        private PizzaResponseDto? pizzaexistente;

        public PizzaFormDialog2(List<CategoriaResponseDto> categorias, PizzaResponseDto? pizza)
        {
            _categorias = categorias;
            pizzaexistente = pizza;
        }
    }
}
