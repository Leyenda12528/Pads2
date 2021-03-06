﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using proyectoads2.Base;
using proyectoads2.Datos;

namespace proyectoads2
{
    public partial class Login : Form
    {
        private Help1 h = new Help1();
        private Consultas consulta = new Consultas();
        private Usuari usuario = new Usuari();
        public Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Length > 0 && txtUser.Text.Length > 0)
            {
                if (consulta.Exist(txtUser.Text, txtPass.Text, usuario))
                {
                    consulta.GetDatos(usuario);
                    this.Hide();
                    MenuPrincipal menu = new MenuPrincipal(usuario);
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrectos","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                }
            }
            else MessageBox.Show("Campos Vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Length > 0)
                lblUser.Hide();
            else lblUser.Show();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Length > 0)
                lblContra.Hide();
            else lblContra.Show();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (h.ValorRestringuido(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Space))
                e.Handled = true;
            else
            {
                e.Handled = false;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    btnLogin_Click(null, null);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (h.ValorRestringuido(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Space))            
                e.Handled = true;            
            else {
                e.Handled = false;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    btnLogin_Click(null, null);
            }
        }
    }
}
