using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_login.Models
{
    public class RoleListItems
    {
       
        public IList<string> SelectedRole { get; set; }
        public IList<SelectListItem> AvailableRole { get; set; }

        public RoleListItems()
        {
            SelectedRole = new List<string>();
            AvailableRole = new List<SelectListItem>();
        }

        public IList<SelectListItem> GetRole()
        {
            return new List<SelectListItem>
                {
                   new SelectListItem { Text = "Admin", Value = "1" },
                   new SelectListItem { Text = "SME", Value = "2" },
                   new SelectListItem { Text = "Candidate", Value = "3" },
                   new SelectListItem { Text = "Reviewer", Value = "4" },
                   new SelectListItem { Text = "Assessment Incharge", Value = "5" }


               };
        }
    }
}