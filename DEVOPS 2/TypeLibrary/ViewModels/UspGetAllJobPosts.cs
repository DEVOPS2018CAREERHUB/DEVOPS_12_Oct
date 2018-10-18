using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLibrary.ViewModels
{
    public class UspGetAllJobPosts
    {
        public int employerID { get; set; }
        public int JobID { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateClosing { get; set; }
        public string CountryDescription { get; set; }
        public string CityDescription { get; set; }
        public string JobDescription { get; set; }
        public string KeyResponsebilities { get; set; }
        public string QualificationDescription { get; set; }
        public string SkillDescription { get; set; }
        public string TypeDescription { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public string PostedBy { get; set; }
        public string StatusDescription { get; set; }
    }
}
