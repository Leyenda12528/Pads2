using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace proyectoads2.Base
{
    class Conexion
    {
        private MySqlConnection con = new MySqlConnection("Server=localhost; Database=pads; Uid=root; pwd=;");
        public Conexion() {
            
        }
        public MySqlConnection GetConnect() {            
            return con;
        }

        //public void consulta(String sql) {
        //    try
        //    {
        //        if (con.State == ConnectionState.Closed)                
        //            con.Open();
                
        //        MySqlCommand consul = new MySqlCommand(sql, con);
        //        MySqlDataReader adap = consul.ExecuteReader();
        //        String mjs = "";
        //        while (adap.Read())
        //        {
        //            //mjs = "ID " + adap.GetValue(0).ToString() + "\nCargo {1}" + adap.GetValue(1).ToString();
        //            //MessageBox.Show(mjs);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e+"");
        //    }
        //}

        public void Cerrar() {
            con.Close();
        }
    }
}
