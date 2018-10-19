using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypeLibrary.ViewModels
{
    public class UspGetSelectedJobDetails
    {
        public int EmployerID { get; set; }
        public int JobID { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateClosing { get; set; }
        public string TypeDescription { get; set; }
        public string CityDescription { get; set; }
        public string JobDescription { get; set; }
        public string KeyResponsibilities { get; set; }
        public string QualificationDescription { get; set; }
        public string SkillDescription { get; set; }


    }
}