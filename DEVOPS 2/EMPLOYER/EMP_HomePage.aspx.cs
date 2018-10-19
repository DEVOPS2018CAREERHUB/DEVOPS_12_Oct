using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using TypeLibrary.Models;
using TypeLibrary.Interfaces;
using BLL;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DEVOPS_2.EMPLOYER
{
    public partial class EMP_HomePage : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtStudentNo.Text = Request.QueryString["studentNumber"];
        }
    }
}