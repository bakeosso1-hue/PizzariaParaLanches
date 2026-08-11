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

namespace Pizzaria.Desktop
{
    public partial class LoginForm : Form
    {
        private AuthApiService _authService = null;

        public CreatePizzaDto? PizzaDto { get; private set; }

        public UpdatePizzaDto? UpdateDto { get; private set; }

        private List<CategoriaResponseDto> _categorias = new();
        private PizzaResponseDto? _PizzaExistente;


        public LoginForm(List<DTOs.CategoriaResponseDto> categorias)
        {
            _authService = new AuthApiService();
            InitializeComponent();
        }

        // Added overload to match usages that pass categories and an optional existing pizza
        public LoginForm(List<DTOs.CategoriaResponseDto> categorias, PizzaResponseDto? pizza)
        {
            _authService = new AuthApiService();
            _categorias = categorias ?? new List<CategoriaResponseDto>();
            _PizzaExistente = pizza;
            InitializeComponent();
        }

        private void ExibirErro(string mensagem)
        {
            if (string.IsNullOrEmpty(mensagem))
            {
                lblErro.Visible = false;
                lblErro.Text = string.Empty;
            }
            else
            {
                lblErro.Text = mensagem;
                lblErro.Visible = true;
            }
        }

        private void SetCarregando(bool carregando)
        {
            btnEntrar.Enabled = !carregando;
            txtEmail.Enabled = !carregando;
            txtSenha.Enabled = !carregando;
            lblCarregando.Visible = carregando;

            if (carregando)
            {
                btnEntrar.Text = "Aguarde...";
                lblErro.Visible = false;
            }
            else
            {
                btnEntrar.Text = "Entrar";
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            _authService = new AuthApiService();

            lblApi.Text = $"API: {AppConfig.ApiBaseUrl}";

            txtEmail.Text = "admin@ParáLanches.com";
            txtSenha.Text = "admin@123";
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnEntrar_Click(sender, e);
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            ExibirErro(string.Empty);

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirErro("Informe o seu e-mail: ");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                ExibirErro(" Informe a sua senha: ");
                txtSenha.Focus();
                return;
            }

            SetCarregando(true);

            try
            {
                var (success, user, errorMessage) = await _authService.LoginAsync(
                    txtEmail.Text.Trim(),
                    txtSenha.Text);

                if (success && user != null)
                {
                    SessionManager.Instance.SetUser(user);
  
                    this.Hide();

                    using var mainform = new MainForm();
                    mainform.ShowDialog();

                    this.Close();
                }
                else
                {
                    ExibirErro($"❌ {errorMessage}");
                    MessageBox.Show($"❌ {errorMessage}");
                }
            }
            catch (HttpRequestException exHttp)
            {
                ExibirErro($"❌ Não foi possível conectar à API. \nVerifique se a API está em execução erro do sistema: {exHttp.Message}");
                MessageBox.Show($"❌ Não foi possível conectar à API. \nVerifique se a API está em execução erro do sistema: {exHttp.Message}");
            }
            catch (Exception ex)
            {
                ExibirErro($"❌ Erro inesperado: {ex.Message}");
                MessageBox.Show($"❌ Erro inesperado: {ex.Message}");
            }
            finally
            {
                SetCarregando(false);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnEntrar_Click(sender, e);
        }
    }
}
