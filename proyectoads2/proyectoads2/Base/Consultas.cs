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
            conn = con.GetConnect();
        }
        private Conexion con = new Conexion();
        private String sql;
        private MySqlCommand Comando = null;

        internal void listud(ComboBox estudiante)
        {
            try
            {
                sql = "SELECT id_alumno FROM uniforme";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                adap = Comando.ExecuteReader();
                while (adap.Read())
                {
                    estudiante.Items.Add(adap.GetValue(0).ToString());


                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        internal void newplanif(Panel panelarroz, int v)
        {
            int d=0, d1=0, d2=0, d3=0, d4=0;
            int i =0;
            foreach (Control item in panelarroz.Controls)
            {
                if (i == 0) d = (item.Text.Length > 0) ? Convert.ToInt32(item.Text) : 0;
                else if (i == 1) d1 = (item.Text.Length > 0) ? Convert.ToInt32(item.Text) : 0;
                else if (i == 2) d2 = (item.Text.Length > 0) ? Convert.ToInt32(item.Text) : 0;
                else if (i == 3) d3 = (item.Text.Length > 0) ? Convert.ToInt32(item.Text) : 0;
                else d4 = (item.Text.Length > 0) ? Convert.ToInt32(item.Text) : 0;
                i++;
            }
            try
            {
                sql = "update planificacion" 
                +" set lunes = ?1,martes = ?2,miercoles = ?3,jueves = ?4,viernes = ?5"
                +" where id_alimento = ?6";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                Comando.Parameters.Add(new MySqlParameter("?1", d));
                Comando.Parameters.Add(new MySqlParameter("?2", d1));
                Comando.Parameters.Add(new MySqlParameter("?3", d2));
                Comando.Parameters.Add(new MySqlParameter("?4", d3));
                Comando.Parameters.Add(new MySqlParameter("?5", d4));
                Comando.Parameters.Add(new MySqlParameter("?6", v));
                Comando.ExecuteNonQuery();
                conn.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        internal void listud2(ComboBox estudiante)
        {
            try
            {
                sql = "SELECT id_alumno FROM alumno WHERE id_estado=0";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                adap = Comando.ExecuteReader();
                while (adap.Read())
                {
                    estudiante.Items.Add(adap.GetValue(0).ToString());
                   
                    
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        internal void mostraruniforme(DataGridView mostrarunif)
        {
            try
            {
                sql = "SELECT id_alumno, cantidad FROM uniforme";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                adaptador = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                mostrarunif.DataSource = dt;
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        internal void actualizaruniformes(string agg, int v)
        {
            try
            {
                sql = "UPDATE uniforme SET cantidad =?1 WHERE id_alumno =?2";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                Comando.Parameters.Add(new MySqlParameter("?1", v));
                Comando.Parameters.Add(new MySqlParameter("?2", agg));
                Comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Uniforme actualizado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

        internal int cantidadalumno(string agg)
        {
            try
            {
                sql = "SELECT cantidad FROM uniforme WHERE id_alumno='"+agg+"'";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                adap = Comando.ExecuteReader();
                int conteo=0;
                if (adap.Read())
                {
                    conteo = Convert.ToInt32(adap.GetValue(0).ToString());
                    conn.Close();
                    
                }
                return conteo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
           
        }

        internal void nuevounif(string agg, int v)
        {
            try
            {
                sql = "insert into uniforme values (?1, ?2)";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                Comando.Parameters.Add(new MySqlParameter("?1", agg));
                Comando.Parameters.Add(new MySqlParameter("?2", v));
                Comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Uniforme Ingresado Correctamente!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }

        }

        internal bool existealumno(string agg)
        {
            try
            {
                sql = "SELECT * FROM uniforme WHERE id_alumno = '"+agg+"'";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
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

        public void Restantes(DataGridView dGVRestantes)
        {
            try
            {
                sql = "SELECT alimentos.alimento as Alimento, SUM(inventario.cantidad) as 'Cantidad Restante'"
                    + " FROM `inventario` INNER JOIN alimentos on inventario.id_alimento = alimentos.id_alimento"
                    + " GROUP BY inventario.id_alimento";
                conn.Open();
                Comando = new MySqlCommand(sql, conn);
                adaptador = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dGVRestantes.DataSource = dt;
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
                conn.Close();
                throw;
            }
        }

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
                MessageBox.Show("Sus datos han sido actualizados Correctamente!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Alumno Ingresado Correctamente!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Alumno Dado de baja Correctamente!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Los vencimientos han sido eliminados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        internal void AddInventario(List<Datos.Inventario> listInventario)
        {
            try
            {
                foreach (Datos.Inventario item in listInventario)
                {
                    Datos.Inventario inv2 = new Datos.Inventario();
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
                MessageBox.Show("El pedido ha sido registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                conn.Close();
                MessageBox.Show(e + "");
                
            }
            
        }
    }
}
