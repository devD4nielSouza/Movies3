using Movies.Desktop.DTOs;
using Movies.Desktop.Forms;
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
        private CategoriasApiService _categoriasService = null;


        private List<MovieResponseDto> _todosMovies = new();
        private List<CategoriaResponseDto> _categorias = new();

        public MoviesUserControl()
        {
            InitializeComponent();
        }

        private async void MoviesUserControl_Load(object sender, EventArgs e)
        {
            _moviesService = new MoviesApiService();
            _categoriasService = new CategoriasApiService();

            await CarregarDadosAsync();
        }

        private async Task CarregarDadosAsync()
        {
            gridMovies.Rows.Clear();

            try
            {
                var tarefaMovies = _moviesService.GetAllAsync();
                var tarefaCategorias = _categoriasService.GetAllAsync();
                await Task.WhenAll(tarefaMovies, tarefaCategorias);

                _todosMovies = tarefaMovies.Result;
                _categorias = tarefaCategorias.Result;



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
                    m.ReleaseDate,
                    m.CategoryName,
                    m.Classification,
                    m.Duration);

            }
        }

        private void FiltrarMovies()
        {
            var termo = txtPesquisa.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(termo))
            {
                PopularGrid(_todosMovies);
                return;
            }

            var filtrados = _todosMovies
                .Where(m => m.Title.Contains(termo, StringComparison.OrdinalIgnoreCase)
                || m.CategoryName.Contains(termo, StringComparison.OrdinalIgnoreCase))
                .ToList();

            PopularGrid(filtrados);
        }

        private void txtPesquisa_KeyUp(object sender, KeyEventArgs e) => FiltrarMovies();

        private async void btnNovo_Click(object sender, EventArgs e)
        {
            using var form = new MovieFormDialog(_categorias, null);
            if (form.ShowDialog() == DialogResult.OK && form.MovieDto != null)
            {
                var (success, _, error) = await _moviesService.CreateAsync(form.MovieDto);
                if (success)
                {
                    MessageBox.Show("✅ Filme criado com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"❌ {error}",
                      "Erro",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                }
            }
        }




        private MovieResponseDto? ObterMovieSelecionado()
        {
            if (gridMovies.SelectedRows.Count == 0) return null;
            var row = gridMovies.SelectedRows[0];
            var id = Convert.ToInt32(row.Cells["colId"].Value);
            return _todosMovies.FirstOrDefault(g => g.Id == id);
        }

        private async void btnEditar_Click_1(object sender, EventArgs e)
        {
            var movie = ObterMovieSelecionado();
            if (movie == null)
            {
                MessageBox.Show($"Selecione um filme para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using var form = new MovieFormDialog(_categorias, movie);
            if (form.ShowDialog() == DialogResult.OK && form.UpdateDto != null)
            {
                var (success, _, error) = await _moviesService.UpdateAsync(movie.Id, form.UpdateDto);
                if (success)
                {
                    MessageBox.Show("✅ Filme atualizado com sucesso",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"❌ {error}",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

        }

        private async void btnAtualizar_Click_1(object sender, EventArgs e) => await CarregarDadosAsync();

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
         
            var movie = ObterMovieSelecionado();
            if (movie == null)
            {
                MessageBox.Show("Selecione um filme para excluir.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var resposta = MessageBox.Show(
                $"Deseja realmente excluir o filme '{movie.Title}'?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes) return;

            try
            {
                var (success, error) = await _moviesService.DeleteAsync(movie.Id);
                if (success)
                {
                    MessageBox.Show("✅ Filme excluído com sucesso.",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    await CarregarDadosAsync();
                }
                else
                {
                    MessageBox.Show($"❌ {error}",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Erro ao excluir: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
    }

