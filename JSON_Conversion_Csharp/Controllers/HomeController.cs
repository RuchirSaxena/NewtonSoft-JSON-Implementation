using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JSON_Conversion_Csharp.Models;
using Newtonsoft.Json;

namespace JSON_Conversion_Csharp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<UserDetails> userDetail = new List<UserDetails>();
            userDetail.Add(new UserDetails {
                UserId=1,
                Username="Ruchir Saxena",
                Location="Noida"
            });
            userDetail.Add( new UserDetails
            {
                UserId = 2,
                Username = "Amit",
                Location = "Mumbai"
            });
            string serilazedObject = JsonConvert.SerializeObject(userDetail);
            return Json(serilazedObject, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetJsonFromClient(string jsonString)
        {
           List<UserDetails> userDetail = JsonConvert.DeserializeObject<List<UserDetails>>(jsonString);
           return Json("Sucess");
        }
    }

}