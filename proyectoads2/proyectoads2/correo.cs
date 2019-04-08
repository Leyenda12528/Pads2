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
    public partial class correo : Form
    {
        public correo()
        {
            InitializeComponent();
        }

        private void correo_Load(object sender, EventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventario inv = new inventario();
            inv.Show();
        }
    }
}
