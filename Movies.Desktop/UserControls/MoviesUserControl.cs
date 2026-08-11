using Movies.Desktop.DTOs;
using Movies.Desktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies.Desktop.UserControls
{
    public partial class MoviesUserControl : UserControl
    {
        private MoviesApiService _moviesService = null;


        private List<MovieResponseDto> _todosMovies = new();

        public MoviesUserControl()
        {
            InitializeComponent();
        }

        private async void MoviesUserControl_Load(object sender, EventArgs e)
        {
            _moviesService = new MoviesApiService();

            await CarregarDadosAsync(); 
        }

        private async Task CarregarDadosAsync() 
        {
            gridMovies.Rows.Clear();
            try
            {
                var tarefasMovies = _moviesService.GetAllAsync();

                _todosMovies = tarefasMovies.Result;

                PopularGrid(_todosMovies);
            }
            catch (Exception ex) 
            {

                MessageBox.Show(
                    $"Erro ao carregar os filmes: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void PopularGrid(List<MovieResponseDto> movies)
        {
            gridMovies.Rows.Clear();
            foreach (var m in movies)
            {
                gridMovies.Rows.Add(
                    m.Id,
                    m.Title,
                    m.CategoryName,
                    m.ReleaseYear,
                    m.IsFeatured,
                    m.CreatedAt.ToString("dd/MM/yyyy HH:mm"));

            }
        }
}
