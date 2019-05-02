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
        private int Id_Inv, Id_Alimento, Cantidad;
        public Inventario()
        {
            InitializeComponent();
            MostrarInventario();
        }

        private void MostrarInventario()
        {
            if (DGVDatos.Rows.Count > 0)
            {
                DataTable dt = (DataTable)DGVDatos.DataSource;
                dt.Clear();
            }
            consulta.VerInventario(DGVDatos);
        }

        private void BtnRegistrarI_Click(object sender, EventArgs e)
        {
            BtnRegistrar_Click(null, null);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea Pasar a Vencidos el Inventario con ID: " + Id_Inv + " ?", "Pasar a Vencidos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                int Cantidad_V = consulta.CantVencido(Id_Alimento);
                Cantidad_V = Cantidad_V + Cantidad;
                consulta.UpdateVenci(Id_Alimento, Cantidad_V);
                consulta.UpdateInventarioToVenci(Id_Inv);
                MessageBox.Show("Inventario actualizado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarInventario();
            }            
        }

        private void TabDatos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Id_Inv = Convert.ToInt32(DGVDatos.Rows[DGVDatos.CurrentRow.Index].Cells[0].Value.ToString());
                Id_Alimento = Alimento(DGVDatos.Rows[DGVDatos.CurrentRow.Index].Cells[2].Value.ToString());
                Cantidad = Convert.ToInt32(DGVDatos.Rows[DGVDatos.CurrentRow.Index].Cells[3].Value.ToString());
            }
            catch (Exception)
            {                
            }
        }

        private int Alimento(String v)
        {
            int valor = 0;
            switch (v)
            {
                case "Arroz":
                    valor = 0;
                    break;
                case "Frijol":
                    valor = 1;
                    break;
                case "Aceite":
                    valor = 2;
                    break;
                case "Leche":
                    valor = 3;
                    break;
                case "Bebida Fortificada":
                    valor = 4;
                    break;
            }
            return valor;
        }
    }
}
