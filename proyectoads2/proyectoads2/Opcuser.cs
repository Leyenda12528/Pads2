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
    public partial class Opcuser : Form
    {
        private Usuari usuario = new Usuari();
        private Usuari secre = new Usuari();
        private Consultas consul = new Consultas();

        public Opcuser()
        {
            InitializeComponent();
        }

        public Opcuser(Usuari usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            if (usuario.Id_cargo == 1)            
                btnSecre.Hide();
        }

        private void Mostrar(object frm)
        {
            if (this.PnlContenedor.Controls.Count > 0)
                this.PnlContenedor.Controls.Clear();
            Form formu = frm as Form;
            formu.TopLevel = false;
            formu.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(formu);
            this.PnlContenedor.Tag = formu;
            formu.Show();
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            Mostrar(new Usuarios(usuario));
        }

        private void BtnSecre_Click(object sender, EventArgs e)
        {
            consul.GetDatosSecre(secre);
            Mostrar(new Usuarios(secre));
        }
    }
}
