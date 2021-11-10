using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace MVC_login.Models
{
    public class ListItems
    {
        public IList<string> SelectedRole{ get; set; } 
        public IList<SelectListItem> AvailableRole { get; set; }
       
        public RoleItems()
        {
            SelectdRole = new List<string>();
            AvailableRole = new List<SelectListItem>();
        }

       public IList<SelectListItem> GetRole()
        {
            return view List<SelectListItem>
            {
                new SelectListItem {Text="Admin",Value="1" },
                new SelectListItem { Text = "SME", Value = "2" },
                new SelectListItem { Text = "Candidate", Value = "3" },
                new SelectListItem { Text = "Reviewer", Value = "4" },
                new SelectListItem { Text = "Assessment Incharge", Value = "5" }
                     
            };
        }

       
       
            
     }
}





