
namespace MrZeGroceryStore
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBarraDeControleSuperior = new System.Windows.Forms.Panel();
            this.pnlLogotipo = new System.Windows.Forms.Panel();
            this.lblMercearia = new System.Windows.Forms.Label();
            this.lblSeuZe = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblStatusMenssage = new System.Windows.Forms.Label();
            this.linlblRecuperarSenha = new System.Windows.Forms.LinkLabel();
            this.PnlCadeadoFechado = new System.Windows.Forms.Panel();
            this.txtUsuario = new CustomControlsEdu.EFCControls.EFCTextBoxCustomer();
            this.txtSenha = new CustomControlsEdu.EFCControls.EFCTextBoxCustomer();
            this.btnLogin = new CustomControlsEdu.EFCControls.EFCButton();
            this.pnlBarraDeControleSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraDeControleSuperior
            // 
            this.pnlBarraDeControleSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlBarraDeControleSuperior.Controls.Add(this.pnlLogotipo);
            this.pnlBarraDeControleSuperior.Controls.Add(this.lblMercearia);
            this.pnlBarraDeControleSuperior.Controls.Add(this.lblSeuZe);
            this.pnlBarraDeControleSuperior.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarraDeControleSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraDeControleSuperior.Name = "pnlBarraDeControleSuperior";
            this.pnlBarraDeControleSuperior.Size = new System.Drawing.Size(216, 330);
            this.pnlBarraDeControleSuperior.TabIndex = 0;
            this.pnlBarraDeControleSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraDeControleSuperior_MouseDown);
            // 
            // pnlLogotipo
            // 
            this.pnlLogotipo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogotipo.BackgroundImage = global::MrZeGroceryStore.Properties.Resources.mercado;
            this.pnlLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogotipo.Location = new System.Drawing.Point(33, 88);
            this.pnlLogotipo.Name = "pnlLogotipo";
            this.pnlLogotipo.Size = new System.Drawing.Size(150, 159);
            this.pnlLogotipo.TabIndex = 0;
            // 
            // lblMercearia
            // 
            this.lblMercearia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMercearia.AutoSize = true;
            this.lblMercearia.BackColor = System.Drawing.Color.Transparent;
            this.lblMercearia.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMercearia.ForeColor = System.Drawing.Color.Silver;
            this.lblMercearia.Location = new System.Drawing.Point(43, 1);
            this.lblMercearia.Name = "lblMercearia";
            this.lblMercearia.Size = new System.Drawing.Size(130, 37);
            this.lblMercearia.TabIndex = 2;
            this.lblMercearia.Text = "Merceária ";
            this.lblMercearia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeuZe
            // 
            this.lblSeuZe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeuZe.AutoSize = true;
            this.lblSeuZe.BackColor = System.Drawing.Color.Transparent;
            this.lblSeuZe.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeuZe.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblSeuZe.Location = new System.Drawing.Point(37, 24);
            this.lblSeuZe.Name = "lblSeuZe";
            this.lblSeuZe.Size = new System.Drawing.Size(142, 43);
            this.lblSeuZe.TabIndex = 3;
            this.lblSeuZe.Text = "do Seu Zé";
            this.lblSeuZe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.Silver;
            this.lblLogin.Location = new System.Drawing.Point(349, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(186, 37);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Acessar Sistema";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::MrZeGroceryStore.Properties.Resources.fec_har;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(627, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::MrZeGroceryStore.Properties.Resources.mi_zar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Century Gothic", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Location = new System.Drawing.Point(606, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblStatusMenssage
            // 
            this.lblStatusMenssage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusMenssage.AutoSize = true;
            this.lblStatusMenssage.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusMenssage.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusMenssage.ForeColor = System.Drawing.Color.Red;
            this.lblStatusMenssage.Location = new System.Drawing.Point(249, 205);
            this.lblStatusMenssage.Name = "lblStatusMenssage";
            this.lblStatusMenssage.Size = new System.Drawing.Size(271, 28);
            this.lblStatusMenssage.TabIndex = 9;
            this.lblStatusMenssage.Text = "Status do login = Erro no acesso";
            this.lblStatusMenssage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linlblRecuperarSenha
            // 
            this.linlblRecuperarSenha.AutoSize = true;
            this.linlblRecuperarSenha.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.linlblRecuperarSenha.LinkColor = System.Drawing.Color.Snow;
            this.linlblRecuperarSenha.Location = new System.Drawing.Point(366, 297);
            this.linlblRecuperarSenha.Name = "linlblRecuperarSenha";
            this.linlblRecuperarSenha.Size = new System.Drawing.Size(142, 21);
            this.linlblRecuperarSenha.TabIndex = 12;
            this.linlblRecuperarSenha.TabStop = true;
            this.linlblRecuperarSenha.Text = "Contatar Suporte";
            this.linlblRecuperarSenha.VisitedLinkColor = System.Drawing.Color.Firebrick;
            this.linlblRecuperarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlblRecuperarSenha_LinkClicked);
            // 
            // PnlCadeadoFechado
            // 
            this.PnlCadeadoFechado.BackgroundImage = global::MrZeGroceryStore.Properties.Resources.icons8_lock_50;
            this.PnlCadeadoFechado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlCadeadoFechado.Location = new System.Drawing.Point(580, 133);
            this.PnlCadeadoFechado.Name = "PnlCadeadoFechado";
            this.PnlCadeadoFechado.Size = new System.Drawing.Size(42, 37);
            this.PnlCadeadoFechado.TabIndex = 13;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.txtUsuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtUsuario.BorderRadius = 0;
            this.txtUsuario.BorderSize = 2;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.Location = new System.Drawing.Point(253, 88);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.PlaceholderText = "USUÁRIO";
            this.txtUsuario.Size = new System.Drawing.Size(369, 36);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = true;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.txtSenha.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSenha.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtSenha.BorderRadius = 0;
            this.txtSenha.BorderSize = 2;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenha.Location = new System.Drawing.Point(253, 142);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSenha.PasswordChar = true;
            this.txtSenha.PlaceholderColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenha.PlaceholderText = "SENHA";
            this.txtSenha.Size = new System.Drawing.Size(369, 36);
            this.txtSenha.TabIndex = 15;
            this.txtSenha.Texts = "";
            this.txtSenha.UnderlinedStyle = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnLogin.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 2;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(253, 254);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(369, 40);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Autenticar";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(647, 330);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.PnlCadeadoFechado);
            this.Controls.Add(this.linlblRecuperarSenha);
            this.Controls.Add(this.lblStatusMenssage);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pnlBarraDeControleSuperior);
            this.Controls.Add(this.txtSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.pnlBarraDeControleSuperior.ResumeLayout(false);
            this.pnlBarraDeControleSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraDeControleSuperior;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMercearia;
        private System.Windows.Forms.Label lblSeuZe;
        private System.Windows.Forms.Panel pnlLogotipo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblStatusMenssage;
        private System.Windows.Forms.LinkLabel linlblRecuperarSenha;
        private System.Windows.Forms.Panel PnlCadeadoFechado;
        private CustomControlsEdu.EFCControls.EFCTextBoxCustomer txtUsuario;
        private CustomControlsEdu.EFCControls.EFCTextBoxCustomer txtSenha;
        private CustomControlsEdu.EFCControls.EFCButton btnLogin;
    }
}

