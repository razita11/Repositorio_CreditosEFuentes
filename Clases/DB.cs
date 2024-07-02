using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using static System.Collections.Specialized.BitVector32;

namespace Gestion_Creditos_EFuentes.Clases
{
    internal class DB : Clases.SQLServer
    {
        Clases.Helpers h = new Clases.Helpers();
        SqlCommand com;
        SqlDataReader reader;
        DataTable data;
        DataTable recordset;
        string query;


        private void RegistrarQuery(string query)
        {

            string usuario = Auth.USERNAME;
            string columnas = "USUARIO, QUERY, REGISTRO";
            string valores = $"'{usuario}', '{query.Replace("'", "''")}', GETDATE()";

            string logQuery = $"INSERT INTO LOGQUERYS ({columnas}) VALUES ({valores})";

            rawSQL(logQuery);

        }


        public bool Save(string tablename, string campos, string valores)
        {
            query = $"INSERT INTO {tablename}({campos}) VALUES ({valores})";
            try
            {
                com = new SqlCommand(query, ConSQL);
                abrirConexion();
                int rowsAffected = com.ExecuteNonQuery();
                return rowsAffected > 0; // Retorna verdadero si rowsAffected es mayor que cero, falso en caso contrario
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
                return false; // En caso de error, retornamos falso
            }
            finally
            {
                cerrarConexion();
                RegistrarQuery(query);
            }
        }


        public void LogQuery(string query, string usuario)
        {
            string logQuery = $"INSERT INTO LogQuerys (USUARIO, QUERY) VALUES (@usuario, @query)";
            try
            {
                using (SqlCommand logCom = new SqlCommand(logQuery, ConSQL))
                {
                    logCom.Parameters.AddWithValue("@usuario", usuario);
                    logCom.Parameters.AddWithValue("@query", query);
                    abrirConexion();
                    logCom.ExecuteNonQuery();
                }
            }
            catch (SqlException error)
            {
                h.advertencia($"Error al registrar log de consulta: {error.Message}");
            }
            finally
            {
                cerrarConexion();
            }
        }


