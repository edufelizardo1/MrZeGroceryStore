using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
