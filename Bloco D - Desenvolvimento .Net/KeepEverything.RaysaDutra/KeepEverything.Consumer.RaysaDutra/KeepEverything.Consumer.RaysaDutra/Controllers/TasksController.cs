using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace KeepEverything.Consumer.RaysaDutra.Controllers
{
    public class TasksController : Controller
    {
        
        // GET: Tag
        public ActionResult Tag()
        {
            return View();
        }

        // GET: Category
        public ActionResult Category()
        {
            return View();
        }
    }
}
