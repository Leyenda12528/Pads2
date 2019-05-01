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
    public partial class Ingresar_uniforme : Form
    {
        private Consultas cons = new Consultas();
        string agg;
        public Ingresar_uniforme()
        {
            InitializeComponent();
            
            cons.listud2(estudiante);
            mostrardatos();

        }

        private void mostrardatos()
        {
            if (mostrarunif.Rows.Count>0)
            {
                DataTable dt = (DataTable)mostrarunif.DataSource;
                dt.Clear();
            }
            cons.mostraruniforme(mostrarunif);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Uniformes uniform = new Uniformes();
            uniform.Show();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            agg = estudiante.SelectedItem.ToString();
            if (agg.Length>0)
            {
                if (cons.existealumno(agg))
                {
                    int cantidadunif = cons.cantidadalumno(agg);
                    if (cantidadunif < 2)
                    {
                        cons.actualizaruniformes(agg, cantidadunif+1);
                        mostrardatos();
                    }
                    else
                    {
                        MessageBox.Show("Este alumno ya tiene el maximo de uniformes en el año");
                    }
                }
                else
                {
                    cons.nuevounif(agg,1);
                    mostrardatos();
                }
            }
        }
    }
}
