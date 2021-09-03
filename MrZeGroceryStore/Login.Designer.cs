
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblStatusMenssage = new System.Windows.Forms.Label();
            this.pnlLInha1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linlblRecuperarSenha = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBarraDeControleSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraDeControleSuperior
            // 
            this.pnlBarraDeControleSuperior.BackColor = System.Drawing.Color.Gold;
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
            this.pnlLogotipo.BackgroundImage = global::MrZeGroceryStore.Properties.Resources.mercado_;
            this.pnlLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogotipo.Location = new System.Drawing.Point(3, 88);
            this.pnlLogotipo.Name = "pnlLogotipo";
            this.pnlLogotipo.Size = new System.Drawing.Size(210, 230);
            this.pnlLogotipo.TabIndex = 0;
            // 
            // lblMercearia
            // 
            this.lblMercearia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMercearia.AutoSize = true;
            this.lblMercearia.BackColor = System.Drawing.Color.Transparent;
            this.lblMercearia.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMercearia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
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
            this.lblSeuZe.ForeColor = System.Drawing.Color.Black;
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
            this.lblLogin.ForeColor = System.Drawing.Color.Snow;
            this.lblLogin.Location = new System.Drawing.Point(308, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(251, 37);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "ACESSO AO SISTEMA";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gold;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnLogin.Location = new System.Drawing.Point(249, 257);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(369, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Autenticar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.Color.Snow;
            this.txtUsuario.Location = new System.Drawing.Point(251, 88);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(367, 20);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.Text = "USUÁRIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.ForeColor = System.Drawing.Color.Snow;
            this.txtSenha.Location = new System.Drawing.Point(251, 150);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(367, 20);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.Text = "SENHA";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
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
            this.lblStatusMenssage.ForeColor = System.Drawing.Color.Brown;
            this.lblStatusMenssage.Location = new System.Drawing.Point(249, 205);
            this.lblStatusMenssage.Name = "lblStatusMenssage";
            this.lblStatusMenssage.Size = new System.Drawing.Size(133, 28);
            this.lblStatusMenssage.TabIndex = 9;
            this.lblStatusMenssage.Text = "Status do login";
            this.lblStatusMenssage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLInha1
            // 
            this.pnlLInha1.BackColor = System.Drawing.Color.Gold;
            this.pnlLInha1.Location = new System.Drawing.Point(251, 114);
            this.pnlLInha1.Name = "pnlLInha1";
            this.pnlLInha1.Size = new System.Drawing.Size(367, 2);
            this.pnlLInha1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(253, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 2);
            this.panel1.TabIndex = 11;
            // 
            // linlblRecuperarSenha
            // 
            this.linlblRecuperarSenha.AutoSize = true;
            this.linlblRecuperarSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linlblRecuperarSenha.LinkColor = System.Drawing.Color.Snow;
            this.linlblRecuperarSenha.Location = new System.Drawing.Point(358, 297);
            this.linlblRecuperarSenha.Name = "linlblRecuperarSenha";
            this.linlblRecuperarSenha.Size = new System.Drawing.Size(150, 20);
            this.linlblRecuperarSenha.TabIndex = 12;
            this.linlblRecuperarSenha.TabStop = true;
            this.linlblRecuperarSenha.Text = "Recuperar a Senha";
            this.linlblRecuperarSenha.VisitedLinkColor = System.Drawing.Color.Firebrick;
            this.linlblRecuperarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlblRecuperarSenha_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MrZeGroceryStore.Properties.Resources.icons8_lock_32;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(580, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 37);
            this.panel2.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(647, 330);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.linlblRecuperarSenha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLInha1);
            this.Controls.Add(this.lblStatusMenssage);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pnlBarraDeControleSuperior);
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
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel pnlLogotipo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblStatusMenssage;
        private System.Windows.Forms.Panel pnlLInha1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linlblRecuperarSenha;
        private System.Windows.Forms.Panel panel2;
    }
}

