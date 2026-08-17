using System;
using System.Windows.Forms;
using Pizzaria.Desktop.Forms;
using Pizzaria.Desktop.Services;
using Pizzaria.Desktop.DTOs;
using System.Collections.Generic;

namespace Pizzaria.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // LoginForm espera uma lista de categorias no construtor; inicializa vazia por padrão.
            var categorias = new List<CategoriaResponseDto>();
            Application.Run(new LoginForm(categorias));
        }
    }
}