using Movies.Desktop.DTOs;

namespace Movies.Desktop.Forms
{
    public partial class MovieFormDialog : Form
    {
        public CreateMovieDto? MovieDto { get; private set; }

        /// <summary>
        /// DTO preenchido quando no modo de edição (OK)
        /// </summary>
        public UpdateMovieDto? UpdateDto { get; private set; }

        private List<CategoriaResponseDto> _categorias = new();

        private MovieResponseDto? _movieExistente;
        public MovieFormDialog()
        {
            InitializeComponent();
        }

        public MovieFormDialog(List<CategoriaResponseDto> categorias, MovieResponseDto? movie)
        {
            _categorias = categorias;
            _movieExistente = movie;
            InitializeComponent();
        }

        private void MovieFormDialog_Load(object sender, EventArgs e)
        {
          

            //Configurar titulo baseado no modo (criação/edição)
            this.Text = _movieExistente == null ? "Novo filme" : "Editar filme";
            lblTituloForm.Text = _movieExistente == null ? "➕ Novo Filme" : "✏️ Editar Filme";

            //Popula o comboBox de categorias
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Selecione uma categoria...");
            foreach (var cat in _categorias)
                cmbCategoria.Items.Add(cat.Name);
            cmbCategoria.SelectedIndex = 0;

            PreencherCampos();
        }

        private void PreencherCampos()
        {
            if (_movieExistente == null) return;

            txtTitulo.Text = _movieExistente.Title;
            txtDescricao.Text = _movieExistente.Description;
            txtAno.Text = _movieExistente.ReleaseDate.ToString();
            txtCoverUrl.Text = _movieExistente.CoverImageUrl;
            txtClassificacao.Text = _movieExistente.Classification;
            txtDuracao.Text = _movieExistente.Duration.ToString();
          

            var idx = _categorias.FindIndex(c => c.Id == _movieExistente.CategoryId);
            if (idx >= 0) cmbCategoria.SelectedIndex = idx + 1;

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show(
                    "Informe o titulo do filme.",
                    "validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAno.Text, out int ano) || ano < 1970 || ano > DateTime.Now.Year + 2)
            {
                MessageBox.Show(
                    "Informe um ano válido.",
                    "validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategoria.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecione uma categoria",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var categoriaIdx = cmbCategoria.SelectedIndex - 1;
            var categoriaId = _categorias[categoriaIdx].Id;

            // Converte os minutos digitados para horas (arredondado)
            //int duracaoEmHoras = 0;
            //if (!string.IsNullOrWhiteSpace(txtDuracao.Text) && int.TryParse(txtDuracao.Text.Trim(), out int minutos))
            //{
            //    duracaoEmHoras = (int)Math.Round(minutos / 60.0);
            //}

            if (_movieExistente == null)
            {
                MovieDto = new CreateMovieDto
                {
                    Title = txtTitulo.Text.Trim(),
                    Description = txtDescricao.Text.Trim(),
                    ReleaseDate = ano,
                    CoverImageUrl = txtCoverUrl.Text.Trim(),
                    CategoryId = categoriaId,
                    Duration = Convert.ToInt32(txtDuracao.Text.Trim()),                       
                    Classification = txtClassificacao.Text.Trim()
                };
            }
            else
            {
                UpdateDto = new UpdateMovieDto
                {
                    Title = txtTitulo.Text.Trim(),
                    Description = txtDescricao.Text.Trim(),
                    ReleaseDate = ano,
                    CoverImageUrl = txtCoverUrl.Text.Trim(),
                    CategoryId = categoriaId,
                    Duration = Convert.ToInt32(txtDuracao.Text.Trim()),                     
                    Classification = txtClassificacao.Text.Trim()
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
