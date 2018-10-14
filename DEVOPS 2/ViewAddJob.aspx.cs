using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using TypeLibrary.Interfaces;
using TypeLibrary.Models;

namespace DEVOPS_2
{
    public partial class ViewAddJob : System.Web.UI.Page
    {
        IDBHandler handler = new DBHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewAddJob.DataSource = handler.BLL_GetAllStudents();
            GridViewAddJob.DataBind();
        }
    }
}