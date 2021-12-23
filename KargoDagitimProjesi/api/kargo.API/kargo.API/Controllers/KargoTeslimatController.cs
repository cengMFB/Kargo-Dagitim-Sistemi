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
    public class KargoTeslimatController : ApiController
    {

        public KargoTeslimatController()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception)
            {

                Console.WriteLine("Bağlantınızı kontrol ediniz");

            }
        }

        FirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "R28Rim9UK5cosD1GIDznhtbX0Y88zviOtWenuSQK",
            BasePath = "https://kargo-api-9bcd1-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        FirebaseResponse response;


        public HttpResponseMessage GetTeslimat()
        {
            DataTable data = new DataTable();
            data.Columns.Add("MüsteriID");
            data.Columns.Add("MüsteriAd");
            data.Columns.Add("Enlem");
            data.Columns.Add("Boylam");
            data.Columns.Add("KargoID");
            response = client.Get("Teslimat Listesi/");
            Dictionary<string, KargoTeslimat> teslimat = response.ResultAs<Dictionary<string, KargoTeslimat>>();
            foreach (var get in teslimat)
            {
                data.Rows.Add(get.Value.MüsteriID, get.Value.MüsteriAd, get.Value.Enlem, get.Value.Boylam, get.Value.KargoID);
            }
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

    }
}
