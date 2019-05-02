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
            
            cons.Listud2(estudiante);
            mostrardatos();

        }

        private void mostrardatos()
        {
            if (mostrarunif.Rows.Count>0)
            {
                DataTable dt = (DataTable)mostrarunif.DataSource;
                dt.Clear();
            }
            cons.Mostraruniforme(mostrarunif);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Uniformes uniform = new Uniformes();
            uniform.Show();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                agg = estudiante.SelectedItem.ToString();
                if (cons.Existealumno(agg))
                {
                    int cantidadunif = cons.Cantidadalumno(agg);
                    if (cantidadunif < 2)
                    {
                        cons.Actualizaruniformes(agg, cantidadunif + 1);
                        mostrardatos();
                    }
                    else
                        MessageBox.Show("Este alumno ya tiene el máximo de uniformes en el año", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cons.Nuevounif(agg, 1);
                    mostrardatos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Elija un estudiante primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                        
        }

        private void BtnEntregarI_Click(object sender, EventArgs e)
        {
            Agregar_Click(null, null);
        }
    }
}
