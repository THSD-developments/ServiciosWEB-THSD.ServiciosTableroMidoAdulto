using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace THSD.ServiciosTableroMidoAdulto.Negocio.Conexion

{
    // === Clase Principal de Conexión ===
    public class HelperSQL
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(HelperSQL));
        // CAMBIO CLAVE: Revertimos al nombre que es más probable que exista en tu web.config
        private const string ConnectionName = "tableroMIDOweb";

        // --- ExecStoreProcedure SIN parámetros ---
        public DataTable ExecStoreProcedure(string SpName)
        {
            DataTable LdtIntro = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                using (SqlCommand sqlCmd = new SqlCommand(SpName, sqlCon))
                {
                    sqlCon.Open();
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.CommandTimeout = 0;

                    using (SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        LdtIntro.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                new HelperLog().LogError(ex.Message, "ExecStoreProcedure");
            }
            return LdtIntro;
        }

        // --- ExecStoreProcedure CON parámetros (El que te dio problemas) ---
        public DataTable ExecStoreProcedure(string SpName, List<SqlParameter> ParametersSQL)
        {
            DataTable LdtIntro = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                using (SqlCommand sqlCmd = new SqlCommand(SpName, sqlCon))
                {
                    sqlCon.Open();
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.CommandTimeout = 0;

                    foreach (SqlParameter parametro in ParametersSQL)
                    {
                        sqlCmd.Parameters.Add(parametro);
                    }

                    using (SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        LdtIntro.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                new HelperLog().LogError(ex.Message, "ExecStoreProcedure");
            }
            return LdtIntro;
        }

        // --- ExecStoreProcedureOSIC SIN parámetros ---
        public DataTable ExecStoreProcedureOSIC(string SpName)
        {
            DataTable LdtIntro = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                using (SqlCommand sqlCmd = new SqlCommand(SpName, sqlCon))
                {
                    sqlCon.Open();
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.CommandTimeout = 0;

                    using (SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        LdtIntro.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                new HelperLog().LogError(ex.Message, "ExecStoreProcedureOSIC");
            }
            return LdtIntro;
        }

        // --- ExecStoreProcedureOSIC CON parámetros ---
        public DataTable ExecStoreProcedureOSIC(string SpName, List<SqlParameter> ParametersSQL)
        {
            DataTable LdtIntro = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                using (SqlCommand sqlCmd = new SqlCommand(SpName, sqlCon))
                {
                    sqlCon.Open();
                    sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCmd.CommandTimeout = 0;

                    foreach (SqlParameter parametro in ParametersSQL)
                    {
                        sqlCmd.Parameters.Add(parametro);
                    }

                    using (SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        LdtIntro.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                new HelperLog().LogError(ex.Message, "ExecStoreProcedure");
            }
            return LdtIntro;
        }
    }

    // === Clase de Log (DENTRO del namespace) ===
    public class HelperLog
    {
        public void LogError(string logMessageError, string ObjectError)
        {
            // Lógica de logging
            string pathArchivo = string.Empty;
            string msgError = string.Empty;
        }
    }
}