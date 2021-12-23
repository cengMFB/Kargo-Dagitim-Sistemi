using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace kargo.API.Controllers
{
    public class UsersController : ApiController
    {

        public UsersController()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                Console.WriteLine("Bağlantınızı kontrol ediniz");
            }
        }
        FirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "R28Rim9UK5cosD1GIDznhtbX0Y88zviOtWenuSQK",
            BasePath = "https://kargo-api-9bcd1-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        FirebaseResponse response;

        public HttpResponseMessage GetUsers()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Password");
            dt.Columns.Add("Username");
            response = client.Get("Users/");
            Dictionary<string, Users> user = response.ResultAs<Dictionary<string, Users>>();
            foreach (var u in user)
            {
                dt.Rows.Add(u.Value.Password,u.Value.Username);
            }
            
            return Request.CreateResponse(HttpStatusCode.OK,dt);

            
        }
        
        
                

     
    }
}
