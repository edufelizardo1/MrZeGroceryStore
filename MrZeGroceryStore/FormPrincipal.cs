using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MrZeGroceryStore
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            btnNormal.Visible = false;
        }

        //  Controle dos forms

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if(btnMaximizar.Visible == true)
            {
                btnMaximizar.Visible = false;
                btnNormal.Visible = true;
            } else
            {
                btnMaximizar.Visible = true;
                btnNormal.Visible = false;
            }
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if (btnNormal.Visible == true)
            {
                btnNormal.Visible = false;
                btnMaximizar.Visible = true;
            }
            else
            {
                btnNormal.Visible = true;
                btnMaximizar.Visible = false;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //  Abrir formulario filho em painel principal.

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form form;
            form = pnlContainer.Controls.OfType<MiForm>().FirstOrDefault(); // Busca na coleção de formulários

            //  Se a instancia não existe

            if (form == null)
            {
                form = new MiForm();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(form);
                pnlContainer.Tag = form;
                form.Show();
                form.BringToFront();
            }// Se a instância existe
            else
            {
                form.BringToFront();
            }
        }


        //  Chamar form Filho

        private void btnRegistroVendas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormsAplication.FormRegistrarVenda>();
        }

        private void btnCadastrosProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormsAplication.FormRegistrarVenda>();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormsAplication.FormRegistrarVenda>();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormsAplication.FormCadastroUsuario>();
        }

        //  Animação do menu

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            // Com efeito SLINDING

            //-------CON EFECTO SLIDING
            if (pnlBarraLateral.Width == 250)
            {
                this.tmContraeMenu.Start();
                btnRegistroVendas.Text = "";
                btnCadastroCliente.Text = "";
                btnCadastrosProdutos.Text = "";
                btnUsuario.Text = "";
                btnSairSistema.Text = "";
                pnlLogo.Dock = DockStyle.None;
                pnlLogo.Width = 55;
                pnlLogo.Height = 55;
                pnlLogo.Anchor = AnchorStyles.Top;
                pnlLogo.Anchor = AnchorStyles.Left;
                pnlLogo.AutoScroll= true;
            }
            else if (pnlBarraLateral.Width == 55)
            {
                this.temExpandeMenu.Start();
                btnRegistroVendas.Text = "Registrar Vendas";
                btnCadastroCliente.Text = "Cadastro de Clientes";
                btnCadastrosProdutos.Text = "Cadastro de Produto";
                btnUsuario.Text = "Usuários";
                btnSairSistema.Text = "Sair";
                pnlLogo.Dock = DockStyle.Left;
                pnlLogo.Width = 125;
                pnlLogo.Height = 131;
            }
        }

        private void tmContraeMenu_Tick(object sender, EventArgs e)
        {
            if (pnlBarraLateral.Width <= 55)
                this.tmContraeMenu.Stop();
            else
                pnlBarraLateral.Width = pnlBarraLateral.Width - 5;
        }

        private void temExpandeMenu_Tick(object sender, EventArgs e)
        {
            if (pnlBarraLateral.Width >= 250)
                this.temExpandeMenu.Stop();
            else
                pnlBarraLateral.Width = pnlBarraLateral.Width + 5;
        }


        //  Temporario apagar
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }

    }
}
