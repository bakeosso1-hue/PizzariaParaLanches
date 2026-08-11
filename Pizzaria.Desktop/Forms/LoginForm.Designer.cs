namespace Pizzaria.Desktop
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnSeparador = new Panel();
            lblBemVindo = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            imageList1 = new ImageList(components);
            pbLogo = new PictureBox();
            lblTextoFacaLogin = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            pnSeparador2 = new Panel();
            lblProblemas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblApi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblErro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            lblCarregando = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnSeparador
            // 
            pnSeparador.Location = new Point(42, 141);
            pnSeparador.Name = "pnSeparador";
            pnSeparador.Size = new Size(423, 2);
            pnSeparador.TabIndex = 0;
            // 
            // lblBemVindo
            // 
            lblBemVindo.AutoSize = true;
            lblBemVindo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBemVindo.Location = new Point(168, 37);
            lblBemVindo.Name = "lblBemVindo";
            lblBemVindo.Size = new Size(150, 32);
            lblBemVindo.TabIndex = 1;
            lblBemVindo.Text = "Bem-Vindo!";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(52, 29);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(101, 90);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 6;
            pbLogo.TabStop = false;
            // 
            // lblTextoFacaLogin
            // 
            lblTextoFacaLogin.AutoSize = true;
            lblTextoFacaLogin.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextoFacaLogin.ForeColor = SystemColors.ControlDark;
            lblTextoFacaLogin.Location = new Point(168, 69);
            lblTextoFacaLogin.Name = "lblTextoFacaLogin";
            lblTextoFacaLogin.Size = new Size(208, 13);
            lblTextoFacaLogin.TabIndex = 7;
            lblTextoFacaLogin.Text = "Faça Login com sua conta Pará Lanches";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(42, 163);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(42, 235);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(41, 15);
            lblSenha.TabIndex = 8;
            lblSenha.Text = "Senha";
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 10;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnEntrar
            // 
            btnEntrar.BorderRadius = 10;
            btnEntrar.CustomizableEdges = customizableEdges8;
            btnEntrar.DisabledState.BorderColor = Color.DarkGray;
            btnEntrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEntrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEntrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEntrar.FillColor = Color.FromArgb(0, 77, 147);
            btnEntrar.Font = new Font("Segoe UI", 9F);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(42, 317);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnEntrar.Size = new Size(423, 45);
            btnEntrar.TabIndex = 9;
            btnEntrar.Text = "Logar";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 10;
            txtEmail.CustomizableEdges = customizableEdges10;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(42, 181);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "seuemail@parálanches.com";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges11;
            txtEmail.Size = new Size(423, 36);
            txtEmail.TabIndex = 10;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 10;
            txtSenha.CustomizableEdges = customizableEdges12;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(42, 253);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "•••••••••••";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges13;
            txtSenha.Size = new Size(423, 36);
            txtSenha.TabIndex = 11;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // pnSeparador2
            // 
            pnSeparador2.Location = new Point(42, 389);
            pnSeparador2.Name = "pnSeparador2";
            pnSeparador2.Size = new Size(423, 2);
            pnSeparador2.TabIndex = 0;
            // 
            // lblProblemas
            // 
            lblProblemas.BackColor = Color.Transparent;
            lblProblemas.ForeColor = SystemColors.ControlDark;
            lblProblemas.Location = new Point(42, 392);
            lblProblemas.Name = "lblProblemas";
            lblProblemas.Size = new Size(326, 17);
            lblProblemas.TabIndex = 12;
            lblProblemas.Text = "Problemas para acessar? Contate o administrador do sistema.";
            // 
            // lblApi
            // 
            lblApi.BackColor = Color.Transparent;
            lblApi.ForeColor = SystemColors.ControlDark;
            lblApi.Location = new Point(42, 415);
            lblApi.Name = "lblApi";
            lblApi.Size = new Size(36, 17);
            lblApi.TabIndex = 12;
            lblApi.Text = "API: ...";
            // 
            // lblErro
            // 
            lblErro.BackColor = Color.Transparent;
            lblErro.ForeColor = Color.Maroon;
            lblErro.Location = new Point(42, 438);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(24, 17);
            lblErro.TabIndex = 12;
            lblErro.Text = "Erro";
            // 
            // btnFechar
            // 
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.Maroon;
            btnFechar.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(459, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(28, 28);
            btnFechar.TabIndex = 13;
            btnFechar.Text = "X";
            btnFechar.Click += btnFechar_Click;
            // 
            // lblCarregando
            // 
            lblCarregando.BackColor = Color.Transparent;
            lblCarregando.ForeColor = SystemColors.ControlDark;
            lblCarregando.Location = new Point(208, 369);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(84, 17);
            lblCarregando.TabIndex = 14;
            lblCarregando.Text = "Autenticando...";
            lblCarregando.TextAlignment = ContentAlignment.TopCenter;
            lblCarregando.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 503);
            Controls.Add(lblCarregando);
            Controls.Add(btnFechar);
            Controls.Add(lblErro);
            Controls.Add(lblApi);
            Controls.Add(lblProblemas);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(btnEntrar);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblTextoFacaLogin);
            Controls.Add(pbLogo);
            Controls.Add(lblBemVindo);
            Controls.Add(pnSeparador2);
            Controls.Add(pnSeparador);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnSeparador;
        private Label lblBemVindo;
        private ContextMenuStrip contextMenuStrip1;
        private ImageList imageList1;
        private PictureBox pbLogo;
        private Label lblTextoFacaLogin;
        private Label lblEmail;
        private Label lblSenha;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Panel pnSeparador2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProblemas;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblApi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblErro;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCarregando;
    }
}