using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoads2
{
    public partial class Uniformes : Form
    {
        public Uniformes()
        {
            InitializeComponent();
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
        /// BOTONES CON IMAGENES

        private void btnEntregarI_Click(object sender, EventArgs e)
        {
            btnEntregar_Click(null, null);
        }

        private void btnIngUniformeI_Click(object sender, EventArgs e)
        {
            btnIngUniforme_Click(null, null);
        }
        ///

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            mostrar(new Entregar_uniformes());
        }

        private void btnIngUniforme_Click(object sender, EventArgs e)
        {
            mostrar(new Ingresar_uniforme());
        }
    }
}
