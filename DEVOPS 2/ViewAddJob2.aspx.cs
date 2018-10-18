using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using TypeLibrary.ViewModels;
using TypeLibrary.Models;
using TypeLibrary.Interfaces;
using System.Data;

namespace DEVOPS_2
{
    public partial class ViewAddJob2 : System.Web.UI.Page
    {
        IDBHandler handler = new DBHandler();
        UspGetAllJobPosts jp = new UspGetAllJobPosts();
        
        protected void Page_Load(object sender, EventArgs e)
            
        {
            //jp.employerID = Convert.ToInt32("1");
            //GridView1.DataSource = handler.BLL_GetAllJobPosts(employerID);
            //GridView1.DataBind();
            GridView1.DataSource = handler.BLL_GetAllJobPosts();
            
            
            GridView1.DataBind();
        }
    }
}