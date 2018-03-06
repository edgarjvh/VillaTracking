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

        // GET: api/User
        public HttpResponseMessage Get()
        {
            try
            {
                List<User> users = new List<User>();

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
                                    "image," +
                                    "pass " +
                                "FROM users";

                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DataRow row = ds.Tables[0].Rows[i];

                            User user = new User();

                            user.Id = (int)row["user_id"];
                            user.Dni = (long)row["dni"];
                            user.FirstName = row["first_name"].ToString();
                            user.LastName = row["last_name"].ToString();
                            user.Email = row["email"].ToString();
                            user.Address = row["address"].ToString();
                            user.PhoneNumber1 = long.Parse(row["phone_number1"].ToString());
                            user.PermissionLevel = (int)row["permission_level"];
                            user.Image = row["image"];
                            user.Status = (int)row["status"];
                            user.Pass = row["pass"].ToString();
                        
                            users.Add(user);
                        }
                    }
                }

                var json = JsonConvert.SerializeObject(users);

                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // GET: api/User/5
        public HttpResponseMessage Get(string dni, string pass)
        {
            List<User> users = new List<User>();
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
                                "image," +
                                "pass " +
                            "FROM users " +
                            "WHERE dni = @1 AND pass = @2";

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@1", dni);
                pass = enc.Encrypt(pass);
                //Rl1TYn+pBQc=
                //Rl1TYn+pBQc=
                cmd.Parameters.AddWithValue("@2", pass);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DataRow row = ds.Tables[0].Rows[i];

                        User user = new User();

                        user.Id = (int)row["user_id"];
                        user.Dni = (long)row["dni"];
                        user.FirstName = row["first_name"].ToString();
                        user.LastName = row["last_name"].ToString();
                        user.Email = row["email"].ToString();
                        user.Address = row["address"].ToString();
                        user.PhoneNumber1 = long.Parse(row["phone_number1"].ToString());
                        user.PermissionLevel = (int)row["permission_level"];
                        user.Image = row["image"];
                        user.Status = (int)row["status"];
                        user.Pass = row["pass"].ToString();

                        users.Add(user);
                    }
                }
            }
            var json = JsonConvert.SerializeObject(users);
            return Request.CreateResponse(HttpStatusCode.OK, json);
        }

        // POST: api/User
        public HttpResponseMessage Post([FromBody]User user)
        {
            string query = "" +
                "INSERT INTO users (" +
                "dni," +
                "first_name," +
                "last_name," +
                "email," +
                "address," +
                "phone_number1," +
                "phone_number2," +
                "image," +
                "pass) values (" +
                "@1,@2,@3,@4,@5,@6,@7,@8,@9)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();

                }
            }
            catch (Exception ex)
            {
                
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
