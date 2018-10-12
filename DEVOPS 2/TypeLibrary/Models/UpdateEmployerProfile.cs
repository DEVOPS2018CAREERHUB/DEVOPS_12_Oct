using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLibrary.Models
{
    public class UpdateEmployerProfile
    {
        public string employerName { get; set; }
        public string employerDescription { get; set; }
        public int cityID { get; set; }
        public int countryID { get; set; }
        public string email { get; set; }
        public string vatNo { get; set; }
        public byte[] logo { get; set; }
        public string employerUserName { get; set; }
        public string employerPassword { get; set; }
        public string contactPerson { get; set; }
        public string contactEmail { get; set; }
        public int statusID { get; set; }
        public int industryID { get; set; }
    }
}
