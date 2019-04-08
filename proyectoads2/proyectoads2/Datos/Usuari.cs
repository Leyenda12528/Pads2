using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoads2.Datos
{
    public class Usuari
    {
        public Usuari() { }
        private String id_user;
        private String usuario;
        private String cargo;
        private int id_cargo;
        private String correo;
        private String correo_destino;

        public String Id_user
        {
            get { return id_user; }
            set { id_user = value; }
        }      

        public int Id_cargo
        {
            get { return id_cargo; }
            set { id_cargo = value; }
        }        

        public String  Correo_destino
        {
            get { return correo_destino; }
            set { correo_destino = value; }
        }


        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }


        public String Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }


        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

    }
}
