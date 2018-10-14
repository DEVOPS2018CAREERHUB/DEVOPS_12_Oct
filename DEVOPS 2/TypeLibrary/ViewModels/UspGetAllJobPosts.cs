using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLibrary.ViewModels
{
    class UspGetAllJobPosts
    {
        public string JobTitle { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateClosing { get; set; }
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public string JobDescription { get; set; }
        public string KeyResponsibilities { get; set; }
        public int QualID { get; set; }
        public int SkillID { get; set; }
        public int TypeID { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public int EmployerID { get; set; }
        public string PostedBy { get; set; }
        public int StatusID { get; set; }
    }
}
