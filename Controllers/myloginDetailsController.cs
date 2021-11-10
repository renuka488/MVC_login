using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_login.Models;
using MVC_login.Infrastructure.Repository;
using MVC_login.Infrastructure;


namespace MVC_login.Controllers
{
    public class myloginDetailsController : Controller
    {

        ILoginRepository objRepo = new LoginRepository();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(myloginEntity entity)
        {
            myloginEntity Returnentity;
            Returnentity = objRepo.GetAllMyloginDetails(entity);
            if (Returnentity.Id > 0)
            {
                return View(Returnentity);
            }
            else
            {
                return RedirectToAction("Registration");
            }

        }

       

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(myloginEntity entity)
        {
            string msg = objRepo.CreateRegistation(entity);
                 if (msg.ToLower().Equals("success"))
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        [HttpGet]
        public ActionResult ULRegistration(myloginEntity entity)
        {
            string msg = objRepo.UpdateRegistation(entity);
            if (msg.ToLower().Equals("success"))
            {
                return RedirectToAction("Login");
            }
            return View();




        }
        [HttpPost]
        public ActionResult ULRegistration()
        {
            return View();
        }
    }
    
}

   

  