using Nuget_CodeFirst_Sampler.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nuget_CodeFirst_Sampler.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DatabaseContext db = new DatabaseContext();
            db.Customers.ToList();
            return View();
        }
    }
}