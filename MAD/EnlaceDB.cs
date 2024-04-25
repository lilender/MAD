using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace MAD
{
    public class EnlaceDB
    {
        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();

        public DataTable obtenertabla
        {
            get
            {
                return _tabla;
            }
        }

        private static void conectar()
        {
            /*
			Para que funcione el ConfigurationManager
			en la sección de "Referencias" de su proyecto, en el "Solution Explorer"
			dar clic al botón derecho del mouse y dar clic a "Add Reference"
			Luego elegir la opción System.Configuration
			*/
            string cnn = ConfigurationManager.ConnectionStrings["SQL"].ToString();
            
            _conexion = new SqlConnection(cnn);
            _conexion.Open();
        }
        private static void desconectar()
        {
            _conexion.Close();
        }

        public string sp_obtener_id(string correo)
        {
            var resultado = "";
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_obtener_id";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@correo", SqlDbType.VarChar, 255);
                parametro1.Value = correo;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    resultado = tabla.Rows[0].ItemArray[0].ToString();
                }

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return resultado;
        }
        public bool sp_update_usuarios(string opcion, Usuario usuario, string id)
        {
            var msg = "";
            var up = true;
            try
            {
                conectar();
                string qry = "sp_update_usuarios";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.VarChar, 10);
                parametro1.Value = opcion;
                var parametro2 = _comandosql.Parameters.Add("@correo", SqlDbType.VarChar, 255);
                parametro2.Value = usuario.correo;
                var parametro3 = _comandosql.Parameters.Add("@nombres", SqlDbType.VarChar, 50);
                parametro3.Value = usuario.nombres;
                var parametro4 = _comandosql.Parameters.Add("@apellido_p", SqlDbType.VarChar, 50);
                parametro4.Value = usuario.apellido_p;
                var parametro5 = _comandosql.Parameters.Add("@apellido_m", SqlDbType.VarChar, 50);
                parametro5.Value = usuario.apellido_m;
                var parametro6 = _comandosql.Parameters.Add("@f_nacimiento", SqlDbType.Date, 1);
                parametro6.Value = usuario.f_nacimiento;
                var parametro7 = _comandosql.Parameters.Add("@genero", SqlDbType.Bit, 1);
                parametro7.Value = usuario.genero;
                var parametro8 = _comandosql.Parameters.Add("@pregunta", SqlDbType.VarChar, 255);
                parametro8.Value = usuario.pregunta;
                var parametro9 = _comandosql.Parameters.Add("@respuesta", SqlDbType.VarChar, 25); //checarluego el 25
                parametro9.Value = usuario.respuesta;
                var parametro10 = _comandosql.Parameters.Add("@contrasena", SqlDbType.VarChar, 25); //checar luego el 25
                parametro10.Value = usuario.contrasena;
                var parametro11 = _comandosql.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 1); //checar luego el 25
                if (id != null) parametro11.Value = new Guid(id);
                _adaptador.InsertCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                up = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return up;
        }
        
        public string sp_valida_contra_y_resp(string id, string cifrado, string opcion)
        {
            var resultado = "";
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_valida_contra_y_resp";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro2 = _comandosql.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 1);
                parametro2.Value = new Guid(id);
                var parametro3 = _comandosql.Parameters.Add("@cifrado", SqlDbType.VarChar, 25); //checar luego
                parametro3.Value = cifrado;
                var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.VarChar, 10);
                parametro1.Value = opcion;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    resultado = tabla.Rows[0].ItemArray[0].ToString();
                }

            }
            catch (FormatException e)
            {

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return resultado;
        }
        
        public string sp_nueva_contrasena(string id, string contrasena)
        {
            var resultado = "";
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_nueva_contrasena";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 1);
                parametro1.Value = new Guid(id);
                var parametro2 = _comandosql.Parameters.Add("@contrasena", SqlDbType.VarChar, 25); //checar luego
                parametro2.Value = contrasena;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    resultado = tabla.Rows[0].ItemArray[0].ToString();
                }

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return resultado;
        }
        
        public string sp_cambio_respuesta(string id, string RespActual, string RespNueva)
        {
            var resultado = "";
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_cambio_respuesta";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 1);
                parametro1.Value = new Guid(id);
                var parametro2 = _comandosql.Parameters.Add("@respActual", SqlDbType.VarChar, 50); //checar luego
                parametro2.Value = RespActual;
                var parametro3 = _comandosql.Parameters.Add("@respNueva", SqlDbType.VarChar, 50); //checar luego
                parametro3.Value = RespNueva;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    resultado = tabla.Rows[0].ItemArray[0].ToString();
                }

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return resultado;
        }
        public Usuario sp_obtener_datos_usuarios(string id, string opcion)
        {
            var msg = "";
            Usuario usuario = new Usuario();
            DataTable tabla = new DataTable();
            if (opcion == "todo")
            {
                try
                {
                    conectar();
                    string qry = "sp_obtener_datos_usuarios";
                    _comandosql = new SqlCommand(qry, _conexion);
                    _comandosql.CommandType = CommandType.StoredProcedure;
                    _comandosql.CommandTimeout = 9000;

                    var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.VarChar, 10);
                    parametro1.Value = opcion;
                    var parametro2 = _comandosql.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 1);
                    parametro2.Value = new Guid(id);

                    _adaptador.SelectCommand = _comandosql;
                    _adaptador.Fill(tabla);

                    if (tabla.Rows.Count > 0)
                    {
                        bool genero;
                        if (tabla.Rows[tabla.Rows.Count - 1].ItemArray[5].ToString() == "True") { genero = true; } else { genero = false; };
                        usuario = new Usuario(
                            tabla.Rows[tabla.Rows.Count - 1].ItemArray[0].ToString(),
                            tabla.Rows[tabla.Rows.Count - 1].ItemArray[1].ToString(),
                            tabla.Rows[tabla.Rows.Count - 1].ItemArray[2].ToString(),
                            tabla.Rows[tabla.Rows.Count - 1].ItemArray[3].ToString(),
                            tabla.Rows[tabla.Rows.Count - 1].ItemArray[4].ToString(),
                            genero,
                            tabla.Rows[tabla.Rows.Count - 1].ItemArray[6].ToString(), null, null);

                    }

                }
                catch (SqlException e)
                {
                    msg = "Excepción de base de datos: \n";
                    msg += e.Message;
                    MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    usuario = new Usuario();

                }
                finally
                {
                    desconectar();

                }
            } 
            else
            {
                try
                {
                    conectar();
                    string qry = "sp_obtener_datos_usuarios";
                    _comandosql = new SqlCommand(qry, _conexion);
                    _comandosql.CommandType = CommandType.StoredProcedure;
                    _comandosql.CommandTimeout = 9000;

                    var parametro1 = _comandosql.Parameters.Add("@opcion", SqlDbType.VarChar, 10);
                    parametro1.Value = opcion;
                    var parametro2 = _comandosql.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 1);
                    parametro2.Value = new Guid(id);

                    _adaptador.SelectCommand = _comandosql;
                    _adaptador.Fill(tabla);

                    if (tabla.Rows.Count > 0)
                    {
                        usuario = new Usuario();
                        if (opcion == "idioma")
                        {
                            usuario.idioma = tabla.Rows[tabla.Rows.Count - 1].ItemArray[0].ToString();

                        } 
                        else if (opcion == "contador")
                        {
                            usuario.contador = tabla.Rows[tabla.Rows.Count - 1].ItemArray[0].ToString();
                        } 
                        else if (opcion == "pregunta")
                        {
                            usuario.pregunta = tabla.Rows[tabla.Rows.Count - 1].ItemArray[0].ToString();
                        }

                    }

                }
                catch (SqlException e)
                {
                    msg = "Excepción de base de datos: \n";
                    msg += e.Message;
                    MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    usuario = new Usuario();

                }
                finally
                {
                    desconectar();

                }
            }
            
            

            return usuario;

        }

        public DataTable sp_llenar_combos(string idioma, string version, string testamento, string libro, string capitulo)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_llenar_combos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@idioma", SqlDbType.VarChar, 20);
                parametro1.Value = idioma;
                var parametro2 = _comandosql.Parameters.Add("@version", SqlDbType.VarChar, 30);
                parametro2.Value = version;
                var parametro3 = _comandosql.Parameters.Add("@testamento", SqlDbType.VarChar, 20);
                parametro3.Value = testamento;
                var parametro4 = _comandosql.Parameters.Add("@libro", SqlDbType.VarChar, 20);
                parametro4.Value = libro;
                var parametro5 = _comandosql.Parameters.Add("@capitulo", SqlDbType.SmallInt, 1);
                parametro5.Value = capitulo;
                
                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public DataTable sp_resultados(object idioma, object version, object testamento, object libro, object capitulo, object versiculo, object palabras, string id)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_resultados";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@idioma", SqlDbType.VarChar, 20);
                parametro1.Value = idioma;
                var parametro2 = _comandosql.Parameters.Add("@version", SqlDbType.VarChar, 30);
                parametro2.Value = version;
                var parametro3 = _comandosql.Parameters.Add("@testamento", SqlDbType.VarChar, 20);
                parametro3.Value = testamento;
                var parametro4 = _comandosql.Parameters.Add("@libro", SqlDbType.VarChar, 20);
                parametro4.Value = libro;
                var parametro5 = _comandosql.Parameters.Add("@capitulo", SqlDbType.SmallInt, 1);
                parametro5.Value = capitulo;
                var parametro6 = _comandosql.Parameters.Add("@versiculo", SqlDbType.SmallInt, 1);
                parametro6.Value = versiculo;
                var parametro7 = _comandosql.Parameters.Add("@palabras", SqlDbType.VarChar, 100);
                parametro7.Value = palabras;
                var parametro8 = _comandosql.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 1);
                parametro8.Value = new Guid(id);
                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }

        public DataTable sp_historial(string id)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_historial";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;
                
                var parametro8 = _comandosql.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 1);
                parametro8.Value = new Guid(id);
                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        

        public bool sp_borrar_historial(string id_objeto, string id)
        {
            var msg = "";
            var up = true;
            try
            {
                conectar();
                string qry = "sp_borrar_historial";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@id_objeto", SqlDbType.UniqueIdentifier, 1); //checar luego el 25
                if (id_objeto != null) parametro1.Value = new Guid(id_objeto);
                var parametro2 = _comandosql.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 1);
                if (id != null) parametro2.Value = new Guid(id);

                _adaptador.InsertCommand = _comandosql;

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                up = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return up;
        }

        public void sp_agregar_favorito(object idioma, object version, object testamento, object libro, object capitulo, object versiculo, string id)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_agregar_favorito";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@idioma", SqlDbType.VarChar, 20);
                parametro1.Value = idioma.ToString();
                var parametro2 = _comandosql.Parameters.Add("@version", SqlDbType.VarChar, 30);
                parametro2.Value = version.ToString();
                var parametro3 = _comandosql.Parameters.Add("@testamento", SqlDbType.VarChar, 20);
                parametro3.Value = testamento.ToString();
                var parametro4 = _comandosql.Parameters.Add("@libro", SqlDbType.VarChar, 20);
                parametro4.Value = libro.ToString();
                var parametro5 = _comandosql.Parameters.Add("@capitulo", SqlDbType.SmallInt, 1);
                parametro5.Value = capitulo;
                var parametro6 = _comandosql.Parameters.Add("@versiculo", SqlDbType.SmallInt, 1);
                parametro6.Value = versiculo;
                var parametro8 = _comandosql.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 1);
                parametro8.Value = new Guid(id);
                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

        }

        public DataTable sp_favoritos(string id)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_favoritos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro8 = _comandosql.Parameters.Add("@id", SqlDbType.UniqueIdentifier, 1);
                parametro8.Value = new Guid(id);
                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public DataTable sp_obtener_top_favoritos()
        {
            var msg = "";
            DataTable tabla = new DataTable();
            try
            {
                conectar();
                string qry = "sp_obtener_top_favoritos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                // la ejecución del SP espera que regrese datos en formato tabla

            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return tabla;
        }
        public bool sp_borrar_favorito(string id_fav, string id_usuario)
        {
            var msg = "";
            var up = true;
            try
            {
                conectar();
                string qry = "sp_borrar_favorito";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@id_fav", SqlDbType.UniqueIdentifier, 1);
                if (id_fav != null) parametro1.Value = new Guid(id_fav);
                var parametro2 = _comandosql.Parameters.Add("@id_usuario", SqlDbType.UniqueIdentifier, 1);
                if (id_usuario != null) parametro2.Value = new Guid(id_usuario);
                

                _adaptador.InsertCommand = _comandosql;
                // También se tienen las propiedades del adaptador: UpdateCommand  y DeleteCommand

                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                up = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return up;
        }

    }
}
