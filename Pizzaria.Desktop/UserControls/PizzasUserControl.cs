using Pizzaria.Desktop.DTOs;
using Pizzaria.Desktop.Forms;
using Pizzaria.Desktop.Helpers;
using Pizzaria.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria.Desktop.UserControls
{
    public partial class PizzasUserControl : UserControl
    {
        private PizzaApiService _PizzaService = null;
        private CategoriasApiService _categoriasService = null;

        private List<PizzaResponseDto> _todasPizzas = new();
        private List<CategoriaResponseDto> _categorias = new();


        public PizzasUserControl()
        {
            InitializeComponent();
        }

        private async void PizzasUserControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            _PizzaService = new PizzaApiService();
            _categoriasService = new CategoriasApiService();

            ConfigurarPermissoes();

            await CarregarDadosAsync();
        }
        private void ConfigurarPermissoes()
        {
            bool isAdmin = SessionManager.Instance.IsAdmin;
            btnNova.Visible = isAdmin;
            btnEditar.Visible = isAdmin;
            btnExcluir.Visible = isAdmin;
        }

        private async Task CarregarDadosAsync()
        {
            gridPizzas.Rows.Clear();

            try
            {
                var tarefaPizza = _PizzaService.GetAllAsync();
                var tarefaCategorias = _categoriasService.GetAllAsync();
                await Task.WhenAll(tarefaPizza, tarefaCategorias);

                _todasPizzas = tarefaPizza.Result;
                _categorias = tarefaCategorias.Result;

                PopularGrid(_todasPizzas);

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao carregar pizza: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void PopularGrid(List<PizzaResponseDto> Pizzas)
        {
            gridPizzas.Rows.Clear();
            foreach (var p in Pizzas)
                gridPizzas.Rows.Add(
                    p.Id,
                    p.Name,
                    p.CategoriaName,
                    p.IsFeatured,
                    p.CreatedAt.ToString("dd/MM/yyyy HH:mm"));
        }



        private void FiltrarPizzas()
        {
            var termo = txtPesquisa.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(termo))
            {
                PopularGrid(_todasPizzas);
                return;
            }

            var filtrados = _todasPizzas
                .Where(g => g.Name.Contains(termo, StringComparison.OrdinalIgnoreCase)
                || g.CategoriaName.Contains(termo, StringComparison.OrdinalIgnoreCase))
                .ToList();

            PopularGrid(filtrados);
        }




        private PizzaResponseDto? ObterPizzaSelecionado()
        {

            if (gridPizzas.SelectedRows.Count == 0) return null;
            var row = gridPizzas.SelectedRows[0];
            var id = Convert.ToInt32(row.Cells["colid"].Value);
            return _todasPizzas.FirstOrDefault(g => g.Id == id);
        }



        private async void btnNova_Click_1(object sender, EventArgs e)
        {
            using var form = new Form1(_categorias, null);

            if (form.ShowDialog() == DialogResult.OK && form.PizzaDto != null)
            {
                MessageBox.Show(
                    $"Nome: {form.PizzaDto.Name}\n" +
                    $"Descrição: {form.PizzaDto.Descrição}\n" +
                    $"CategoriaId: {form.PizzaDto.CategoryId}\n" +
                    $"Imagem: {form.PizzaDto.CoverImageUrl}\n" +
                    $"Destaque: {form.PizzaDto.IsFeatured}");

                var (success, _, error) = await _PizzaService.CreateAsync(form.PizzaDto);

                MessageBox.Show($"Success: {success}\nErro: {error}");
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            var game = ObterPizzaSelecionado();
            if (game == null)
            {
                MessageBox.Show("Selecione uma pizza para excluir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conf = MessageBox.Show(
                $"Excluir a categoria \"{game.Name}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (conf != DialogResult.Yes) return;

            var (success, error) = await _PizzaService.DeleteAsync(game.Id);
            if (success)
            {
                MessageBox.Show("pizza excluída!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CarregarDadosAsync();
            }
            else
            {
                MessageBox.Show($"❌ {error}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnAtualizar_Click(object sender, EventArgs e) => await CarregarDadosAsync();

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e) => FiltrarPizzas();

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var pizzas = ObterPizzaSelecionado();
            if (pizzas == null)
            {
                MessageBox.Show($"Selecione uma pizza para editar.",
                     "Aviso",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                return;
            }

            using var form = new Form1(_categorias, pizzas);
            if (form.ShowDialog() == DialogResult.OK && form.Update != null)
            {
                var (success, _, error) = await _PizzaService.UpdateAsync(pizzas.Id, form.UpdateDto);
                if (success)
                {
                    MessageBox.Show("✅ Pizza Atualizada com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
            }
        }
    }
}