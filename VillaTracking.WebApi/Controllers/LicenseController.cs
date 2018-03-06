using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using VillaTracking.WebApi.Models;
using Newtonsoft.Json;

namespace VillaTracking.WebApi.Controllers
{
    public class LicenseController : ApiController
    {
        string strConn = "server=localhost;uid=root;pwd=Villa112016;database=licensesdb";
        // GET: api/License
        [Route("api/License/{license}/{owner}/{mode}")]
        public HttpResponseMessage Get(string license, string owner, int mode)
        {
            try
            {                
                Encryptation enc = new Encryptation();

                // ========== MODE ==========
                /* 1 = Consultar Licencia
                 * 2 = Registrar Licencia
                 */
                                 
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    MySqlCommand cmd;
                    MySqlDataAdapter da;
                    DataSet ds;
                    string query = "";
                    switch (mode)
                    {
                        case 1:
                            query = "SELECT * FROM serials WHERE serial = @1";
                            cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@1", license);
                            da = new MySqlDataAdapter(cmd);
                            ds = new DataSet();
                            da.Fill(ds);
                            
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                DataRow row = ds.Tables[0].Rows[0];

                                if (row["owner"].ToString().Equals(owner))
                                {
                                    if (((DateTime)row["expiration_date"]) < DateTime.Today)
                                    {
                                        return Request.CreateResponse(HttpStatusCode.Accepted, "EXPIRED");
                                    }
                                    else
                                    {
                                        License lic = new License();
                                        lic.Id = (int)row["id"];
                                        lic.Serial = row["serial"].ToString();
                                        lic.Type = row["type"].ToString();
                                        lic.Owner = row["owner"].ToString();
                                        lic.CreationDate = (DateTime)row["creation_date"];
                                        lic.ExpirationDate = (DateTime)row["expiration_date"];
                                        lic.Status = (int)row["status"];                                        
                                                                                
                                        return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(lic));
                                    }
                                }
                                else
                                {
                                    return Request.CreateResponse(HttpStatusCode.Accepted, "NO OWNER");
                                }                                
                            }
                            else
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }                            
                        default:
                            query = "SELECT * FROM serials WHERE serial = @1";
                            cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@1", license);
                            da = new MySqlDataAdapter(cmd);
                            ds = new DataSet();
                            da.Fill(ds);

                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                DataRow row = ds.Tables[0].Rows[0];

                                if (row["owner"].ToString().Equals("") || row["owner"].ToString().Equals(owner))
                                {
                                    query = "UPDATE serials set " +
                                            "owner = @1," +
                                            "creation_date = @2," +
                                            "expiration_date = @3 " +
                                        "WHERE serial = @4";

                                    cmd = new MySqlCommand(query, conn);
                                    cmd.Parameters.AddWithValue("@1", owner);
                                    cmd.Parameters.AddWithValue("@2", DateTime.Today);
                                    cmd.Parameters.AddWithValue("@3", DateTime.Today.AddMonths(1));
                                    cmd.Parameters.AddWithValue("@4", license);
                                    cmd.ExecuteNonQuery();

                                    query = "SELECT * FROM serials WHERE serial = @1";
                                    cmd = new MySqlCommand(query, conn);
                                    cmd.Parameters.AddWithValue("@1", license);
                                    da = new MySqlDataAdapter(cmd);
                                    ds = new DataSet();
                                    da.Fill(ds);

                                    row = ds.Tables[0].Rows[0];
                                    License lic = new License();
                                    lic.Id = (int)row["id"];
                                    lic.Serial = row["serial"].ToString();
                                    lic.Type = row["type"].ToString();
                                    lic.Owner = row["owner"].ToString();
                                    lic.CreationDate = (DateTime)row["creation_date"];
                                    lic.ExpirationDate = (DateTime)row["expiration_date"];
                                    lic.Status = (int)row["status"];

                                    return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(lic));
                                }                                
                                else
                                {
                                    return Request.CreateResponse(HttpStatusCode.Accepted, "IN USE");
                                }
                            }
                            else
                            {
                                return Request.CreateResponse(HttpStatusCode.NotFound);
                            }
                    }                    
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }        
    }
}
