namespace Pizzaria.Desktop.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            pnlVer2 = new Panel();
            btnPizzas = new Guna.UI2.WinForms.Guna2Button();
            btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            pnlVer1 = new Panel();
            lblversao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblLogofds = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel3 = new Panel();
            lblPerfil = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel4 = new Panel();
            lblVTNCPARALANCHES = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pnlConteudo = new Panel();
            pnlVer2.SuspendLayout();
            pnlVer1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlVer2
            // 
            pnlVer2.BackColor = Color.Maroon;
            pnlVer2.Controls.Add(btnPizzas);
            pnlVer2.Controls.Add(btnDashboard);
            pnlVer2.ForeColor = Color.FromArgb(192, 0, 0);
            pnlVer2.Location = new Point(1, 191);
            pnlVer2.Name = "pnlVer2";
            pnlVer2.Size = new Size(206, 366);
            pnlVer2.TabIndex = 1;
            // 
            // btnPizzas
            // 
            btnPizzas.CustomizableEdges = customizableEdges5;
            btnPizzas.DisabledState.BorderColor = Color.DarkGray;
            btnPizzas.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPizzas.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPizzas.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPizzas.FillColor = Color.Gold;
            btnPizzas.Font = new Font("Segoe UI", 9F);
            btnPizzas.ForeColor = Color.Black;
            btnPizzas.Location = new Point(11, 59);
            btnPizzas.Name = "btnPizzas";
            btnPizzas.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPizzas.Size = new Size(180, 45);
            btnPizzas.TabIndex = 2;
            btnPizzas.Text = "Pizza";
            btnPizzas.Click += btnPizzas_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(192, 192, 0);
            btnDashboard.CustomizableEdges = customizableEdges7;
            btnDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDashboard.FillColor = Color.Gold;
            btnDashboard.Font = new Font("Segoe UI", 9F);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Location = new Point(11, 8);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnDashboard.Size = new Size(180, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "DashBoard";
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlVer1
            // 
            pnlVer1.BackColor = Color.Maroon;
            pnlVer1.Controls.Add(lblversao);
            pnlVer1.Controls.Add(lblLogofds);
            pnlVer1.Location = new Point(1, 108);
            pnlVer1.Name = "pnlVer1";
            pnlVer1.Size = new Size(206, 85);
            pnlVer1.TabIndex = 2;
            // 
            // lblversao
            // 
            lblversao.BackColor = Color.Transparent;
            lblversao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblversao.ForeColor = SystemColors.ControlLightLight;
            lblversao.Location = new Point(11, 39);
            lblversao.Name = "lblversao";
            lblversao.Size = new Size(87, 17);
            lblversao.TabIndex = 0;
            lblversao.Text = "Versão DeskTop";
            // 
            // lblLogofds
            // 
            lblLogofds.BackColor = Color.Transparent;
            lblLogofds.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogofds.ForeColor = SystemColors.ControlLightLight;
            lblLogofds.Location = new Point(11, 10);
            lblLogofds.Name = "lblLogofds";
            lblLogofds.Size = new Size(166, 23);
            lblLogofds.TabIndex = 0;
            lblLogofds.Text = "Pará Lanches Pizzaria";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Crimson;
            panel3.Controls.Add(lblPerfil);
            panel3.Controls.Add(lblUsuario);
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 111);
            panel3.TabIndex = 2;
            // 
            // lblPerfil
            // 
            lblPerfil.BackColor = Color.Transparent;
            lblPerfil.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPerfil.ForeColor = SystemColors.ControlLightLight;
            lblPerfil.Location = new Point(20, 49);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(30, 17);
            lblPerfil.TabIndex = 1;
            lblPerfil.Text = "Perfil";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.ControlLightLight;
            lblUsuario.Location = new Point(20, 11);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(78, 32);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Crimson;
            panel4.Controls.Add(lblVTNCPARALANCHES);
            panel4.Location = new Point(204, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(511, 111);
            panel4.TabIndex = 2;
            // 
            // lblVTNCPARALANCHES
            // 
            lblVTNCPARALANCHES.BackColor = Color.Transparent;
            lblVTNCPARALANCHES.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVTNCPARALANCHES.ForeColor = SystemColors.ControlLightLight;
            lblVTNCPARALANCHES.Location = new Point(11, 11);
            lblVTNCPARALANCHES.Name = "lblVTNCPARALANCHES";
            lblVTNCPARALANCHES.Size = new Size(211, 32);
            lblVTNCPARALANCHES.TabIndex = 0;
            lblVTNCPARALANCHES.Text = "Pará Lanches Pizzaria";
            // 
            // pnlConteudo
            // 
            pnlConteudo.Location = new Point(215, 118);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(500, 439);
            pnlConteudo.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 557);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlVer2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pnlVer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            pnlVer2.ResumeLayout(false);
            pnlVer1.ResumeLayout(false);
            pnlVer1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel pnlVer2;
        private Guna.UI2.WinForms.Guna2Button btnPizzas;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Panel pnlVer1;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLogofds;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblversao;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVTNCPARALANCHES;
        private Panel pnlConteudo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPerfil;
    }
}