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
    public partial class ingresaralumno : Form
    {
        private Consultas consul = new Consultas();
        private String IDselect;
        public ingresaralumno()
        {
            InitializeComponent();            
            consul.SeeAlumnos(DGVAlumnos);            
        }

        private void mostrarAlumnos()
        {            
            DataTable dt = (DataTable)DGVAlumnos.DataSource;
            dt.Clear();
            consul.SeeAlumnos(DGVAlumnos);            
        }

        /// BOTONES CON IMAGENES
        private void btnBajaI_Click(object sender, EventArgs e)
        {
            btnBaja_Click(null,null);
        }

        private void btnIngresarI_Click(object sender, EventArgs e)
        {
            btnIngresar_Click(null, null);
        }
        ///

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length > 0 && txtNombre.Text.Length > 0)
            {
                if (consul.ExitsAlumno(txtID.Text) == false)
                {
                    consul.AddAlumno(txtID.Text, txtNombre.Text);
                    txtID.Clear();
                    txtNombre.Clear();
                    mostrarAlumnos();
                }
                else MessageBox.Show("ERROR\n\nYa existe un Alumno con ese ID ");
            }
            else MessageBox.Show("ERROR\n\nCampos Vacios");
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (IDselect.Length > 0)
            {
                if (MessageBox.Show("Desea dar de baja al Alumno con ID: " + IDselect, "Dar de Baja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    consul.BajarAlumno(IDselect);
                    mostrarAlumnos();
                }
            }
            else MessageBox.Show("Seleccione un Alumno");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DGVAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                IDselect = DGVAlumnos.Rows[DGVAlumnos.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
