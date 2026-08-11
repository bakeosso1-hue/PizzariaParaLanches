namespace Pizzaria.Desktop.UserControls
{
    partial class PizzasUserControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            gridGames = new DataGridView();
            pnlToolbar = new Panel();
            txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            btnEditar = new Guna.UI2.WinForms.Guna2Button();
            btnNova = new Guna.UI2.WinForms.Guna2Button();
            lblTitulo = new Label();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colReleaseYear = new DataGridViewTextBoxColumn();
            colIsFeatured = new DataGridViewCheckBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridGames).BeginInit();
            pnlToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // gridGames
            // 
            gridGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGames.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colCategoryName, colReleaseYear, colIsFeatured, colCreatedAt });
            gridGames.Location = new Point(15, 159);
            gridGames.Name = "gridGames";
            gridGames.Size = new Size(768, 316);
            gridGames.TabIndex = 7;
            // 
            // pnlToolbar
            // 
            pnlToolbar.Controls.Add(txtPesquisa);
            pnlToolbar.Controls.Add(btnPesquisar);
            pnlToolbar.Controls.Add(btnAtualizar);
            pnlToolbar.Controls.Add(btnExcluir);
            pnlToolbar.Controls.Add(btnEditar);
            pnlToolbar.Controls.Add(btnNova);
            pnlToolbar.Location = new Point(15, 53);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(768, 100);
            pnlToolbar.TabIndex = 8;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BorderRadius = 5;
            txtPesquisa.CustomizableEdges = customizableEdges13;
            txtPesquisa.DefaultText = "🔎 Pesquisar por Nome...";
            txtPesquisa.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPesquisa.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPesquisa.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPesquisa.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPesquisa.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPesquisa.Font = new Font("Segoe UI", 9F);
            txtPesquisa.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPesquisa.Location = new Point(13, 28);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "";
            txtPesquisa.SelectedText = "";
            txtPesquisa.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtPesquisa.Size = new Size(253, 36);
            txtPesquisa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BorderRadius = 10;
            btnPesquisar.CustomizableEdges = customizableEdges15;
            btnPesquisar.DisabledState.BorderColor = Color.DarkGray;
            btnPesquisar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPesquisar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPesquisar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPesquisar.FillColor = Color.DodgerBlue;
            btnPesquisar.Font = new Font("Segoe UI", 9F);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(282, 28);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnPesquisar.Size = new Size(93, 44);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "🔎 Pesquisar";
            // 
            // btnAtualizar
            // 
            btnAtualizar.BorderRadius = 10;
            btnAtualizar.CustomizableEdges = customizableEdges17;
            btnAtualizar.DisabledState.BorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAtualizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAtualizar.FillColor = Color.Olive;
            btnAtualizar.Font = new Font("Segoe UI", 9F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(669, 28);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnAtualizar.Size = new Size(90, 41);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "🔄️ Atualizar";
            // 
            // btnExcluir
            // 
            btnExcluir.BorderRadius = 10;
            btnExcluir.CustomizableEdges = customizableEdges19;
            btnExcluir.DisabledState.BorderColor = Color.DarkGray;
            btnExcluir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExcluir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExcluir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExcluir.FillColor = Color.FromArgb(192, 0, 0);
            btnExcluir.Font = new Font("Segoe UI", 9F);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(573, 28);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnExcluir.Size = new Size(90, 41);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "🗑️ Excluir";
            // 
            // btnEditar
            // 
            btnEditar.BorderRadius = 10;
            btnEditar.CustomizableEdges = customizableEdges21;
            btnEditar.DisabledState.BorderColor = Color.DarkGray;
            btnEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditar.FillColor = Color.FromArgb(0, 77, 147);
            btnEditar.Font = new Font("Segoe UI", 9F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(477, 28);
            btnEditar.Name = "btnEditar";
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnEditar.Size = new Size(90, 41);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "✏️ Editar";
            // 
            // btnNova
            // 
            btnNova.BorderRadius = 10;
            btnNova.CustomizableEdges = customizableEdges23;
            btnNova.DisabledState.BorderColor = Color.DarkGray;
            btnNova.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNova.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNova.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNova.FillColor = Color.Green;
            btnNova.Font = new Font("Segoe UI", 9F);
            btnNova.ForeColor = Color.White;
            btnNova.Location = new Point(381, 28);
            btnNova.Name = "btnNova";
            btnNova.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnNova.Size = new Size(90, 41);
            btnNova.TabIndex = 1;
            btnNova.Text = "+ Nova Pizza";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblTitulo.Location = new Point(15, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(260, 25);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "🍕 Gerenciamento de Pizzas";
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Nome";
            colTitle.Name = "colTitle";
            colTitle.Width = 225;
            // 
            // colCategoryName
            // 
            colCategoryName.HeaderText = "Categoria";
            colCategoryName.Name = "colCategoryName";
            // 
            // colReleaseYear
            // 
            colReleaseYear.HeaderText = "Ano";
            colReleaseYear.Name = "colReleaseYear";
            // 
            // colIsFeatured
            // 
            colIsFeatured.HeaderText = "Destaque";
            colIsFeatured.Name = "colIsFeatured";
            colIsFeatured.Resizable = DataGridViewTriState.True;
            colIsFeatured.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colCreatedAt
            // 
            colCreatedAt.HeaderText = "Cadastrado em";
            colCreatedAt.Name = "colCreatedAt";
            // 
            // PizzasUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitulo);
            Controls.Add(pnlToolbar);
            Controls.Add(gridGames);
            Name = "PizzasUserControl";
            Size = new Size(810, 499);
            ((System.ComponentModel.ISupportInitialize)gridGames).EndInit();
            pnlToolbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridGames;
        private Panel pnlToolbar;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnNova;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colCategoryName;
        private DataGridViewTextBoxColumn colReleaseYear;
        private DataGridViewCheckBoxColumn colIsFeatured;
        private DataGridViewTextBoxColumn colCreatedAt;
    }
}
