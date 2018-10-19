using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypeLibrary.ViewModels
{
    public class UspGetSelectedStudentDetails
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentEmail { get; set; }
        public string ContactNo { get; set; }

        public string CityDescription { get; set; }
        public string DriversLicense { get; set; }
        //public byte[] profilePicture { get; set; }
        public string QualificationDescription { get; set; }
        public string SkillDescription { get; set; }
        //public byte[] cv { get; set; }
        //public DateTime cvDate { get; set; }
    }
}