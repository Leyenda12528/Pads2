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
            cons.listud(estudiante);
            mostrardatos();
        }
        private void mostrardatos()
        {
            if (dtguniformes.Rows.Count > 0)
            {
                DataTable dt = (DataTable)dtguniformes.DataSource;
                dt.Clear();
            }
            cons.mostraruniforme(dtguniformes);
        }

        private void btnEntregarI_Click(object sender, EventArgs e)
        {
            btnEntregar_Click(null, null);
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            agg = estudiante.SelectedItem.ToString();
            if (agg.Length > 0)
            {
                int cantidadunif = cons.cantidadalumno(agg);
                if (cantidadunif > 0)
                {
                    cantidadunif--;
                    cons.actualizaruniformes(agg, cantidadunif);
                    mostrardatos();
                    MessageBox.Show("Uniforme entregado");
                }
                else
                {
                    MessageBox.Show("Este alumno no tiene uniformes que recibir");
                }
            }
                
        }
    }
}
