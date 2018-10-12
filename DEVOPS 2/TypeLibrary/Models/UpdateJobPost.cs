using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypeLibrary.Models
{
    public class UpdateJobPost
    {
        public int jobID { get; set; }
        public string jobTitle { get; set; }
        public DateTime dateClosing { get; set; }
        public int cityID { get; set; }
        public int countryID { get; set; }
        public string jobDescription { get; set; }
        public string keyResponsibilities { get; set; }
        public int qualID { get; set; }
        public int skillID { get; set; }
        public int typeID { get; set; }
        public int duration { get; set; }
        public DateTime startDate { get; set; }
        public int employerID { get; set; }
        public string postedBy { get; set; }
        public int statusID { get; set; }

    }
}