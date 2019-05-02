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
    public partial class Menualimentos : Form
    {
        public Menualimentos()
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

        private void btnPlanMenuI_Click(object sender, EventArgs e)
        {
            btnPlanMenu_Click(null,null);
        }

        private void btnVencidosI_Click(object sender, EventArgs e)
        {
            btnVencidos_Click(null, null);
        }

        private void btnMenuSemanalI_Click(object sender, EventArgs e)
        {
            btnMenuSemanal_Click(null, null);
        }

        private void btnIngPedidoI_Click(object sender, EventArgs e)
        {
            btnIngPedido_Click(null, null);
        }

        private void btnVerInventarioI_Click(object sender, EventArgs e)
        {
            btnVerInventario_Click(null, null);
        }
        /////

        private void btnPlanMenu_Click(object sender, EventArgs e)
        {
            mostrar(new PlanificacionMenu());
        }

        private void btnVencidos_Click(object sender, EventArgs e)
        {
            mostrar(new vencidos());
        }

        private void btnMenuSemanal_Click(object sender, EventArgs e)
        {
            mostrar(new menu_semanal());
        }

        private void btnIngPedido_Click(object sender, EventArgs e)
        {
            mostrar(new Ingreso_pedido());
        }

        private void btnVerInventario_Click(object sender, EventArgs e)
        {
            mostrar(new Inventario());
        }
    }
}
