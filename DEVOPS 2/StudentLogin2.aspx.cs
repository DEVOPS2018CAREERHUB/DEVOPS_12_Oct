using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using TypeLibrary.ViewModels;


namespace Project_DevOps
{
    public partial class StudentLogin2 : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        UspCheckStudentLogin studLogin = new UspCheckStudentLogin();
        protected void Page_Load(object sender, EventArgs e)
        {
            int sStudentno = studLogin.studentNo;
            string sStudentPass = studLogin.studentPassword; 
            errorLbl.Visible = false;

        }

        protected void EmpBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployerLogin.aspx");
        }

        protected void StudBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentLogin02.aspx");
        }

        protected void studUsernametxt_TextChanged(object sender, EventArgs e)
        {

        } 

        protected void studPasswordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Create_Student_Profile.aspx");
        }

        protected void studLoginBtn_Click(object sender, EventArgs e)
        {
            int sStudentno = studLogin.studentNo;
            string sStudentPass = studLogin.studentPassword;
            string studentNo = studUsernametxt.Text;
            string studentPassword = studPasswordtxt.Text;
            if (studentNo == studUsernametxt.Text && studentPassword == studPasswordtxt.Text )
            {
                Response.Redirect("Landing_Page.aspx");
            }

            else
            {
                errorLbl.Visible = true;
            }
        }

        protected void nmuBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.mandela.ac.za/");
        }
    }
}