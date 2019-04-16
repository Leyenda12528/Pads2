using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoads2.Datos
{
    public class Inventario
    {
        private int id_inventario;
        private int id_alimento;
        private int cantidad_alimento;
        private string fecha_ingreso;
        private string fecha_vencimiento;

        public string Fecha_vencimiento
        {
            get { return fecha_vencimiento; }
            set { fecha_vencimiento = value; }
        }


        public string Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }


        public int Cantidad
        {
            get { return cantidad_alimento; }
            set { cantidad_alimento = value; }
        }


        public int Id_alimento
        {
            get { return id_alimento; }
            set { id_alimento = value; }
        }


        public int Id_inventario
        {
            get { return id_inventario; }
            set { id_inventario = value; }
        }




    }
}
