
namespace MrZeGroceryStore
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.pnlBarraSuperior = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBarraLateral = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSairSistema = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnCadastrosProdutos = new System.Windows.Forms.Button();
            this.btnRegistroVendas = new System.Windows.Forms.Button();
            this.pnlSeparadot = new System.Windows.Forms.Panel();
            this.pnlBLImageLogo = new System.Windows.Forms.Panel();
            this.lblSeuZe = new System.Windows.Forms.Label();
            this.lblMercearia = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tmContraeMenu = new System.Windows.Forms.Timer(this.components);
            this.temExpandeMenu = new System.Windows.Forms.Timer(this.components);
            this.pnlBarraSuperior.SuspendLayout();
            this.pnlBarraLateral.SuspendLayout();
            this.pnlBLImageLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarraSuperior
            // 
            this.pnlBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlBarraSuperior.Controls.Add(this.BtnMenu);
            this.pnlBarraSuperior.Controls.Add(this.btnMinimizar);
            this.pnlBarraSuperior.Controls.Add(this.btnNormal);
            this.pnlBarraSuperior.Controls.Add(this.btnMaximizar);
            this.pnlBarraSuperior.Controls.Add(this.btnClose);
            this.pnlBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraSuperior.Name = "pnlBarraSuperior";
            this.pnlBarraSuperior.Size = new System.Drawing.Size(1384, 25);
            this.pnlBarraSuperior.TabIndex = 0;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnMenu.BackgroundImage = global::MrZeGroceryStore.Properties.Resources.icons8_menu_32__1_;
            this.BtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Location = new System.Drawing.Point(3, 1);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(23, 23);
            this.BtnMenu.TabIndex = 6;
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::MrZeGroceryStore.Properties.Resources.icons8_minimize_window_32;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(1307, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 23);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnNormal.BackgroundImage = global::MrZeGroceryStore.Properties.Resources.icons8_normal_screen_32;
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Location = new System.Drawing.Point(1333, 1);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(23, 23);
            this.btnNormal.TabIndex = 2;
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.BackgroundImage = global::MrZeGroceryStore.Properties.Resources.icons8_full_screen_32;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(1334, 1);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(23, 23);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::MrZeGroceryStore.Properties.Resources.icons8_multiply_32;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1359, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlBarraLateral
            // 
            this.pnlBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlBarraLateral.Controls.Add(this.button1);
            this.pnlBarraLateral.Controls.Add(this.btnSairSistema);
            this.pnlBarraLateral.Controls.Add(this.btnUsuario);
            this.pnlBarraLateral.Controls.Add(this.btnCadastroCliente);
            this.pnlBarraLateral.Controls.Add(this.btnCadastrosProdutos);
            this.pnlBarraLateral.Controls.Add(this.btnRegistroVendas);
            this.pnlBarraLateral.Controls.Add(this.pnlSeparadot);
            this.pnlBarraLateral.Controls.Add(this.pnlBLImageLogo);
            this.pnlBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarraLateral.Location = new System.Drawing.Point(0, 25);
            this.pnlBarraLateral.Name = "pnlBarraLateral";
            this.pnlBarraLateral.Size = new System.Drawing.Size(250, 736);
            this.pnlBarraLateral.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Voltar para o Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSairSistema
            // 
            this.btnSairSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSairSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSairSistema.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSairSistema.FlatAppearance.BorderSize = 0;
            this.btnSairSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairSistema.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSairSistema.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSairSistema.Image = global::MrZeGroceryStore.Properties.Resources.icons8_logout_rounded_down_32;
            this.btnSairSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairSistema.Location = new System.Drawing.Point(0, 667);
            this.btnSairSistema.Name = "btnSairSistema";
            this.btnSairSistema.Size = new System.Drawing.Size(250, 69);
            this.btnSairSistema.TabIndex = 8;
            this.btnSairSistema.Text = "Sair";
            this.btnSairSistema.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.btnUsuario.Image = global::MrZeGroceryStore.Properties.Resources.icons8_add_user_male_32__1_;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(0, 366);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(250, 69);
            this.btnUsuario.TabIndex = 7;
            this.btnUsuario.Text = "Usuários";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnCadastroCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastroCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCadastroCliente.Image = global::MrZeGroceryStore.Properties.Resources.icons8_add_list_32;
            this.btnCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.Location = new System.Drawing.Point(0, 297);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(250, 69);
            this.btnCadastroCliente.TabIndex = 5;
            this.btnCadastroCliente.Text = "Cadastro de Clientes";
            this.btnCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnCadastrosProdutos
            // 
            this.btnCadastrosProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnCadastrosProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrosProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrosProdutos.FlatAppearance.BorderSize = 0;
            this.btnCadastrosProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrosProdutos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrosProdutos.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCadastrosProdutos.Image = global::MrZeGroceryStore.Properties.Resources.icons8_new_product_32;
            this.btnCadastrosProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrosProdutos.Location = new System.Drawing.Point(0, 228);
            this.btnCadastrosProdutos.Name = "btnCadastrosProdutos";
            this.btnCadastrosProdutos.Size = new System.Drawing.Size(250, 69);
            this.btnCadastrosProdutos.TabIndex = 4;
            this.btnCadastrosProdutos.Text = "Cadastro de Produtos";
            this.btnCadastrosProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrosProdutos.UseVisualStyleBackColor = false;
            this.btnCadastrosProdutos.Click += new System.EventHandler(this.btnCadastrosProdutos_Click);
            // 
            // btnRegistroVendas
            // 
            this.btnRegistroVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnRegistroVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistroVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistroVendas.FlatAppearance.BorderSize = 0;
            this.btnRegistroVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroVendas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistroVendas.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRegistroVendas.Image = global::MrZeGroceryStore.Properties.Resources.icons8_buy_32;
            this.btnRegistroVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroVendas.Location = new System.Drawing.Point(0, 159);
            this.btnRegistroVendas.Name = "btnRegistroVendas";
            this.btnRegistroVendas.Size = new System.Drawing.Size(250, 69);
            this.btnRegistroVendas.TabIndex = 2;
            this.btnRegistroVendas.Text = "Registrar Vendas";
            this.btnRegistroVendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroVendas.UseVisualStyleBackColor = false;
            this.btnRegistroVendas.Click += new System.EventHandler(this.btnRegistroVendas_Click);
            // 
            // pnlSeparadot
            // 
            this.pnlSeparadot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlSeparadot.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparadot.Location = new System.Drawing.Point(0, 131);
            this.pnlSeparadot.Name = "pnlSeparadot";
            this.pnlSeparadot.Size = new System.Drawing.Size(250, 28);
            this.pnlSeparadot.TabIndex = 2;
            // 
            // pnlBLImageLogo
            // 
            this.pnlBLImageLogo.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlBLImageLogo.Controls.Add(this.lblSeuZe);
            this.pnlBLImageLogo.Controls.Add(this.lblMercearia);
            this.pnlBLImageLogo.Controls.Add(this.pnlLogo);
            this.pnlBLImageLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBLImageLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlBLImageLogo.Name = "pnlBLImageLogo";
            this.pnlBLImageLogo.Size = new System.Drawing.Size(250, 131);
            this.pnlBLImageLogo.TabIndex = 2;
            // 
            // lblSeuZe
            // 
            this.lblSeuZe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeuZe.AutoSize = true;
            this.lblSeuZe.BackColor = System.Drawing.Color.Transparent;
            this.lblSeuZe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSeuZe.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeuZe.ForeColor = System.Drawing.Color.Black;
            this.lblSeuZe.Location = new System.Drawing.Point(129, 60);
            this.lblSeuZe.Name = "lblSeuZe";
            this.lblSeuZe.Size = new System.Drawing.Size(114, 33);
            this.lblSeuZe.TabIndex = 5;
            this.lblSeuZe.Text = "do Seu Zé";
            this.lblSeuZe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMercearia
            // 
            this.lblMercearia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMercearia.AutoSize = true;
            this.lblMercearia.BackColor = System.Drawing.Color.Transparent;
            this.lblMercearia.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMercearia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblMercearia.Location = new System.Drawing.Point(129, 30);
            this.lblMercearia.Name = "lblMercearia";
            this.lblMercearia.Size = new System.Drawing.Size(118, 33);
            this.lblMercearia.TabIndex = 4;
            this.lblMercearia.Text = "Merceária ";
            this.lblMercearia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::MrZeGroceryStore.Properties.Resources.mercado;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(125, 131);
            this.pnlLogo.TabIndex = 2;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Silver;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(250, 25);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1134, 736);
            this.pnlContainer.TabIndex = 2;
            // 
            // tmContraeMenu
            // 
            this.tmContraeMenu.Interval = 5;
            this.tmContraeMenu.Tick += new System.EventHandler(this.tmContraeMenu_Tick);
            // 
            // temExpandeMenu
            // 
            this.temExpandeMenu.Interval = 5;
            this.temExpandeMenu.Tick += new System.EventHandler(this.temExpandeMenu_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlBarraLateral);
            this.Controls.Add(this.pnlBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.pnlBarraSuperior.ResumeLayout(false);
            this.pnlBarraLateral.ResumeLayout(false);
            this.pnlBLImageLogo.ResumeLayout(false);
            this.pnlBLImageLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraSuperior;
        private System.Windows.Forms.Panel pnlBarraLateral;
        private System.Windows.Forms.Panel pnlBLImageLogo;
        private System.Windows.Forms.Button btnRegistroVendas;
        private System.Windows.Forms.Panel pnlSeparadot;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnCadastrosProdutos;
        private System.Windows.Forms.Button btnSairSistema;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMercearia;
        private System.Windows.Forms.Label lblSeuZe;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Timer tmContraeMenu;
        private System.Windows.Forms.Timer temExpandeMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button button1;
    }
}