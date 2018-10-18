using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using TypeLibrary.ViewModels;
using DAL;

namespace DEVOPS_2
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        DBHandler bll_handler = new DBHandler();
        UspGetAdminLogin gal = new UspGetAdminLogin();
        DBAccess get = new DBAccess();    
            
        protected void Page_Load(object sender, EventArgs e)
        {
            string sAdminUsername = gal.adminUsername;
            string sAdminPassword = gal.adminPassword;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string sAdminUsernameDB = gal.adminUsername;
            string sAdminPasswordDB = gal.adminPassword;
            string sAdminUsername = gal.adminUsername;
            string sAdminPassword = gal.adminPassword;
            string adminUsername1 = txtAdminUsername.Text;
            string adminPassword1 = txtAdminPassword.Text;
            
            if(adminUsername1 == sAdminUsername && adminPassword1 == sAdminPassword)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You have logged in as admin');</script>");
                Response.Redirect("AdminPage.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Invalid Admin credentials');</script>");
            }
        }
    }
}