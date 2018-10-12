using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypeLibrary.ViewModels
{
    public class UspGetStudentProfile
    {
        
        public string studentFirstName { get; set; }
        public string studentLastName { get; set; }
        public DateTime studentDateofBirth { get; set; }
        public string countryDescription { get; set; }
        public string cityDescription { get; set; }
        public string studentEmail { get; set; }
        public string studentContactNo { get; set; }
        public string industryDescription { get; set; }
        public string qualificationDescription { get; set; }
        public string skillDescription { get; set; }
        public string driversLicense { get; set; }
        public byte[] studentProfilePicture { get; set; }
        public string studentUsername { get; set; }
        public string studentPassword { get; set; }
        public byte[] CV { get; set; }
        public DateTime lastUpdate { get; set; }
    }
}