using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypeLibrary.ViewModels
{
    public class UspGetAllStudentsForAdmin
    {
        public int studentNo { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime studentDateOfBirth { get; set; }
        public string countryDescription { get; set; }
        public string cityDescription { get; set; }
        public string studentEmail { get; set; }
        public string contactNo { get; set; }
        public string industryDescription { get; set; }
        public string qualDescription { get; set; }
        public string skillDescription { get; set; }
        public string driversLicence { get; set; }
        //public byte[] profilePicture { get; set; }
        public string studentUsername { get; set; }
        //public string studentPasssword { get; set; }
        //public byte[] cv { get; set; }
        //public DateTime cvDate { get; set; }
        //public int statusID { get; set; }
        public DateTime lastUpdated { get; set; }
    }
}