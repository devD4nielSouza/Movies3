namespace Movies.Desktop.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pbLogo = new PictureBox();
            btnFechar = new Guna.UI2.WinForms.Guna2CircleButton();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            lblEmail = new Label();
            lblSenha = new Label();
            btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            lblVersao = new Label();
            pnSeparador = new Panel();
            lblErro = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblCarregando = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            lblFacaLogin = new Label();
            guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(56, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(259, 159);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.DisabledState.BorderColor = Color.DarkGray;
            btnFechar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFechar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFechar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFechar.FillColor = Color.FromArgb(87, 17, 116);
            btnFechar.Font = new Font("Segoe UI", 9F);
            btnFechar.ForeColor = Color.WhiteSmoke;
            btnFechar.Location = new Point(325, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnFechar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnFechar.Size = new Size(31, 30);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "❌";
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 10;
            txtEmail.CustomizableEdges = customizableEdges2;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(58, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "seuemail@gmail.com";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtEmail.Size = new Size(257, 36);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 10;
            txtSenha.CustomizableEdges = customizableEdges4;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(58, 280);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "*******";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtSenha.Size = new Size(257, 36);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(64, 0, 64);
            lblEmail.Location = new Point(58, 200);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(40, 17);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.FromArgb(64, 0, 64);
            lblSenha.Location = new Point(58, 262);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(45, 17);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.BorderRadius = 10;
            btnEntrar.CustomizableEdges = customizableEdges6;
            btnEntrar.DisabledState.BorderColor = Color.DarkGray;
            btnEntrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEntrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEntrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEntrar.FillColor = Color.FromArgb(87, 17, 116);
            btnEntrar.Font = new Font("Segoe UI", 9F);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(116, 325);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnEntrar.Size = new Size(137, 42);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVersao.ForeColor = Color.DarkGray;
            lblVersao.Location = new Point(58, 443);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(264, 17);
            lblVersao.TabIndex = 3;
            lblVersao.Text = "Versão: 1.0.0 | ©️ Senac São Miguel Paulista";
            // 
            // pnSeparador
            // 
            pnSeparador.BackColor = SystemColors.ActiveCaption;
            pnSeparador.BorderStyle = BorderStyle.FixedSingle;
            pnSeparador.ForeColor = SystemColors.InactiveCaptionText;
            pnSeparador.Location = new Point(27, 394);
            pnSeparador.Name = "pnSeparador";
            pnSeparador.Size = new Size(309, 1);
            pnSeparador.TabIndex = 9;
            // 
            // lblErro
            // 
            lblErro.BackColor = Color.Transparent;
            lblErro.ForeColor = Color.Maroon;
            lblErro.Location = new Point(27, 420);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(24, 17);
            lblErro.TabIndex = 10;
            lblErro.Text = "Erro";
            lblErro.TextAlignment = ContentAlignment.TopCenter;
            lblErro.Visible = false;
            // 
            // lblCarregando
            // 
            lblCarregando.BackColor = Color.Transparent;
            lblCarregando.ForeColor = SystemColors.ControlDark;
            lblCarregando.Location = new Point(148, 375);
            lblCarregando.Name = "lblCarregando";
            lblCarregando.Size = new Size(84, 17);
            lblCarregando.TabIndex = 11;
            lblCarregando.Text = "Autenticando...";
            lblCarregando.TextAlignment = ContentAlignment.TopCenter;
            lblCarregando.Visible = false;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lblFacaLogin
            // 
            lblFacaLogin.AutoSize = true;
            lblFacaLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFacaLogin.ForeColor = Color.Silver;
            lblFacaLogin.Location = new Point(120, 170);
            lblFacaLogin.Name = "lblFacaLogin";
            lblFacaLogin.Size = new Size(112, 17);
            lblFacaLogin.TabIndex = 3;
            lblFacaLogin.Text = "Acesse sua conta ";
            // 
            // guna2BorderlessForm2
            // 
            guna2BorderlessForm2.ContainerControl = this;
            guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(368, 469);
            Controls.Add(lblCarregando);
            Controls.Add(lblErro);
            Controls.Add(pnSeparador);
            Controls.Add(btnEntrar);
            Controls.Add(lblSenha);
            Controls.Add(lblVersao);
            Controls.Add(lblFacaLogin);
            Controls.Add(lblEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(btnFechar);
            Controls.Add(pbLogo);
            ForeColor = Color.FromArgb(224, 224, 224);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2CircleButton btnFechar;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Label lblEmail;
        private Label lblSenha;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private Label lblVersao;
        private Panel pnSeparador;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblErro;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCarregando;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Label lblFacaLogin;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
    }
}