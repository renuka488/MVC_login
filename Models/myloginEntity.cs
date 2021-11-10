using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_login.Models
{
    public class myloginEntity
    {
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get;  set; }
        public string EmailAddress { get;  set; }
        public string MobileNumber { get;  set; }
        public string EmployeeID { get; set; }

        public int Id { get; set; }
    }
}