using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoads2.Datos
{
    public class Semanal
    {
        private int id_Inventario;
        private int id_Alimento;
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public int ID_Alimento
        {
            get { return id_Alimento; }
            set { id_Alimento = value; }
        }

        public int ID_Inventario
        {
            get { return id_Inventario; }
            set { id_Inventario = value; }
        }
    }
}
