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
    public partial class AdminPage : System.Web.UI.Page
    {
        IDBHandler handler = new DBHandler();
        DBHandler BLL_handler = new DBHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvStudents.DataSource = handler.BLL_GetAllStudents();
            dgvStudents.DataBind();
            btnDeleteStudent.Text = "Delete Student";
        }

        protected void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent ds = new DeleteStudent();
            DeleteEmployer de = new DeleteEmployer();

            if (Label1.Text == "Students")
            {
                btnDeleteStudent.Text = "Delete Student";
                int studentNo = int.Parse(txtStudentNoDelete.Text);
                ds.studentNumber = int.Parse(txtStudentNoDelete.Text);
                handler.BLL_DeleteStudent(ds);
                dgvStudents.DataSource = handler.BLL_GetAllStudents();
                dgvStudents.DataBind();
                txtStudentNoDelete.Text = "";

            }
            else if(Label1.Text == "Employers")
            {
                btnDeleteStudent.Text = "Delete Employer";
                int employerID = int.Parse(txtStudentNoDelete.Text);
                de.employerID = int.Parse(txtStudentNoDelete.Text);
                handler.BLL_DeleteEmployer(de);
                dgvStudents.DataSource = handler.BLL_GetAllEmployers();
                dgvStudents.DataBind();
                txtStudentNoDelete.Text = "";
            }


            

            
        }

        protected void btnStudents_Click(object sender, EventArgs e)
        {
            btnDeleteStudent.Text = "Delete Student";
            dgvStudents.DataSource = handler.BLL_GetAllStudents();
            dgvStudents.DataBind();
            Label1.Text = "Students";
            txtStudentNoDelete.TextMode = TextBoxMode.Number;
            lblENterStudNotoDelete.Text = "Enter Student Number to delete student:";
        }

        protected void btnEmployers_Click(object sender, EventArgs e)
        {
            btnDeleteStudent.Text = "Delete Employer";
            dgvStudents.DataSource = handler.BLL_GetAllEmployers();
            dgvStudents.DataBind();
            Label1.Text = "Employers";
            lblENterStudNotoDelete.Text = "Enter Employer ID to delete employer:";
            txtStudentNoDelete.TextMode = TextBoxMode.Number;
        }
    }
}