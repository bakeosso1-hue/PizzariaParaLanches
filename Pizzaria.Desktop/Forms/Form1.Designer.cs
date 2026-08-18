namespace Pizzaria.Desktop.Forms
{
    partial class Form1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            lblTituloForm = new Label();
            lblCampTitulo = new Label();
            lblCampDesc = new Label();
            lblCampCover = new Label();
            lblCampCategoria = new Label();
            txtTítulo = new Guna.UI2.WinForms.Guna2TextBox();
            cmbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            chkDestaque = new Guna.UI2.WinForms.Guna2CheckBox();
            txtCoverUrl = new Guna.UI2.WinForms.Guna2TextBox();
            txtDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BorderRadius = 7;
            btnSalvar.CustomizableEdges = customizableEdges1;
            btnSalvar.DisabledState.BorderColor = Color.DarkGray;
            btnSalvar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalvar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalvar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalvar.FillColor = Color.FromArgb(78, 247, 115);
            btnSalvar.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(33, 444);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSalvar.Size = new Size(111, 45);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BorderRadius = 7;
            btnCancelar.CustomizableEdges = customizableEdges3;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.FillColor = Color.Silver;
            btnCancelar.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(150, 444);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancelar.Size = new Size(111, 45);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTituloForm
            // 
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloForm.ForeColor = Color.FromArgb(86, 100, 219);
            lblTituloForm.Location = new Point(33, 34);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(93, 21);
            lblTituloForm.TabIndex = 1;
            lblTituloForm.Text = "Criar Pizza";
            // 
            // lblCampTitulo
            // 
            lblCampTitulo.AutoSize = true;
            lblCampTitulo.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCampTitulo.Location = new Point(33, 74);
            lblCampTitulo.Name = "lblCampTitulo";
            lblCampTitulo.Size = new Size(106, 17);
            lblCampTitulo.TabIndex = 1;
            lblCampTitulo.Text = "Nome da pizza:";
            // 
            // lblCampDesc
            // 
            lblCampDesc.AutoSize = true;
            lblCampDesc.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCampDesc.Location = new Point(33, 130);
            lblCampDesc.Name = "lblCampDesc";
            lblCampDesc.Size = new Size(72, 17);
            lblCampDesc.TabIndex = 1;
            lblCampDesc.Text = "Descrição";
            // 
            // lblCampCover
            // 
            lblCampCover.AutoSize = true;
            lblCampCover.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCampCover.Location = new Point(33, 232);
            lblCampCover.Name = "lblCampCover";
            lblCampCover.Size = new Size(147, 17);
            lblCampCover.TabIndex = 1;
            lblCampCover.Text = "URL imagem da pizza";
            // 
            // lblCampCategoria
            // 
            lblCampCategoria.AutoSize = true;
            lblCampCategoria.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCampCategoria.Location = new Point(33, 291);
            lblCampCategoria.Name = "lblCampCategoria";
            lblCampCategoria.Size = new Size(71, 17);
            lblCampCategoria.TabIndex = 1;
            lblCampCategoria.Text = "Categoria";
            // 
            // txtTítulo
            // 
            txtTítulo.CustomizableEdges = customizableEdges5;
            txtTítulo.DefaultText = "";
            txtTítulo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTítulo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTítulo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTítulo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTítulo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTítulo.Font = new Font("Segoe UI", 9F);
            txtTítulo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTítulo.Location = new Point(12, 94);
            txtTítulo.Name = "txtTítulo";
            txtTítulo.PlaceholderText = "";
            txtTítulo.SelectedText = "";
            txtTítulo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTítulo.Size = new Size(474, 27);
            txtTítulo.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.Transparent;
            cmbCategoria.CustomizableEdges = customizableEdges7;
            cmbCategoria.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbCategoria.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbCategoria.Font = new Font("Segoe UI", 10F);
            cmbCategoria.ForeColor = Color.FromArgb(68, 88, 112);
            cmbCategoria.ItemHeight = 30;
            cmbCategoria.Location = new Point(12, 311);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cmbCategoria.Size = new Size(474, 36);
            cmbCategoria.TabIndex = 3;
            // 
            // chkDestaque
            // 
            chkDestaque.AutoSize = true;
            chkDestaque.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chkDestaque.CheckedState.BorderRadius = 0;
            chkDestaque.CheckedState.BorderThickness = 0;
            chkDestaque.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chkDestaque.Location = new Point(33, 369);
            chkDestaque.Name = "chkDestaque";
            chkDestaque.Size = new Size(123, 19);
            chkDestaque.TabIndex = 4;
            chkDestaque.Text = "Pizza em destaque";
            chkDestaque.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chkDestaque.UncheckedState.BorderRadius = 0;
            chkDestaque.UncheckedState.BorderThickness = 0;
            chkDestaque.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // txtCoverUrl
            // 
            txtCoverUrl.CustomizableEdges = customizableEdges9;
            txtCoverUrl.DefaultText = "";
            txtCoverUrl.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCoverUrl.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCoverUrl.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCoverUrl.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCoverUrl.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCoverUrl.Font = new Font("Segoe UI", 9F);
            txtCoverUrl.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCoverUrl.Location = new Point(12, 252);
            txtCoverUrl.Name = "txtCoverUrl";
            txtCoverUrl.PlaceholderText = "";
            txtCoverUrl.SelectedText = "";
            txtCoverUrl.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtCoverUrl.Size = new Size(474, 27);
            txtCoverUrl.TabIndex = 5;
            // 
            // txtDescricao
            // 
            txtDescricao.CustomizableEdges = customizableEdges11;
            txtDescricao.DefaultText = "";
            txtDescricao.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDescricao.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDescricao.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDescricao.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDescricao.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescricao.Font = new Font("Segoe UI", 9F);
            txtDescricao.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDescricao.Location = new Point(12, 150);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "";
            txtDescricao.SelectedText = "";
            txtDescricao.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtDescricao.Size = new Size(474, 72);
            txtDescricao.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 503);
            Controls.Add(txtDescricao);
            Controls.Add(txtCoverUrl);
            Controls.Add(chkDestaque);
            Controls.Add(cmbCategoria);
            Controls.Add(txtTítulo);
            Controls.Add(lblCampCategoria);
            Controls.Add(lblCampCover);
            Controls.Add(lblCampDesc);
            Controls.Add(lblCampTitulo);
            Controls.Add(lblTituloForm);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Label lblCampDesc;
        private Label lblCampTitulo;
        private Label lblTituloForm;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Label lblCampCategoria;
        private Label lblCampCover;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtTítulo;
        private Guna.UI2.WinForms.Guna2CheckBox chkDestaque;
        private Guna.UI2.WinForms.Guna2TextBox txtDescricao;
        private Guna.UI2.WinForms.Guna2TextBox txtCoverUrl;
    }
}