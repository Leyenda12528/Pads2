using proyectoads2.Base;
using proyectoads2.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoads2
{

    public partial class Ingreso_pedido : Form
    {
        private string FechaActual;
        private Help1 h = new Help1();
        public Ingreso_pedido()
        {
            InitializeComponent();
        }

        private void BtnRegistrarI_Click(object sender, EventArgs e)
        {
            BtnRegistrar_Click(null,null);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCArroz.Text.Length > 0 && txtCFrijol.Text.Length > 0 && txtCLeche.Text.Length > 0 && txtCAceite.Text.Length > 0 && txtCBebida.Text.Length > 0)
            {
                if (txtFarroz.Text.Length > 0 && txtFfrijol.Text.Length > 0 && txtFaceite.Text.Length > 0 && txtFleche.Text.Length > 0 && txtFbebida.Text.Length > 0)
                {
                    if (h.ExitsFecha(txtFarroz.Text) && h.DateMaxNow(txtFarroz.Text))
                    {
                        if (h.ExitsFecha(txtFfrijol.Text) && h.DateMaxNow(txtFfrijol.Text))
                        {
                            if (h.ExitsFecha(txtFaceite.Text) && h.DateMaxNow(txtFaceite.Text))
                            {
                                if (h.ExitsFecha(txtFleche.Text) && h.DateMaxNow(txtFleche.Text))
                                {
                                    if (h.ExitsFecha(txtFbebida.Text) && h.DateMaxNow(txtFbebida.Text))
                                    {
                                        Consultas cons = new Consultas();
                                        List<Inventario> ListInventario = new List<Inventario>();
                                        int v = cons.GetLastIDInv();
                                        FechaActual = Convert.ToDateTime(DateTime.Now).ToString("dd/MM/yyyy");
                                        int bandera = 4;
                                        int d = 0;
                                        Inventario invent = null;
                                        foreach (Control item in alimentospanel.Controls)
                                        {
                                            if (d == 0)
                                            {
                                                invent = new Inventario();
                                                invent.Id_inventario = v;
                                                invent.Id_alimento = bandera;
                                                invent.Fecha_ingreso = FechaActual;
                                                bandera--;
                                                v++;
                                                invent.Fecha_vencimiento = item.Text;
                                                d++;
                                            }
                                            else
                                            {
                                                invent.Cantidad = Convert.ToInt32(item.Text);
                                                ListInventario.Add(invent);
                                                d = 0;
                                            }

                                        }
                                        //probar(ListInventario);
                                        cons.AddInventario(ListInventario);
                                        Limpiar();
                                    }
                                    else
                                        MessageBox.Show("Fecha Vencimiento de Bebida invalida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                    MessageBox.Show("Fecha Vencimiento de Leche invalida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Fecha Vencimiento de Aceite invalida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Fecha Vencimiento de Frijol invalida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Fecha Vencimiento de Arroz invalida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Tiene que llenar todos los campos de Fecha", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Tiene que llenar todos los campos de Cantidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            foreach (TextBox item in alimentospanel.Controls)
            {
                item.Clear();
            }
        }
        //probar(ListInventario);30/02/2019
        //private void probar(List<Inventario> listInventario)
        //{
        //    foreach (Inventario item in listInventario)
        //    {
        //        MessageBox.Show("ID " + item.Id_inventario + "\n Id Ali " + item.Id_alimento + "\n Id cat" + item.Cantidad + "\n" + item.Fecha_ingreso + "\n" + item.Fecha_vencimiento);
        //    }
        //}

        private void TxtCArroz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
               e.Handled = false;
           else           
               e.Handled = true;
        }

        private void TxtCFrijol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TxtCAceite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TxtCLeche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void TxtCBebida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
