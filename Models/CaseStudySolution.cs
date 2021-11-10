using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_login.Models
{
    public class CaseStudySolution
    {
        public int CSID { get;set;}
        public string  CaseStudy { get;set;}
        public string  CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool  IsActive { get; set; }
        public bool  ReviewStatus { get; set; }



    }  
}


    
 				