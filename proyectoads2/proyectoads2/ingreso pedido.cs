using proyectoads2.Base;
using proyectoads2.Datos;
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

    public partial class ingreso_pedido : Form
    {
        string txtFecha;
        public ingreso_pedido()
        {
            InitializeComponent();
        }

        private void btnRegistrarI_Click(object sender, EventArgs e)
        {
            btnRegistrar_Click(null,null);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (carroz.Text != null && cfrijol.Text != null && cleche.Text != null && caceite.Text != null && cbebida.Text != null)
            {
                Consultas cons = new Consultas();
                List<Inventario> ListInventario = new List<Inventario>();
                int v = cons.getLastIDInv();
                //cons.agregarinventario();
                txtFecha = Convert.ToDateTime(DateTime.Now).ToString("dd/MM/yyyy");
                //MessageBox.Show(txtFecha);
                int bandera = 4;

                foreach (Control item in alimentospanel.Controls)
                {
                    Inventario invent = new Inventario();
                    invent.Fecha_vencimiento = item.Text;
                    invent.Cantidad = Convert.ToInt32(item.Text);
                    invent.Id_alimento = bandera;
                    invent.Fecha_ingreso = txtFecha;
                    invent.Id_inventario = v;
                    ListInventario.Add(invent);
                    bandera--;
                    v++;
                    
                }
                cons.AddInventario(ListInventario);
            }
            else
                MessageBox.Show("Tiene que llenar todos los campos");
        }

        
         /*if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
            {
                e.Handled = true;
                
            }*/
    
    }
}
