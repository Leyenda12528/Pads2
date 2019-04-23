using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoads2.Base;
using proyectoads2.Datos;

namespace proyectoads2
{
    public partial class Usuarios : Form
    {
        private Usuari usuario = new Usuari();
        private Consultas consul = new Consultas();

        public Usuarios()
        {
            InitializeComponent();
        }

        public Usuarios(Usuari usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            lblCargo.Text = usuario.Cargo;
            txtUser.Text = usuario.Usuario;
            txtContra.Text = usuario.Contra;
            if (usuario.Id_cargo == 0)
            {
                txtCorreo.Text = usuario.Correo;
                txtContra2.Text = usuario.Contracorreo;
                txtCorreo2.Text = usuario.Correo_destino;
            }
            else pnl.Hide();
        }

        private void BtnAceptarI_Click(object sender, EventArgs e)
        {
            BtnAceptar_Click(null, null);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContra.Text.Trim().Length > 0)
            {
                if (usuario.Id_cargo == 0)
                {
                    if (txtCorreo.Text.Trim().Length > 0 && txtContra2.Text.Trim().Length > 0 && txtCorreo2.Text.Trim().Length > 0)
                    {
                        PasarDatos();
                        consul.UpdateUser(usuario);
                    }
                    else MessageBox.Show("Llene todos los campos", "ERROR");
                }
                else
                {
                    PasarDatos();
                    consul.UpdateUser(usuario);
                }
            }
            else MessageBox.Show("Campos vacios, debe ingresarlos", "ERROR");
        }

        private void PasarDatos()
        {
            usuario.Contra = txtContra.Text;
            usuario.Correo = txtCorreo.Text;
            usuario.Contracorreo = txtContra2.Text;
            usuario.Correo_destino = txtCorreo2.Text;
        }
        
    }
}
