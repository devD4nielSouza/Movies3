namespace Movies.Desktop.Forms
{
    partial class MainForm
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
            pnlConteudo = new Panel();
            pnlHeader = new Panel();
            lblTituloApp = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pnlLogo = new Panel();
            panel2 = new Panel();
            lblSidebarSub = new Label();
            lblSidebarLogo = new Label();
            pnlSidebar = new Panel();
            lblSessao = new Label();
            btnFilmes = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            pnlHeader.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlConteudo
            // 
            pnlConteudo.Location = new Point(166, 92);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(831, 414);
            pnlConteudo.TabIndex = 7;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTituloApp);
            pnlHeader.Controls.Add(guna2Button1);
            pnlHeader.Location = new Point(166, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(839, 84);
            pnlHeader.TabIndex = 6;
            // 
            // lblTituloApp
            // 
            lblTituloApp.AutoSize = true;
            lblTituloApp.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloApp.ForeColor = Color.FromArgb(108, 51, 108);
            lblTituloApp.Location = new Point(37, 28);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(103, 23);
            lblTituloApp.TabIndex = 5;
            lblTituloApp.Text = "🎬MOVIE";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(87, 17, 116);
            guna2Button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(711, 19);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(100, 32);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "Sair";
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(64, 13, 85);
            pnlLogo.Controls.Add(panel2);
            pnlLogo.Controls.Add(lblSidebarSub);
            pnlLogo.Controls.Add(lblSidebarLogo);
            pnlLogo.Location = new Point(-2, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(162, 105);
            pnlLogo.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(130, 73, 133);
            panel2.ForeColor = Color.FromArgb(107, 30, 123);
            panel2.Location = new Point(8, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 1);
            panel2.TabIndex = 1;
            // 
            // lblSidebarSub
            // 
            lblSidebarSub.AutoSize = true;
            lblSidebarSub.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSidebarSub.ForeColor = Color.White;
            lblSidebarSub.Location = new Point(18, 51);
            lblSidebarSub.Name = "lblSidebarSub";
            lblSidebarSub.Size = new Size(126, 17);
            lblSidebarSub.TabIndex = 3;
            lblSidebarSub.Text = "Plataforma Desktop";
            // 
            // lblSidebarLogo
            // 
            lblSidebarLogo.AutoSize = true;
            lblSidebarLogo.Font = new Font("Century Schoolbook", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSidebarLogo.ForeColor = Color.White;
            lblSidebarLogo.Location = new Point(18, 28);
            lblSidebarLogo.Name = "lblSidebarLogo";
            lblSidebarLogo.Size = new Size(103, 23);
            lblSidebarLogo.TabIndex = 4;
            lblSidebarLogo.Text = "🎬MOVIE";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(87, 17, 116);
            pnlSidebar.Controls.Add(lblSessao);
            pnlSidebar.Controls.Add(btnFilmes);
            pnlSidebar.Controls.Add(panel1);
            pnlSidebar.Location = new Point(-2, 104);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(162, 415);
            pnlSidebar.TabIndex = 4;
            // 
            // lblSessao
            // 
            lblSessao.AutoSize = true;
            lblSessao.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSessao.ForeColor = Color.White;
            lblSessao.Location = new Point(12, 386);
            lblSessao.Name = "lblSessao";
            lblSessao.Size = new Size(16, 15);
            lblSessao.TabIndex = 3;
            lblSessao.Text = "...";
            // 
            // btnFilmes
            // 
            btnFilmes.BorderRadius = 5;
            btnFilmes.CustomizableEdges = customizableEdges3;
            btnFilmes.DisabledState.BorderColor = Color.DarkGray;
            btnFilmes.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFilmes.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFilmes.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFilmes.FillColor = Color.FromArgb(133, 47, 151);
            btnFilmes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilmes.ForeColor = Color.White;
            btnFilmes.Location = new Point(12, 20);
            btnFilmes.Name = "btnFilmes";
            btnFilmes.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnFilmes.Size = new Size(141, 32);
            btnFilmes.TabIndex = 2;
            btnFilmes.Text = "🎞️Filmes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(130, 73, 133);
            panel1.ForeColor = Color.FromArgb(107, 30, 123);
            panel1.Location = new Point(7, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 1);
            panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 519);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlHeader);
            Controls.Add(pnlLogo);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConteudo;
        private Panel pnlHeader;
        private Label lblTituloApp;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Panel pnlLogo;
        private Panel panel2;
        private Label lblSidebarSub;
        private Label lblSidebarLogo;
        private Panel pnlSidebar;
        private Label lblSessao;
        private Guna.UI2.WinForms.Guna2Button btnFilmes;
        private Panel panel1;
    }
}