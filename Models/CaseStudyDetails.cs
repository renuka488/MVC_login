using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_login.Models
{
    public class CaseStudyDetails
    {
        public int CSID { get;set;}
        public string  CaseStudy { get; set; }
        public string  CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool ReviewStatus { get; set; }

        public string SolutionDescription1 { get; set; } 
        public int CompID1 { get; set; }
        public string SolutionDescription2 { get; set; }
        public int CompID2 { get; set; }
        public string SolutionDescription3 { get; set; }
        public int CompID3 { get; set; }
        public string SolutionDescription4 { get; set; }
        public int CompID4 { get; set; }

        //public CaseStudySolution Solution1 { get; set; }
        //public CaseStudySolution Solution2 { get; set; }
        //public CaseStudySolution Solution3 { get; set; }
        //public CaseStudySolution Solution4 { get; set; }
    }
}