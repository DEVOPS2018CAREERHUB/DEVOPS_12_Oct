using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using TypeLibrary.ViewModels;
using System.Web.Security;


namespace Project_DevOps
{
    public partial class EmployerLogin : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        UspCheckEmployerLogin checkEmp = new UspCheckEmployerLogin();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            string sEmpEmail = checkEmp.employerEmail;
            string sEmpPassword = checkEmp.employerPassword;
            errorLbl.Visible = false;
        }

        protected void empBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployerLogin.aspx");
        }

        protected void studBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentLogin2.aspx");
        }

        protected void nmuBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.mandela.ac.za/");
        }


        //public string username
        //{
        //    get
        //    { 
        //        return empUsernametxt.Text;
        //    }
        //}

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void empLoginBtn_Click(object sender, EventArgs e)
        {

            string sEmpEmail = checkEmp.employerEmail;
            string sEmpPassword = checkEmp.employerPassword;
            string empEmail = empUsernametxt.Text;
            string empPassword = empPasswordtxt.Text;

            if (empEmail == empUsernametxt.Text && empPassword == empPasswordtxt.Text)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You have successfully Logged in');</script>");
                Response.Redirect("AddJob.aspx");
            }
            else
            {
                errorLbl.Visible = true;
            }


        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            //UspCheckEmployerLogin check = new UspCheckEmployerLogin();
            //string sUN = Login1.UserName;
            //string sPW = Login1.Password;
            ////bool result = check(sUN, sPW);
            //if (Login1.UserName == check.employerEmail && Login1.Password == check.employerPassword)
            //{
            //    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You have successfully Logged in');</script>");
            //    Response.Redirect("AddJob.aspx");
            //}

            //else
            //{
            //    errorLbl.Text = "invalid";
            //}
        }
    }
}