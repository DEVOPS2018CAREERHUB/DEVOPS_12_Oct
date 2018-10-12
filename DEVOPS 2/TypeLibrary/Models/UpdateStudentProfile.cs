using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLibrary.Models
{
    public class UpdateStudentProfile
    {
        public int studentNo { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int countryID { get; set; }
        public int cityID { get; set; }
        public string email { get; set; }
        public string contactNo { get; set; }
        public int industryID { get; set; }
        public int qualID { get; set; }
        public int skillID { get; set; }
        public string drivers { get; set; }
        public byte[] profilePicture { get; set; }
        public string studentUsername { get; set; }
        public string studentPassword { get; set; }
        public byte[] cv { get; set; }
        public DateTime cvDate { get; set; }
        public int statusID { get; set; }
        public DateTime lastUpdated { get; set; }
    }
}
