using Guna.UI2.WinForms;
using Pizzaria.Desktop.Helpers;
using Pizzaria.Desktop.Services;
using Pizzaria.Desktop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pizzaria.Desktop.Forms
{
    public partial class MainForm : Form
    {
        private UserControl? _controleAtual;
        private Guna2Button? _botaoAtivo;
        private AuthApiService _authService = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            _authService = new AuthApiService();
            this.Text = $"Pizzaria - {AppConfig.Version}";
            lblUsuario.Text = $"{SessionManager.Instance.GetDisplayName()}";

            ConfigurarPermissoes();
            NavegarParaGrid();
        }

        private void ConfigurarPermissoes()
        {
            var isAdmin = SessionManager.Instance.IsAdmin;
        }
        private void Navegar(UserControl control, Guna2Button? botao = null)
        {
            if (_controleAtual != null)
            {
                pnlConteudo.Controls.Remove(_controleAtual);
                _controleAtual.Dispose();
                _controleAtual = null;
            }
        }
        private void NavegarParaGrid()
        {
            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(new PizzasUserControl());
        }


    }
}

