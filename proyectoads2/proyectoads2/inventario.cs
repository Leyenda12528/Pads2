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
    public partial class Inventario : Form
    {
        private Consultas consulta = new Consultas();
        private int var1, var2, var3;
        public Inventario()
        {
            InitializeComponent();
            
            consulta.VerInventario(tabDatos);
        }

        private void tabDatos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var1 = Convert.ToInt32(tabDatos.Rows[tabDatos.CurrentRow.Index].Cells[0].Value.ToString());
                var2 = Convert.ToInt32(tabDatos.Rows[tabDatos.CurrentRow.Index].Cells[0].Value.ToString());
                var3 = Convert.ToInt32(tabDatos.Rows[tabDatos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrarI_Click(object sender, EventArgs e)
        {
            btnRegistrar_Click(null,null);
        }
    }
}
