using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using VillaTracking.Web.models;
using MySql.Data.MySqlClient;
using VillaTracking.Web.data;
using System.Data;

namespace VillaTracking.Web.services
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class villaservice
    {
        // Para usar HTTP GET, agregue el atributo [WebGet]. (El valor predeterminado de ResponseFormat es WebMessageFormat.Json)
        // Para crear una operación que devuelva XML,
        //     agregue [WebGet(ResponseFormat=WebMessageFormat.Xml)]
        //     e incluya la siguiente línea en el cuerpo de la operación:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";        
        [OperationContract]        
        public Client GetClient(string dni, string pass)
        {
            Client client = new Client();
            try
            {                
                Procedure proc = new Procedure();
                Encryptation enc = new Encryptation();                
                string query = "select * from clients where dni = @1 and web_pass = @2";

                using (MySqlConnection conn = new MySqlConnection(proc.StrConn))
                {
                    if (conn.State != ConnectionState.Open) conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@1", dni);
                    cmd.Parameters.AddWithValue("@2", enc.Encrypt(pass));
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);                                     

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];
                        client.Id = (int)row["client_id"];
                        client.Dni = row["dni"] == null ? "" : row["dni"].ToString();
                        client.FirstName = row["first_name"] == null ? "" : row["first_name"].ToString();
                        client.LastName = row["last_name"] == null ? "" : row["last_name"].ToString();
                        client.Email = row["email"] == null ? "" : row["email"].ToString();
                        client.PhoneNumber1 = row["phone_number1"] == null ? "" : row["phone_number1"].ToString();
                        client.PhoneNumber2 = row["phone_number2"] == null ? "" : row["phone_number2"].ToString();
                        client.Address = row["address"] == null ? "" : row["address"].ToString();                        
                        client.Status = (int)row["status"];                       
                    }
                }                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return client;
        }
    }
}
