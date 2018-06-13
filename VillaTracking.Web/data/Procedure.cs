using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Data;

namespace VillaTracking.Web.data
{
    public class Procedure
    {
        private Encryptation enc = new Encryptation();
        private MySqlCommand cmd;
        private MySqlCommandBuilder cb;

        public string StrConn { get; set; } = "server=localhost;uid=root;pwd=Villa112016;database=camimpegdb;Convert Zero Datetime=True;SslMode=none";

        public string ErrorMsg { get; set; }

        public DataSet Ds { get; set; }

        // FUNCION PARA EJECUTAR UN PROCEDIMIENTO ALMACENADO DE CARGA SIN PARAMETROS
        public bool GetData(string sp)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    conn.Open();

                    cmd = new MySqlCommand();
                    cmd.CommandText = sp;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.CommandTimeout = 0;

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(Ds);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
                return false;
            }
        }

        // FUNCION PARA EJECUTAR UN PROCEDIMIENTO ALMACENADO DE CARGA CON PARAMETROS
        public bool GetData(string sp, params object[] parametro)
        {
            // Try
            using (MySqlConnection conn = new MySqlConnection(StrConn))
            {
                cmd = new MySqlCommand();
                cmd.CommandText = sp;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                conn.Open();
                // MySqlCommandBuilder.DeriveParameters(cmd)

                for (var i = 0; i <= parametro.Length - 1; i++)
                    // CType(cmd.Parameters(i), MySqlParameter).Value = parametro(i)
                    cmd.Parameters.Add(new MySqlParameter("_" + i.ToString(), parametro[i]));

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(Ds);
                }
            }
            return true;
        }

        // FUNCION PARA EJECUTAR UN PROCEDIMIENTO ALMACENADO DE INSERCION O ACTUALIZACION DE DATOS CON PARAMETROS
        public bool SendData(string sp, params object[] parametro)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    conn.Open();

                    cmd = new MySqlCommand();
                    cmd.CommandText = sp;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.CommandTimeout = 0;

                    MySqlCommandBuilder.DeriveParameters(cmd);

                    for (var i = 0; i <= parametro.Length - 1; i++)
                    {
                        cmd.Parameters[i].Value = parametro[i];
                    }

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
                return false;
            }
        }

        public bool SendData(string sp, byte[] image, params object[] parametro)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    conn.Open();

                    cmd = new MySqlCommand();
                    cmd.CommandText = sp;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    cmd.CommandTimeout = 0;

                    MySqlCommandBuilder.DeriveParameters(cmd);

                    for (var i = 0; i <= parametro.Length - 1; i++)
                    {
                        cmd.Parameters[i].Value = parametro[i];
                    }

            
                    cmd.ExecuteReader();
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
                return false;
            }
        }
    }
}