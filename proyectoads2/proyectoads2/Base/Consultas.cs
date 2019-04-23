using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using proyectoads2.Datos;
using System.Windows.Forms;
using System.Data;

namespace proyectoads2.Base
{
    class Consultas
    {
        public Consultas()
        {
            conn = con.getConnect();
        }
        private Conexion con = new Conexion();
        private String sql;
        private MySqlCommand Comando = null;
        private MySqlConnection conn = null;
        private MySqlDataReader adap = null;
        private MySqlDataAdapter adaptador = null;

        internal void SeeAlumnos(DataGridView dGVAlumnos)
        {
            try
            {
                sql = "SELECT alumno.id_alumno, alumno.nombre_alumno, estado.estado FROM alumno INNER JOIN estado " 
                    +"on alumno.id_estado = estado.id_estado where alumno.id_estado = 0";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                adaptador = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dGVAlumnos.DataSource = dt;
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        public void GetDatosSecre(Usuari secre)
        {
            try
            {
                sql = "SELECT  usuario.usuario, usuario.id_cargo, "
                + " cargo.cargo"
                + " FROM  usuario INNER JOIN"
                + " cargo ON usuario.id_cargo = cargo.id_cargo"
                + " WHERE usuario.id_cargo = 1 ";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);                
                adap = Comando.ExecuteReader();
                if (adap.Read())
                {
                    secre.Usuario = adap.GetValue(0).ToString();
                    secre.Id_cargo = Convert.ToInt32(adap.GetValue(1));                    
                    secre.Cargo = adap.GetValue(2).ToString();
                    secre.Id_user = "1";
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        public void UpdateUser(Usuari usuario)
        {
            try
            {                
                sql = "update usuario set password = sha2(?1,256), correo = ?2,"
                    + " correo_destion = ?3, pcorreo = ?4 "
                    + " where id_user = ?5";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                Comando.Parameters.Add(new MySqlParameter("?1", usuario.Contra));
                Comando.Parameters.Add(new MySqlParameter("?2", usuario.Correo));
                Comando.Parameters.Add(new MySqlParameter("?3", usuario.Correo_destino));
                Comando.Parameters.Add(new MySqlParameter("?4", usuario.Contracorreo));
                Comando.Parameters.Add(new MySqlParameter("?5", usuario.Id_user));
                Comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sus datos han sido actualizados Correctamente!!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        public void AddAlumno(string text1, string text2)
        {
            try
            {
                sql = "insert into alumno values (?1, ?2, 0)";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                Comando.Parameters.Add(new MySqlParameter("?1", text1));
                Comando.Parameters.Add(new MySqlParameter("?2", text2));                
                Comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Alumno Ingresado Correctamente!!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        internal void BajarAlumno(string dselect)
        {
            try
            {
                sql = "update alumno set id_estado = 1 where id_alumno = ?1";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                Comando.Parameters.Add(new MySqlParameter("?1", dselect));                
                Comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Alumno Dado de baja Correctamente!!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        public bool ExitsAlumno(string text)
        {
            try
            {
                sql = "SELECT * FROM alumno WHERE id_alumno = ?";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                Comando.Parameters.Add(new MySqlParameter("id_alumno", text));                
                adap = Comando.ExecuteReader();
                if (adap.Read())
                {
                    conn.Close();
                    return true;
                }
                else
                {                    
                    conn.Close();
                    return false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        public void VerVendidos(DataGridView dGVencidos)
        {
            try
            {
                sql = "SELECT vencimientos.id_vencimiento, alimentos.alimento, vencimientos.cantidad FROM vencimientos  INNER JOIN alimentos"
                        + " on vencimientos.id_alimento = alimentos.id_alimento";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                adaptador = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dGVencidos.DataSource = dt;
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        internal void EliminarVencidos()
        {
            try
            {
                sql = "update vencimientos set cantidad = 0";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                Comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Los vencimientos han sido eliminados");
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        public void VerInventario(DataGridView tabDatos)
        {
            try
            {
                sql = "SELECT inventario.id_inventario, inventario.fecha_ingreso, alimentos.alimento, inventario.cantidad, inventario.fecha_vencimiento FROM `inventario` INNER JOIN alimentos ON inventario.id_alimento = alimentos.id_alimento WHERE inventario.cantidad > 0";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                adaptador = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                tabDatos.DataSource = dt;
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
            
        }

        

        internal bool Exist(string user, string pass, Datos.Usuari usuario)
        {
            sql = "select * from usuario where usuario = ? and password = sha2(?,256)";
            conn.Open();
            Comando = new MySqlCommand(sql, conn);
            Comando.Parameters.Add(new MySqlParameter("usuario", user));
            Comando.Parameters.Add(new MySqlParameter("password", pass));
            adap = Comando.ExecuteReader();
            if (adap.Read())
            {
                usuario.Id_user = adap.GetValue(0).ToString();
                usuario.Contra = pass;
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
                
            }
        }

        internal int GetLastIDInv()
        {
            try
            {
                sql = "select count(*) from inventario";
                int prueba = 0;
                conn.Open();
                Comando=new MySqlCommand(sql, conn);
                adap = Comando.ExecuteReader();
                if (adap.Read())
                    prueba = Convert.ToInt32(adap.GetValue(0));
                conn.Close();
                return prueba;
            }
            catch (Exception e)
            {
                conn.Close();
                MessageBox.Show(e + "");
                throw;
            }
        }

        internal void AddInventario(List<Inventario> listInventario)
        {
            try
            {
                foreach (Inventario item in listInventario)
                {
                    Inventario inv2 = new Inventario();
                    inv2 = item;
                    sql = "insert into inventario values (?1, ?2, ?3, ?4, ?5)";
                    conn.Open();
                    Comando = new MySqlCommand(sql, conn);
                    Comando.Parameters.AddWithValue("?1", inv2.Id_inventario);
                    Comando.Parameters.AddWithValue("?2", inv2.Fecha_ingreso);
                    Comando.Parameters.AddWithValue("?3", inv2.Id_alimento);
                    Comando.Parameters.AddWithValue("?4", inv2.Cantidad);
                    Comando.Parameters.AddWithValue("?5", inv2.Fecha_vencimiento);
                    Comando.ExecuteNonQuery();
                    conn.Close();                                       
                }
                MessageBox.Show("El pedido ha sido registrado");
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        internal void GetDatos(Usuari usuario)
        {
            try
            {
                sql = "SELECT  usuario.usuario, usuario.id_cargo, usuario.correo,"
                + " usuario.correo_destion, cargo.cargo, usuario.pcorreo"
                + " FROM  usuario INNER JOIN"
                + " cargo ON usuario.id_cargo = cargo.id_cargo"
                + " WHERE id_user = ? ";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                Comando.Parameters.Add(new MySqlParameter("id_user", usuario.Id_user));
                adap = Comando.ExecuteReader();
                if (adap.Read())
                {
                    usuario.Usuario = adap.GetValue(0).ToString();
                    usuario.Id_cargo = Convert.ToInt32(adap.GetValue(1));
                    usuario.Correo = adap.GetValue(2).ToString();
                    usuario.Correo_destino = adap.GetValue(3).ToString();
                    usuario.Cargo = adap.GetValue(4).ToString();
                    usuario.Contracorreo = adap.GetValue(5).ToString();                    
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
            
        }
    }
}
