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
    public partial class DashboardUserControl : UserControl
    {
        private PizzaApiService _pizzaService = null;
        private CategoriasApiService _categoriasService = null;
        public DashboardUserControl()
        {
            InitializeComponent();
        }

        private async void DashboardUserControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            //Inicializa serviços
            _pizzaService = new PizzaApiService();
            _categoriasService = new CategoriasApiService();

            //Preenche dados dinâmicos da sessão
            lblTitulo.Text = $"Olá, {SessionManager.Instance.GetDisplayName()!} 👋";
            lblSubtitulo.Text = $"Bem-vindo a Pará Lanches Pizzaria - {DateTime.Now:dddd, dd 'de' MMM 'de' yyyy}";
        }

            //======================================================

            private void SetCarregando(bool carregando)
        {
            lblCarregando.Visible = carregando;
            cardPizzas.Visible = !carregando;
            cardCategorias.Visible = !carregando;
            lblUltimasPizzas.Visible = !carregando;
            gridUltimasPizzas.Visible = !carregando;
        }
        private async Task CarregarDadosAsync()
        {
            SetCarregando(true);

            try
            {
                var tarefaPizzas = _pizzaService.GetAllAsync();
                var tarefaCategorias = _categoriasService.GetAllAsync();
                await Task.WhenAll(tarefaPizzas, tarefaCategorias);

                var games = tarefaPizzas.Result;
                var categorias = tarefaCategorias.Result;

                //Atualiza os dados do card
                //AtualizarNumeroCard(cardGames, games.Count.ToString());
                //AtualizarNumeroCard(cardCategorias, categorias.Count.ToString());

                cardGamesLblNumero.Text = games.Count.ToString();
                cardCategoriasLblNumero.Text = categorias.Count.ToString();

                //Popula o DataGridView(tabela) com os últimos 10 games.
                gridUltimasPizzas.Rows.Clear();
                foreach (var game in games.OrderByDescending(x => x.CreatedAt).Take(10))
                {
                    gridUltimasPizzas.Rows.Add(
                        game.Id,
                        game.Name,
                        game.CategoriaName,
                        game.Data,
                        game.IsFeatured,
                        game.CreatedAt.ToString("dd/MM/yyyy HH:mm")
                        );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                $"Erro ao carregar dados: {ex.Message}",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            finally
            {
                SetCarregando(false);
            }

        }
        private void AtualizarNumeroCard(Guna.UI2.WinForms.Guna2Panel card, string numero)
        {
            //'card.Controls' retorna a coleção de controles(elementos) filhos do panel
            //'OfType<Label>()' filtra apenas os controles do tipo 'Label'
            //'FirstOrDefault(...) pegao primeiro Label que satisfaz a condição ou null se nenhum. 
            //A condição 'l.Tag?.ToString() == "numero"' verifica o tag do Label (pode ser null) e compara com a string 
            var lblNumero = card.Controls.OfType<Label>().FirstOrDefault(l => l.Tag?.ToString() == "numero");

            if (lblNumero != null)
            {
                lblNumero.Text = numero;
            }
        }

    }
   }
 

