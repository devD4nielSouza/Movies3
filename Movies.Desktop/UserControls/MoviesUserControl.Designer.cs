namespace Movies.Desktop.UserControls
{
    partial class MoviesUserControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            gridMovies = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colReleseYear = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colAgeRating = new DataGridViewTextBoxColumn();
            colDuration = new DataGridViewTextBoxColumn();
            btnNovo = new Guna.UI2.WinForms.Guna2Button();
            btnEditar = new Guna.UI2.WinForms.Guna2Button();
            btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            btnAtualizar = new Guna.UI2.WinForms.Guna2Button();
            lblTitulo = new Label();
            panel1 = new Panel();
            txtPesquisa = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)gridMovies).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridMovies
            // 
            gridMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMovies.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colReleseYear, colCategoryName, colAgeRating, colDuration });
            gridMovies.Location = new Point(22, 87);
            gridMovies.Name = "gridMovies";
            gridMovies.Size = new Size(787, 310);
            gridMovies.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Título";
            colTitle.Name = "colTitle";
            colTitle.Width = 182;
            // 
            // colReleseYear
            // 
            colReleseYear.HeaderText = "Ano";
            colReleseYear.Name = "colReleseYear";
            colReleseYear.Width = 70;
            // 
            // colCategoryName
            // 
            colCategoryName.HeaderText = "Categoria";
            colCategoryName.Name = "colCategoryName";
            colCategoryName.Width = 132;
            // 
            // colAgeRating
            // 
            colAgeRating.HeaderText = "Classificação";
            colAgeRating.Name = "colAgeRating";
            // 
            // colDuration
            // 
            colDuration.HeaderText = "Duração";
            colDuration.Name = "colDuration";
            colDuration.Width = 160;
            // 
            // btnNovo
            // 
            btnNovo.BorderRadius = 5;
            btnNovo.CustomizableEdges = customizableEdges1;
            btnNovo.DisabledState.BorderColor = Color.DarkGray;
            btnNovo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNovo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNovo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNovo.FillColor = Color.FromArgb(79, 37, 112);
            btnNovo.Font = new Font("Segoe UI", 9F);
            btnNovo.ForeColor = Color.White;
            btnNovo.Location = new Point(270, 8);
            btnNovo.Name = "btnNovo";
            btnNovo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnNovo.Size = new Size(106, 34);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "+ Novo Filme";
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.BorderRadius = 5;
            btnEditar.CustomizableEdges = customizableEdges3;
            btnEditar.DisabledState.BorderColor = Color.DarkGray;
            btnEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEditar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEditar.FillColor = Color.FromArgb(60, 117, 43);
            btnEditar.Font = new Font("Segoe UI", 9F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(396, 8);
            btnEditar.Name = "btnEditar";
            btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEditar.Size = new Size(106, 34);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "📝Editar";
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.BorderRadius = 5;
            btnExcluir.CustomizableEdges = customizableEdges5;
            btnExcluir.DisabledState.BorderColor = Color.DarkGray;
            btnExcluir.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExcluir.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExcluir.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExcluir.FillColor = Color.Maroon;
            btnExcluir.Font = new Font("Segoe UI", 9F);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(525, 8);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnExcluir.Size = new Size(96, 34);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "🗑️ Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BorderRadius = 5;
            btnAtualizar.CustomizableEdges = customizableEdges7;
            btnAtualizar.DisabledState.BorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAtualizar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAtualizar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAtualizar.FillColor = Color.FromArgb(204, 154, 23);
            btnAtualizar.Font = new Font("Segoe UI", 9F);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(641, 8);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAtualizar.Size = new Size(106, 34);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Atualizar\r\n";
            btnAtualizar.Click += btnAtualizar_Click_1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(48, 48, 48);
            lblTitulo.Location = new Point(31, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(247, 25);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Gereciamento de filmes 🎬\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPesquisa);
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(btnAtualizar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnExcluir);
            panel1.Location = new Point(22, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 50);
            panel1.TabIndex = 4;
            // 
            // txtPesquisa
            // 
            txtPesquisa.BorderRadius = 10;
            txtPesquisa.CustomizableEdges = customizableEdges9;
            txtPesquisa.DefaultText = "";
            txtPesquisa.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPesquisa.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPesquisa.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPesquisa.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPesquisa.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPesquisa.Font = new Font("Segoe UI", 9F);
            txtPesquisa.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPesquisa.Location = new Point(30, 8);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisa por titulo";
            txtPesquisa.SelectedText = "";
            txtPesquisa.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtPesquisa.Size = new Size(219, 34);
            txtPesquisa.TabIndex = 3;
            txtPesquisa.KeyUp += txtPesquisa_KeyUp;
            // 
            // MoviesUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            Controls.Add(gridMovies);
            Name = "MoviesUserControl";
            Size = new Size(831, 414);
            Load += MoviesUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)gridMovies).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridMovies;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnAtualizar;
        private Label lblTitulo;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisa;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colReleseYear;
        private DataGridViewTextBoxColumn colCategoryName;
        private DataGridViewTextBoxColumn colAgeRating;
        private DataGridViewTextBoxColumn colDuration;
    }
}
