using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using VillaTracking.WebApi.Models;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Data;

namespace VillaTracking.WebApi.Controllers
{
    public class UserController : ApiController
    {
        string strConn = "server=localhost;uid=root;pwd=Villa112016;database=zutrackingcross";

        [HttpGet]
        [Route("api/user/{username}/{password}")]
        public HttpResponseMessage login(string username, string password)
        {
            try
            {
                User user = new User();
                Encryptation enc = new Encryptation();

                string query = "SELECT " +
                                    "user_id," +
                                    "dni," +
                                    "first_name," +
                                    "last_name," +
                                    "address," +
                                    "email," +
                                    "phone_number1," +
                                    "phone_number2," +
                                    "permission_level," +
                                    "status," +
                                    "image " +
                                "FROM users " +
                                "WHERE " +
                                    "dni = @1 AND pass = @2";

                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@1", username);
                    cmd.Parameters.AddWithValue("@2", enc.Encrypt(password));
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];                       
                        user.Id = (int)row["user_id"];
                        user.Dni = (long)row["dni"];
                        user.FirstName = row["first_name"].ToString();
                        user.LastName = row["last_name"].ToString();
                        user.Email = row["email"].ToString();
                        user.Address = row["address"].ToString();
                        user.PhoneNumber1 = long.Parse(row["phone_number1"].ToString());
                        user.PermissionLevel = (int)row["permission_level"];
                        user.Status = (int)row["status"];

                        //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        //{

                        //    users.Add(user);
                        //}

                        return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(user));
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.NoContent);
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
