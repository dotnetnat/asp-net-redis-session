using JsonAtttrSerialize.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace JsonAtttrSerialize.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public async Task<ActionResult> Data()
        {
            var user = new UserModel();
            user.Id = 1;
            user.Name = "DotnetNat";
            user.Age = 39;
            user.Address = new Address();
            user.Address.No = 20;
            return ToJson<UserModel>(user);
        }
        public JsonResult ToJson<T>(object response)
        {
            return ToJson(response);
        }
        private static JsonResult ToJson(object data)
        {
            return new JsonNetResult
            {
                Data = data,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Settings = { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }
            };
        }
    }
}
