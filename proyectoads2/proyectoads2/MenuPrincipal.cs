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
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(Usuari usuario) 
        {
            InitializeComponent();
            lblUser.Text = usuario.Usuario;
            lblCargo.Text = usuario.Cargo;
        }

        private void mostrar(object frm)
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

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            mostrar(new Menualimentos());
        }

        private void btnUniformes_Click(object sender, EventArgs e)
        {
            mostrar(new Uniformes());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            mostrar(new usuarios());
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            mostrar(new ingresaralumno());
        }

        private void btnExpandir_Click(object sender, EventArgs e)
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            PnlContenedor.Controls.Clear();
        }

        private void btnAlimentosI_Click(object sender, EventArgs e)
        {
            btnAlimentos_Click(null, null);
        }

        private void btnUniformesI_Click(object sender, EventArgs e)
        {
            btnUniformes_Click(null, null);
        }

        private void btnUsuariosI_Click(object sender, EventArgs e)
        {
            btnUsuarios_Click(null, null);
        }

        private void btnAlumnosI_Click(object sender, EventArgs e)
        {
            btnAlumnos_Click(null, null);
        }

        private void btnInicioI_Click(object sender, EventArgs e)
        {
            btnInicio_Click(null, null);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
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
