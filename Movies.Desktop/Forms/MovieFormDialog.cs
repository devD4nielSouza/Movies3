using Movies.Desktop.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies.Desktop.Forms
{
    public partial class MovieFormDialog : Form
    {
        public CreateMovieDto? MovieDto { get; private set; }

        /// <summary>
        /// DTO preenchido quando no modo de edição (OK)
        /// </summary>
        public UpdateMovieDto? UpdateDto { get; private set; }

        private List<CategoryResponseDto> _categorias = new();

        private MovieResponseDto? _movieExistente;
        public MovieFormDialog()
        {
            InitializeComponent();
        }

        public MovieFormDialog(List<CategoryResponseDto> categorias, MovieResponseDto? movie)
        {
            _categorias = categorias;
            _movieExistente = movie;
            InitializeComponent();
        }

        private void MovieFormDialog_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            //Configurar titulo baseado no modo (criação/edição)
            this.Text = _movieExistente == null ? "Novo game" : "Editar game";
            lblTituloForm.Text = _movieExistente == null ? "➕ Novo Game" : "✏️ Editar Game";

            //Popula o comboBox de categorias
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Selecione uma categoria...");
            foreach (var cat in _categorias)
                cmbCategoria.Items.Add(cat.Name);
            cmbCategoria.SelectedIndex = 0;

            PreencherCampos();
        }
    }
}
