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
    public partial class Form2 : Form
    {
        Conexion call = new Conexion();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            call.consulta("select * from cargo");
            MessageBox.Show("Conexion abierta");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            call.Cerrar();
            MessageBox.Show("Conexion cerrada");
        }
    }
}
