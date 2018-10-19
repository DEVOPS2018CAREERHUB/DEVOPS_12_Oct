using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypeLibrary.ViewModels
{
    public class UspGetMostRecentStudents
    {
        //public byte[] profilePicture { get; set; }
        public int StudentNo { get; set; }
        public string Student { get; set; }
        public string CityDescription { get; set; }
        public string QualificationDescription { get; set; }
        public string SkillDescription { get; set; }
        public string StudentEmail { get; set; }
        //public byte CV { get; set; }
    }
}