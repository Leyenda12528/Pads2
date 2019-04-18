using proyectoads2.Base;
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
    public partial class vencidos : Form
    {
        private Consultas consul = new Consultas();
        public vencidos()
        {
            InitializeComponent();
            consul.verVendidos(DGVencidos);
        }

        private void btnBorrarI_Click(object sender, EventArgs e)
        {
            btnBorrar_Click(null, null);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            consul.eliminarVencidos();
        }
    }
}
