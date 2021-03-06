using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MrZeGroceryStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            lblStatusMenssage.Visible = false;
            PnlCadeadoFechado.Visible = true;
        }

        //  Arrastar o formulário

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
            int wparam, int lparam);

        //  Botão para minimizar o Form

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //  Botão para fechar o form

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        //  Botão de Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
            this.Hide();
        }


        private void linlblRecuperarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        //TextBos Usuário

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.PlaceholderText == "USUÁRIO")
            {
                txtUsuario.PlaceholderText = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.PlaceholderText == "")
            {
                txtUsuario.PlaceholderText = "USUÁRIO";
                txtUsuario.ForeColor = Color.Firebrick;
            }
        }


        //TextBox Senha

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.PlaceholderText == "SENHA")
            {
                txtSenha.PlaceholderText = "";
                txtSenha.ForeColor = Color.LightGray;
                txtSenha.PasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.PlaceholderText == "")
            {
                txtSenha.PlaceholderText = "SENHA";
                txtSenha.ForeColor = Color.Firebrick;
                txtSenha.PasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlBarraDeControleSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
