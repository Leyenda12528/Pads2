using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoads2.Datos;

namespace proyectoads2
{
    public partial class MenuPrincipal : Form
    {
        private int van = 0;
        private Usuari usuario = new Usuari();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(Usuari usuario) 
        {
            InitializeComponent();
            lblUser.Text = usuario.Usuario;
            lblCargo.Text = usuario.Cargo;
            this.usuario = usuario;
            if (usuario.Id_cargo == 1)
                pnlCorreo.Hide();
            
        }

        private void Mostrar(object frm)
        {
            if (this.PnlContenedor.Controls.Count > 0)
                this.PnlContenedor.Controls.RemoveAt(0);
            Form formu = frm as Form;
            formu.TopLevel = false;
            formu.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(formu);
            this.PnlContenedor.Tag = formu;
            formu.Show();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnAlimentos_Click(object sender, EventArgs e)
        {
            Mostrar(new Menualimentos());
        }

        private void BtnUniformes_Click(object sender, EventArgs e)
        {
            Mostrar(new Uniformes());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            Mostrar(new Opcuser(usuario));
        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            Mostrar(new ingresaralumno());
        }

        private void BtnCorreo_Click(object sender, EventArgs e)
        {
            Mostrar(new Correo(usuario));
        }

        private void BtnExpandir_Click(object sender, EventArgs e)
        {
            if (van == 0)
            {
                pnlMenu.Size = new Size(38, pnlMenu.Size.Height);
                van = 1;
            }
            else
            {
                pnlMenu.Size = new Size(161, pnlMenu.Size.Height);
                van = 0;
            }
        }
        private void BtnCorreoI_Click(object sender, EventArgs e)
        {
            BtnCorreo_Click(null, null);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            PnlContenedor.Controls.Clear();
        }

        private void BtnAlimentosI_Click(object sender, EventArgs e)
        {
            BtnAlimentos_Click(null, null);
        }

        private void BtnUniformesI_Click(object sender, EventArgs e)
        {
            BtnUniformes_Click(null, null);
        }

        private void BtnUsuariosI_Click(object sender, EventArgs e)
        {
            BtnUsuarios_Click(null, null);
        }

        private void BtnAlumnosI_Click(object sender, EventArgs e)
        {
            BtnAlumnos_Click(null, null);
        }

        private void BtnInicioI_Click(object sender, EventArgs e)
        {
            BtnInicio_Click(null, null);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {            
            Login call = new Login();
            call.Show();
            this.Dispose();
            //Application.Exit();
        }

        private int posX = 0, posY = 0;              

        private void PnlBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }

        }
    }
}
