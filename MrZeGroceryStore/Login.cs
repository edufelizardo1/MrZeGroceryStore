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

        }

        private void linlblRecuperarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        //TextBos Usuário

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUÁRIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUÁRIO";
                txtUsuario.ForeColor = Color.Firebrick;
            }
        }


        //TextBox Senha

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.LightGray;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.Firebrick;
                txtSenha.UseSystemPasswordChar = false;
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
