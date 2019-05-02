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
    public partial class Entregar_uniformes : Form
    {
        private Consultas cons = new Consultas();
        string agg;
        public Entregar_uniformes()
        {
            InitializeComponent();
            cons.Listud(estudiante);
            mostrardatos();
        }
        private void mostrardatos()
        {
            if (dtguniformes.Rows.Count > 0)
            {
                DataTable dt = (DataTable)dtguniformes.DataSource;
                dt.Clear();
            }
            cons.Mostraruniforme(dtguniformes);
        }

        private void btnEntregarI_Click(object sender, EventArgs e)
        {
            btnEntregar_Click(null, null);
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {            
            try
            {
                agg = estudiante.SelectedItem.ToString();
                int cantidadunif = cons.Cantidadalumno(agg);
                if (cantidadunif > 0)
                {
                    cantidadunif--;
                    cons.Actualizaruniformes(agg, cantidadunif);
                    mostrardatos();
                    MessageBox.Show("Uniforme entregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Este alumno no tiene uniformes que recibir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Elija un estudiante primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
