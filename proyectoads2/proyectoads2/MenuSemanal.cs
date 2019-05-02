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
    public partial class menu_semanal : Form
    {
        private Consultas consuls = new Consultas();        
        private List<Semanal> Semana = new List<Semanal>();
        private List<Semanal> SemanaUpdate = new List<Semanal>();
        private int CantPlani = 0, CantInv = 0;

        public menu_semanal()
        {
            InitializeComponent();
        }

        private void BtnLunes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea descartar la Planificación del día Lunes ?", "Descartar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Descartar(0, "lunes");
                Descartar(1, "lunes");
                Descartar(2, "lunes");
                Descartar(3, "lunes");
                Descartar(4, "lunes");
                MessageBox.Show("Día Lunes Descartado ", "Great!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
        private void BtnMartes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea descartar la Planificación del día Martes ?", "Descartar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Descartar(0, "martes");
                Descartar(1, "martes");
                Descartar(2, "martes");
                Descartar(3, "martes");
                Descartar(4, "martes");
                MessageBox.Show("Día Martes Descartado ", "Great!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void BtnMiercoles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea descartar la Planificación del día Miércoles ?", "Descartar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Descartar(0, "miercoles");
                Descartar(1, "miercoles");
                Descartar(2, "miercoles");
                Descartar(3, "miercoles");
                Descartar(4, "miercoles");
                MessageBox.Show("Día Miércoles Descartado ", "Great!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void BtnJueves_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea descartar la Planificación del día Jueves ?", "Descartar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Descartar(0, "jueves");
                Descartar(1, "jueves");
                Descartar(2, "jueves");
                Descartar(3, "jueves");
                Descartar(4, "jueves");
                MessageBox.Show("Día Jueves Descartado  ", "Great!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void BtnViernes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea descartar la Planificación del día Viernes ?", "Descartar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Descartar(0, "viernes");
                Descartar(1, "viernes");
                Descartar(2, "viernes");
                Descartar(3, "viernes");
                Descartar(4, "viernes");
                MessageBox.Show("Día Viernes Descartado ", "Great!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void Descartar(int id_alimento, string Dia)
        {
            Semana.Clear();
            SemanaUpdate.Clear();
            CantInv = 0;
            CantPlani = consuls.CantDia(id_alimento, Dia);//Cantidad de Planificacion
            if (CantPlani > 0)
            {                
                consuls.CantInv(Semana, id_alimento);//Cantidad de Inventario
                foreach (Semanal item in Semana)                
                    CantInv = CantInv + item.Cantidad;
                if (CantInv >= CantPlani)
                {
                    foreach (Semanal item in Semana)
                    {
                        int San = item.Cantidad;
                        if (San <= CantPlani)
                        {
                            CantPlani = CantPlani - San;
                            San = 0;                            
                        }
                        else
                        {
                            San = San - CantPlani;
                            CantPlani = 0;
                        }
                        Semanal data = new Semanal();
                        data.ID_Inventario = item.ID_Inventario;
                        data.ID_Alimento = item.ID_Alimento;
                        data.Cantidad = San;
                        SemanaUpdate.Add(data);
                        if (CantPlani == 0) break;
                    }
                    foreach (Semanal item in SemanaUpdate)
                    {
                        MessageBox.Show("idInv " + item.ID_Inventario + "\nIdAlimento " + item.ID_Alimento + "\nCant " + item.Cantidad + "\nCantidad Plani " + CantPlani);
                    }
                    consuls.UpdatePlanificacionDia(Dia, CantPlani, id_alimento);
                    consuls.UpdateInventarioPlanificacion(SemanaUpdate);
                    MessageBox.Show("Descartado\n\nDia: " + Dia + " \n Alimento: " + Gdia(id_alimento), "Great!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("La cantidad de Planificación es mayor a la que hay en Inventario\n\nDel dia: " + Dia + " \n Alimento: " + Gdia(id_alimento), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("La cantidad de Planificación es de 0\n\nDia: " + Dia + " \n Alimento: " + Gdia(id_alimento), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }        

        private string Gdia(int id_alimento)
        {
            String ali = "";
            switch (id_alimento)
            {
                case 0:
                    ali = "Arroz";
                    break;
                case 1:
                    ali = "Frijol";
                    break;
                case 2:
                    ali = "Aceite";
                    break;
                case 3:
                    ali = "Leche";
                    break;
                case 4:
                    ali = "Bebida Fortificada";
                    break;
            }
            return ali;
        }
    }
}
