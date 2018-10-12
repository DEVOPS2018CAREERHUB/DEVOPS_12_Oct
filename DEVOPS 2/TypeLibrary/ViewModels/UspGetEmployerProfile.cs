using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TypeLibrary.ViewModels
{
    public class UspGetEmployerProfile
    {
        public string employerName { get; set; }
        public string employerDescription { get; set; }
        public string countryDescription { get; set; }
        public string cityDescription { get; set; }
        public string employerEmail { get; set; }
        public string vatNo { get; set; }
        public byte[] logo { get; set; }
        public string employerUsername { get; set; }
        public string employerPassword { get; set; }
        public string contactPerson { get; set; }
        public string contactEmail { get; set; }
        public string industryDescription { get; set; }
    }
}