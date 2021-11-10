using MVC_login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_login.Infrastructure
{
    interface ILoginRepository
    {
       myloginEntity GetAllMyloginDetails(myloginEntity entity);
        
       string CreateRegistation(myloginEntity entity);
       string UpdateRegistation(myloginEntity entity);
       string Insertcasestudy(CaseStudyDetails entity);


    }
}
