namespace Pizzaria.Desktop.UserControls
{
    partial class DashboardUserControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            gridUltimasPizzas = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colIsFeatured = new DataGridViewCheckBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            pnlCorCategorias = new Guna.UI2.WinForms.Guna2Panel();
            cardCategorias = new Guna.UI2.WinForms.Guna2Panel();
            cardCategoriasLblNumero = new Label();
            cardCategoriasLblTitulo = new Label();
            cardCategoriasLblDesc = new Label();
            cardPizzas = new Guna.UI2.WinForms.Guna2Panel();
            pnlCorGames = new Guna.UI2.WinForms.Guna2Panel();
            cardPizzasLblDesc = new Label();
            cardGamesLblNumero = new Label();
            cardPizzaslblTitulo = new Label();
            lblUltimasPizzas = new Label();
            lblCarregando = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)gridUltimasPizzas).BeginInit();
            cardCategorias.SuspendLayout();
            cardPizzas.SuspendLayout();
            SuspendLayout();
            // 
            // gridUltimasPizzas
            // 
            gridUltimasPizzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUltimasPizzas.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colCategoryName, colIsFeatured, colCreatedAt });
            gridUltimasPizzas.Location = new Point(20, 267);
            gridUltimasPizzas.Name = "gridUltimasPizzas";
            gridUltimasPizzas.Size = new Size(770, 217);
            gridUltimasPizzas.TabIndex = 11;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.Width = 50;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Título";
            colTitle.Name = "colTitle";
            colTitle.Width = 150;
            // 
            // colCategoryName
            // 
            colCategoryName.HeaderText = "Categoria";
            colCategoryName.Name = "colCategoryName";
            // 
            // colIsFeatured
            // 
            colIsFeatured.HeaderText = "Destaque";
            colIsFeatured.Name = "colIsFeatured";
            // 
            // colCreatedAt
            // 
            colCreatedAt.HeaderText = "Cadastrado em";
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.Resizable = DataGridViewTriState.True;
            colCreatedAt.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlCorCategorias
            // 
            pnlCorCategorias.CustomizableEdges = customizableEdges1;
            pnlCorCategorias.FillColor = Color.Gold;
            pnlCorCategorias.Location = new Point(250, 94);
            pnlCorCategorias.Name = "pnlCorCategorias";
            pnlCorCategorias.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlCorCategorias.Size = new Size(210, 10);
            pnlCorCategorias.TabIndex = 10;
            // 
            // cardCategorias
            // 
            cardCategorias.Controls.Add(cardCategoriasLblNumero);
            cardCategorias.Controls.Add(cardCategoriasLblTitulo);
            cardCategorias.Controls.Add(cardCategoriasLblDesc);
            cardCategorias.CustomizableEdges = customizableEdges3;
            cardCategorias.FillColor = Color.White;
            cardCategorias.Location = new Point(250, 94);
            cardCategorias.Name = "cardCategorias";
            cardCategorias.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cardCategorias.Size = new Size(210, 120);
            cardCategorias.TabIndex = 8;
            // 
            // cardCategoriasLblNumero
            // 
            cardCategoriasLblNumero.AutoSize = true;
            cardCategoriasLblNumero.BackColor = Color.White;
            cardCategoriasLblNumero.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardCategoriasLblNumero.Location = new Point(20, 38);
            cardCategoriasLblNumero.Name = "cardCategoriasLblNumero";
            cardCategoriasLblNumero.Size = new Size(38, 45);
            cardCategoriasLblNumero.TabIndex = 2;
            cardCategoriasLblNumero.Text = "0";
            // 
            // cardCategoriasLblTitulo
            // 
            cardCategoriasLblTitulo.AutoSize = true;
            cardCategoriasLblTitulo.BackColor = Color.White;
            cardCategoriasLblTitulo.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            cardCategoriasLblTitulo.ForeColor = Color.FromArgb(248, 148, 27);
            cardCategoriasLblTitulo.Location = new Point(14, 19);
            cardCategoriasLblTitulo.Name = "cardCategoriasLblTitulo";
            cardCategoriasLblTitulo.Size = new Size(117, 19);
            cardCategoriasLblTitulo.TabIndex = 1;
            cardCategoriasLblTitulo.Text = "🏷️ Categorias";
            // 
            // cardCategoriasLblDesc
            // 
            cardCategoriasLblDesc.AutoSize = true;
            cardCategoriasLblDesc.BackColor = Color.White;
            cardCategoriasLblDesc.Font = new Font("Century Gothic", 8.25F);
            cardCategoriasLblDesc.ForeColor = SystemColors.ControlDark;
            cardCategoriasLblDesc.Location = new Point(20, 83);
            cardCategoriasLblDesc.Name = "cardCategoriasLblDesc";
            cardCategoriasLblDesc.Size = new Size(111, 16);
            cardCategoriasLblDesc.TabIndex = 0;
            cardCategoriasLblDesc.Text = "Total de categorias";
            // 
            // cardPizzas
            // 
            cardPizzas.BorderRadius = 10;
            cardPizzas.Controls.Add(pnlCorGames);
            cardPizzas.Controls.Add(cardPizzasLblDesc);
            cardPizzas.Controls.Add(cardGamesLblNumero);
            cardPizzas.Controls.Add(cardPizzaslblTitulo);
            cardPizzas.CustomizableEdges = customizableEdges7;
            cardPizzas.FillColor = Color.White;
            cardPizzas.Location = new Point(13, 94);
            cardPizzas.Name = "cardPizzas";
            cardPizzas.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cardPizzas.Size = new Size(210, 120);
            cardPizzas.TabIndex = 9;
            // 
            // pnlCorGames
            // 
            pnlCorGames.CustomizableEdges = customizableEdges5;
            pnlCorGames.FillColor = Color.Crimson;
            pnlCorGames.Location = new Point(0, 0);
            pnlCorGames.Name = "pnlCorGames";
            pnlCorGames.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlCorGames.Size = new Size(210, 10);
            pnlCorGames.TabIndex = 2;
            // 
            // cardPizzasLblDesc
            // 
            cardPizzasLblDesc.AutoSize = true;
            cardPizzasLblDesc.BackColor = Color.White;
            cardPizzasLblDesc.Font = new Font("Century Gothic", 8.25F);
            cardPizzasLblDesc.ForeColor = SystemColors.ControlDark;
            cardPizzasLblDesc.Location = new Point(12, 83);
            cardPizzasLblDesc.Name = "cardPizzasLblDesc";
            cardPizzasLblDesc.Size = new Size(158, 16);
            cardPizzasLblDesc.TabIndex = 3;
            cardPizzasLblDesc.Text = "Total de Pizzas cadastradas";
            // 
            // cardGamesLblNumero
            // 
            cardGamesLblNumero.AutoSize = true;
            cardGamesLblNumero.BackColor = Color.White;
            cardGamesLblNumero.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardGamesLblNumero.Location = new Point(12, 38);
            cardGamesLblNumero.Name = "cardGamesLblNumero";
            cardGamesLblNumero.Size = new Size(38, 45);
            cardGamesLblNumero.TabIndex = 2;
            cardGamesLblNumero.Text = "0";
            // 
            // cardPizzaslblTitulo
            // 
            cardPizzaslblTitulo.AutoSize = true;
            cardPizzaslblTitulo.BackColor = Color.White;
            cardPizzaslblTitulo.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            cardPizzaslblTitulo.ForeColor = Color.Crimson;
            cardPizzaslblTitulo.Location = new Point(12, 19);
            cardPizzaslblTitulo.Name = "cardPizzaslblTitulo";
            cardPizzaslblTitulo.Size = new Size(77, 19);
            cardPizzaslblTitulo.TabIndex = 1;
            cardPizzaslblTitulo.Text = "🍕 Pizzas";
            // 
            // lblUltimasPizzas
            // 
            lblUltimasPizzas.AutoSize = true;
            lblUltimasPizzas.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUltimasPizzas.Location = new Point(13, 239);
            lblUltimasPizzas.Name = "lblUltimasPizzas";
            lblUltimasPizzas.Size = new Size(228, 19);
            lblUltimasPizzas.TabIndex = 4;
            lblUltimasPizzas.Text = "💾 Últimas pizzas cadastradas";
            // 
            // lblCarregando
            // 
            lblCarregando.AutoSize = true;
            lblCarregando.Font = new Font("Century Gothic", 10F);
            lblCarregando.ForeColor = Color.DodgerBlue;
            lblCarregando.Location = new Point(13, 62);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(221, 19);
            lblCarregando.TabIndex = 5;
            lblCarregando.Text = "⌛Carregando dados da API...";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Century Gothic", 10F);
            lblSubtitulo.ForeColor = SystemColors.ControlDark;
            lblSubtitulo.Location = new Point(13, 36);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(248, 19);
            lblSubtitulo.TabIndex = 6;
            lblSubtitulo.Text = "Bem-vindo a Pizzaria Pará Lanches";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(13, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(77, 23);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Olá! 👋";
            // 
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridUltimasPizzas);
            Controls.Add(pnlCorCategorias);
            Controls.Add(cardCategorias);
            Controls.Add(cardPizzas);
            Controls.Add(lblUltimasPizzas);
            Controls.Add(lblCarregando);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Name = "DashboardUserControl";
            Size = new Size(815, 506);
            Load += DashboardUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)gridUltimasPizzas).EndInit();
            cardCategorias.ResumeLayout(false);
            cardCategorias.PerformLayout();
            cardPizzas.ResumeLayout(false);
            cardPizzas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridUltimasPizzas;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colCategoryName;
        private DataGridViewCheckBoxColumn colIsFeatured;
        private DataGridViewTextBoxColumn colCreatedAt;
        private Guna.UI2.WinForms.Guna2Panel pnlCorCategorias;
        private Guna.UI2.WinForms.Guna2Panel cardCategorias;
        private Label cardCategoriasLblNumero;
        private Label cardCategoriasLblTitulo;
        private Label cardCategoriasLblDesc;
        private Guna.UI2.WinForms.Guna2Panel cardPizzas;
        private Guna.UI2.WinForms.Guna2Panel pnlCorGames;
        private Label cardPizzasLblDesc;
        private Label cardGamesLblNumero;
        private Label cardPizzaslblTitulo;
        private Label lblUltimasPizzas;
        private Label lblCarregando;
        private Label lblSubtitulo;
        private Label lblTitulo;
    }
}
