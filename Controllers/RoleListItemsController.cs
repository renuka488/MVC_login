using MVC_login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_login.Controllers
{
    public class RoleListItemsController : Controller
    {
        RoleListItems objItems = new RoleListItems();
        public ActionResult Dropdownlist()
        {
            RoleListItems obj = new RoleListItems();
            obj.AvailableRole = objItems.GetRole();
            return View(obj);
        }
        [HttpPost]
        public ActionResult Dropdownlist(RoleListItems Model)
        {
            return View(Model);
        }
    }
}