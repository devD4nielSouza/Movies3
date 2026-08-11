using Guna.UI2.WinForms;
using Movies.Desktop.Helpers;
using Movies.Desktop.Services;
using Movies.Desktop.UserControls;
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
    public partial class MainForm : Form
    {
        private UserControl? _controleAtual;

        private Guna2Button? _botaoAtivo;

        private AuthApiService _authService = null;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _authService = new AuthApiService();

            this.Text = $"Movies Desktop - {AppConfig.Version}";

            lblSessao.Text = $" 📽️ {SessionManager.Instance.GetEmail()}";


        }


        private void NavegarParaFilmes()
        {
            Navegar(new MoviesUserControl(), btnFilmes);
        }

        private void Navegar(UserControl control, Guna2Button? botao = null)
        {
            //Remove o UserControl anterior
            if (_controleAtual != null)
            {
                pnlConteudo.Controls.Remove(_controleAtual);
                _controleAtual.Dispose();
                _controleAtual = null;
            }

            //Adiona o novo UserControl(Tela interna)
            control.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(control);
            _controleAtual = control;

        }

        private async void btnSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show(
               "Deseja realmente sair do sistema?",
               "Confirmar Logout",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (resposta != DialogResult.Yes) return;

            try
            {
                await _authService.LogoutAsync();
            }
            catch
            {
                // Mesmo se a API falhar, limpa a sessão local
            }
            finally
            {
                SessionManager.Instance.Clear();
                this.Close();
            }
        }

        private void btnFilmes_Click(object sender, EventArgs e) => NavegarParaFilmes();

    }
}
