using MVC_login.Infrastructure.Repository;
using MVC_login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_login.Controllers
{ 
    public class CaseStudyController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
       [HttpPost]
        public ActionResult Index(CaseStudyDetails enity)
        {
            //  return View(enity);
            LoginRepository obj = new LoginRepository();
            obj.Insertcasestudy(enity);
            return View();
        }
    }
}