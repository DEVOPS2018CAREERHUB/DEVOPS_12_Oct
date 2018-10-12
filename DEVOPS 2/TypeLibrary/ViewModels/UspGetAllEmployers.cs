using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypeLibrary.ViewModels
{
    public class UspGetAllEmployers
    {
        public int employer_id { get; set; }
        public string employerName { get; set; }
        public string employerDescription { get; set; }
        public int CityID { get; set; }
        public int countryID { get; set; }
        public string email { get; set; }
        public string vatNo { get; set; }
        //public Byte[] logo { get; set; }
        public string employerUsername { get; set; }
        public string employerPassword { get; set; }
        public string contactPerson { get; set; }
        public string contactEmail { get; set; }
        public int statusID { get; set; }
        public int industryID { get; set; }
    }
}