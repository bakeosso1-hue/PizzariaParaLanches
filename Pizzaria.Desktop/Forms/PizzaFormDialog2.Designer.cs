namespace Pizzaria.Desktop.Forms
{
    partial class PizzaFormDialog2
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
            lblCampTitulo = new Label();
            txtTítulo = new Guna.UI2.WinForms.Guna2TextBox();
            lblCampDesc = new Label();
            txtDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            lblCampCover = new Label();
            txtCoverUrl = new Guna.UI2.WinForms.Guna2TextBox();
            lblCampCategoria = new Label();
            cmbCategoria = new ComboBox();
            chkDestaque = new CheckBox();
            btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            lblTituloForm = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            SuspendLayout();
            // 
            // lblCampTitulo
            // 
            lblCampTitulo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCampTitulo.ForeColor = Color.FromArgb(51, 61, 75);
            lblCampTitulo.Location = new Point(120, 105);
            lblCampTitulo.Name = "lblCampTitulo";
            lblCampTitulo.Size = new Size(474, 20);
            lblCampTitulo.TabIndex = 28;
            lblCampTitulo.Text = "NOME DA PIZZA *";
            // 
            // txtTítulo
            // 
            txtTítulo.BorderColor = Color.FromArgb(224, 228, 235);
            txtTítulo.BorderRadius = 6;
            txtTítulo.CustomizableEdges = customizableEdges1;
            txtTítulo.DefaultText = "";
            txtTítulo.FillColor = Color.FromArgb(245, 247, 250);
            txtTítulo.Font = new Font("Segoe UI", 9.5F);
            txtTítulo.Location = new Point(120, 127);
            txtTítulo.Name = "txtTítulo";
            txtTítulo.PlaceholderText = "Nome..";
            txtTítulo.SelectedText = "";
            txtTítulo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTítulo.Size = new Size(557, 40);
            txtTítulo.TabIndex = 29;
            // 
            // lblCampDesc
            // 
            lblCampDesc.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCampDesc.ForeColor = Color.FromArgb(51, 61, 75);
            lblCampDesc.Location = new Point(120, 183);
            lblCampDesc.Name = "lblCampDesc";
            lblCampDesc.Size = new Size(474, 20);
            lblCampDesc.TabIndex = 30;
            lblCampDesc.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            txtDescricao.BorderColor = Color.FromArgb(224, 228, 235);
            txtDescricao.BorderRadius = 6;
            txtDescricao.CustomizableEdges = customizableEdges3;
            txtDescricao.DefaultText = "";
            txtDescricao.FillColor = Color.FromArgb(245, 247, 250);
            txtDescricao.Font = new Font("Segoe UI", 9.5F);
            txtDescricao.Location = new Point(120, 205);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição da pizza...";
            txtDescricao.SelectedText = "";
            txtDescricao.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtDescricao.Size = new Size(557, 80);
            txtDescricao.TabIndex = 31;
            // 
            // lblCampCover
            // 
            lblCampCover.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCampCover.ForeColor = Color.FromArgb(51, 61, 75);
            lblCampCover.Location = new Point(120, 301);
            lblCampCover.Name = "lblCampCover";
            lblCampCover.Size = new Size(474, 20);
            lblCampCover.TabIndex = 32;
            lblCampCover.Text = "URL DA PIZZA";
            // 
            // txtCoverUrl
            // 
            txtCoverUrl.BorderColor = Color.FromArgb(224, 228, 235);
            txtCoverUrl.BorderRadius = 6;
            txtCoverUrl.CustomizableEdges = customizableEdges5;
            txtCoverUrl.DefaultText = "";
            txtCoverUrl.FillColor = Color.FromArgb(245, 247, 250);
            txtCoverUrl.Font = new Font("Segoe UI", 9.5F);
            txtCoverUrl.Location = new Point(120, 319);
            txtCoverUrl.Name = "txtCoverUrl";
            txtCoverUrl.PlaceholderText = "https://...";
            txtCoverUrl.SelectedText = "";
            txtCoverUrl.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtCoverUrl.Size = new Size(557, 40);
            txtCoverUrl.TabIndex = 33;
            // 
            // lblCampCategoria
            // 
            lblCampCategoria.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblCampCategoria.ForeColor = Color.FromArgb(51, 61, 75);
            lblCampCategoria.Location = new Point(120, 426);
            lblCampCategoria.Name = "lblCampCategoria";
            lblCampCategoria.Size = new Size(474, 20);
            lblCampCategoria.TabIndex = 34;
            lblCampCategoria.Text = "CATEGORIA *";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(245, 247, 250);
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Segoe UI", 9.5F);
            cmbCategoria.Location = new Point(120, 448);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(557, 25);
            cmbCategoria.TabIndex = 35;
            // 
            // chkDestaque
            // 
            chkDestaque.AutoSize = true;
            chkDestaque.Font = new Font("Segoe UI", 9.5F);
            chkDestaque.ForeColor = Color.FromArgb(51, 61, 75);
            chkDestaque.Location = new Point(134, 500);
            chkDestaque.Name = "chkDestaque";
            chkDestaque.Size = new Size(179, 21);
            chkDestaque.TabIndex = 36;
            chkDestaque.Text = "⭐ Marcar como destaque";
            // 
            // btnSalvar
            // 
            btnSalvar.BorderRadius = 8;
            btnSalvar.CustomizableEdges = customizableEdges7;
            btnSalvar.FillColor = Color.FromArgb(40, 167, 69);
            btnSalvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(120, 530);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSalvar.Size = new Size(154, 42);
            btnSalvar.TabIndex = 37;
            btnSalvar.Text = "💾 Salvar";
            // 
            // btnCancelar
            // 
            btnCancelar.BorderColor = Color.FromArgb(224, 228, 235);
            btnCancelar.BorderRadius = 8;
            btnCancelar.BorderThickness = 1;
            btnCancelar.CustomizableEdges = customizableEdges9;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FillColor = Color.FromArgb(245, 247, 250);
            btnCancelar.Font = new Font("Segoe UI", 9.5F);
            btnCancelar.ForeColor = Color.FromArgb(51, 61, 75);
            btnCancelar.Location = new Point(276, 530);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnCancelar.Size = new Size(114, 42);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            // 
            // lblTituloForm
            // 
            lblTituloForm.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.FromArgb(0, 75, 135);
            lblTituloForm.Location = new Point(120, 47);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(474, 36);
            lblTituloForm.TabIndex = 27;
            lblTituloForm.Text = "Criar Pizza";
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // PizzaFormDialog2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 710);
            Controls.Add(lblCampTitulo);
            Controls.Add(txtTítulo);
            Controls.Add(lblCampDesc);
            Controls.Add(txtDescricao);
            Controls.Add(lblCampCover);
            Controls.Add(txtCoverUrl);
            Controls.Add(lblCampCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(chkDestaque);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(lblTituloForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PizzaFormDialog2";
            Text = "PizzaFormDialog2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCampTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtTítulo;
        private Label lblCampDesc;
        private Guna.UI2.WinForms.Guna2TextBox txtDescricao;
        private Label lblCampCover;
        private Guna.UI2.WinForms.Guna2TextBox txtCoverUrl;
        private Label lblCampCategoria;
        private ComboBox cmbCategoria;
        private CheckBox chkDestaque;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Label lblTituloForm;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}