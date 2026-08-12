using Guna.UI2.WinForms;
using Pizzaria.Desktop.Helpers;
using Pizzaria.Desktop.Services;
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
        private UserControl _controleAtual;
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

            lblUsuario.Text = $"ParáLanches Desktop - {AppConfig.Version]}";

            private void ConfigurarPermissoes()
        {
            var isAdmin = SessionManager.Instance.IsAdmin;
            btnCategorias.Visible = isAdmin;
            btnUsuarios.Visible = isAdmin;
        }
        private void NavegarParaDashboard()
        {
            Navegar(new DashboardUserControl(), btnDashboard);
        }
    }
    }
}
