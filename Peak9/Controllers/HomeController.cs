using Peak9.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Peak9.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Answer(string url)
        {
            var result = Summit.Request(url);
            var success = Newtonsoft.Json.JsonConvert.DeserializeObject<Peak9.Models.Success>(result);
            return PartialView(success);
        }
    }
}