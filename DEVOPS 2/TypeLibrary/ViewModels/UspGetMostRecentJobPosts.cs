using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypeLibrary.ViewModels
{
    public class UspGetMostRecentJobPosts
    {
        //public Byte[] Logo { get; set; }
        public int JobID { get; set; }
        public string JobTitle { get; set; }
        public string CityDescription { get; set; }
        public string TypeDescription { get; set; }
        public DateTime DateClosing { get; set; }
    }
}