        public bool Saveimage(string tablename, string campos, string valores, Dictionary<string, object> parametros = null)
        {
            query = $"INSERT INTO {tablename}({campos}) VALUES ({valores})";
            try
            {
                com = new SqlCommand(query, ConSQL);
                if (parametros != null)
                {
                    foreach (var param in parametros)
                    {
                        com.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                abrirConexion();
                int rowsAffected = com.ExecuteNonQuery();
                return rowsAffected > 0; // Retorna verdadero si rowsAffected es mayor que cero, falso en caso contrario
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
                return false; // En caso de error, retornamos falso
            }
            finally
            {
                cerrarConexion();
                RegistrarQuery(query);
            }
        }


        public bool UpdateImage(string tablename, string setClause, string condition, Dictionary<string, object> parametros = null)
        {
            query = $"UPDATE {tablename} SET {setClause} WHERE {condition}";
            try
            {
                com = new SqlCommand(query, ConSQL);
                if (parametros != null)
                {
                    foreach (var param in parametros)
                    {
                        com.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                abrirConexion();
                int rowsAffected = com.ExecuteNonQuery();
                return rowsAffected > 0; // Retorna verdadero si rowsAffected es mayor que cero, falso en caso contrario
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
                return false; // En caso de error, retornamos falso
            }
            finally
            {
                cerrarConexion();
            }
        }

        public int UpdateInner(string tablename, string campos, string condicion)
        {
            int result = 0;
            string query = $"UPDATE {tablename} SET {campos} WHERE {condicion}";

            try
            {
                com = new SqlCommand(query, ConSQL);
                abrirConexion();
                result = com.ExecuteNonQuery();
                cerrarConexion();
            }
            catch (SqlException error)
            {
                h.advertencia($"Error al Actualizar Datos: {error.Message}");
            }
            finally
            {
                terminarConexion();
            }

            return result;
        }




        public DataTable Find(string tablename, string campos, string condicion = "", string orderby = "", bool debug = false)
        {
            recordset = new DataTable();
            if (condicion == "" && orderby == "")
            {
                query = $"SELECT {campos} FROM {tablename}";

            }
            else if (condicion != "" && orderby == "")
            {
                query = $"SELECT {campos} FROM {tablename} WHERE {condicion}";
            }
            else if (condicion == "" && orderby != "")
            {
                query = $"SELECT {campos} FROM {tablename} ORDER BY {orderby}";
            }
            else if (condicion != "" && orderby != "")
            {
                query = $"SELECT {campos} FROM {tablename} WHERE {condicion} ORDER BY {orderby}";
            }

            try
            {
                com = new SqlCommand(query, ConSQL);
                abrirConexion();
                reader = com.ExecuteReader();
                recordset.Load(reader);
                reader.Close();
                com.Dispose();
                cerrarConexion();
            }
            catch (SqlException error)
            {
                h.advertencia($"Error al Recuperar Datos{error}");
            }

            finally
            {
                terminarConexion();
                RegistrarQuery(query);
            }
            return recordset;
        }


        public DataTable FindInner(string tablename, string campos, string condicion = "", string joins = "", string orderby = "", bool debug = false)
        {
            recordset = new DataTable();
            if (condicion == "" && orderby == "")
            {
                query = $"SELECT {campos} FROM {tablename} {joins}";
            }
            else if (condicion != "" && orderby == "")
            {
                query = $"SELECT {campos} FROM {tablename} {joins} WHERE {condicion}";
            }
            else if (condicion == "" && orderby != "")
            {
                query = $"SELECT {campos} FROM {tablename} {joins} ORDER BY {orderby}";
            }
            else if (condicion != "" && orderby != "")
            {
                query = $"SELECT {campos} FROM {tablename} {joins} WHERE {condicion} ORDER BY {orderby}";
            }

            try
            {
                com = new SqlCommand(query, ConSQL);
                abrirConexion();
                reader = com.ExecuteReader();
                recordset.Load(reader);
                reader.Close();
                com.Dispose();
                cerrarConexion();
            }
            catch (SqlException error)
            {
                h.advertencia($"Error al Recuperar Datos{error}");
            }
            finally
            {
                terminarConexion();
                RegistrarQuery(query);
            }
            return recordset;
        }


        public bool Exists(string tablename, string campo, string value)
        {
            bool resp = false;
            query = $"SELECT * FROM {tablename} WHERE {campo}={value}";
            try
            {
                com = new SqlCommand(query, ConSQL);
                abrirConexion();
                reader = com.ExecuteReader();
                if (reader.Read())
                {
                    resp = true;
                }
                reader.Close();
                com.Dispose();
            }
            catch (SqlException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConexion();
                RegistrarQuery(query);
            }

            return resp;
        }

        public int Destroy(string tablename, string condicion = "")
        {
            int rd = 0;
            if (condicion == "")
            {
                query = $"DELETE FROM {tablename}";
            }
            else
            {
                query = $"DELETE FROM {tablename} WHERE {condicion}";
            }
            rd = rawSQL(query);
            return rd;
        }

        public int rawSQL(string _query)
        {
            int ra = 0;
            try
            {
                com = new SqlCommand(_query, ConSQL);
                abrirConexion();
                ra = com.ExecuteNonQuery();

                cerrarConexion();

                com.Dispose();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                terminarConexion();
            }
            return ra;
        }

        public int update(string tablename, string data, string condicion = "")
        {
            int ru = 0;
            if (condicion == "")
            {
                query = $"UPDATE {tablename} SET {data}";
            }
            else
            {
                query = $"UPDATE {tablename} SET {data} WHERE {condicion}";
            }

            ru = rawSQL(query);

            return ru;
        }

        public void print(ReportDocument reporte)
        {
            try
            {
                ConnectionInfo con = new ConnectionInfo();
                Tables _tables = reporte.Database.Tables;
                con.ServerName = Clases.Entorno.SERVER;
                con.DatabaseName = Clases.Entorno.DATABASE;
                con.UserID = Clases.Entorno.USER;
                con.Password = Clases.Entorno.PWD;

                foreach (CrystalDecisions.CrystalReports.Engine.Table _table in _tables)
                {
                    TableLogOnInfo loginfo = _table.LogOnInfo;
                    loginfo.ConnectionInfo = con;
                    _table.ApplyLogOnInfo(loginfo);
                }
            }
            catch (CrystalReportsException error)
            {
                h.advertencia(error.Message);
            }
            finally
            {
                terminarConexion();
            }
        }

        public string GetLastRolId()
        {
            string lastMuestraId = string.Empty;
            query = "SELECT TOP 1 ID FROM ROLES ORDER BY ID DESC";

            try
            {
                com = new SqlCommand(query, ConSQL);
                abrirConexion();
                object result = com.ExecuteScalar();
                if (result != null)
                {
                    lastMuestraId = result.ToString();
                }
            }
            catch (SqlException error)
            {
                h.advertencia($"Error al obtener el último ID de roles: {error.Message}");
            }
            finally
            {
                cerrarConexion();
            }

            return lastMuestraId;
        }

        //public string SetTextVista(string text)
        //{
          //  string response;
            //response = $"{Clases.Entorno.APPNAME} - {text} - {Clases.Auth.USERNAME}"; 
        //}





    }
}
