using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLibrary.Models
{
    public class AddStudent
    {
        public int studentNo { get; set; }
        public string studentFirstName { get; set; }
        public string studentLastName { get; set; }
        public DateTime studentDateOfBirth { get; set; }
        public int countryID { get; set; }
        public int cityID { get; set; }
        public string studentEmail { get; set; }
        public string studentContactNo { get; set; }
        public int industryID { get; set; }
        public int qualificationID { get; set; }
        public int skillID { get; set; }
        public string driversLicence { get; set; }
        public byte[] profilePicture { get; set; }
        public string studentUsername { get; set; }
        public string studentPassword { get; set; }
        public byte[] cv { get; set; }
        public DateTime cvDate { get; set; }
        public int statusID { get; set; }
        public DateTime lastUpdate { get; set; }
    }
}
