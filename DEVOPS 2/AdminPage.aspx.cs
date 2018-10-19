using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using TypeLibrary.Interfaces;
using TypeLibrary.Models;
using TypeLibrary.ViewModels;

namespace DEVOPS_2
{
    public partial class AdminPage : System.Web.UI.Page
    {
        IDBHandler handler = new DBHandler();
        DBHandler BLL_handler = new DBHandler();
        UspNumberOfStudents nos = new UspNumberOfStudents();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            dgvStudents.DataSource = handler.BLL_GetAllStudents();
            dgvStudents.DataBind();
            btnDeleteStudent.Text = "Delete Student";
            txtNumberOfStudents.Text = nos.ToString();
        }

        protected void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent ds = new DeleteStudent();
            DeleteEmployer de = new DeleteEmployer();
            DeleteStudentSkill dss = new DeleteStudentSkill();
            DeleteStudentQual dsq = new DeleteStudentQual();

            if (Label1.Text == "Students")
            {
                btnDeleteStudent.Text = "Delete Student";
                int studentNo = int.Parse(txtStudentNoDelete.Text);
                ds.studentNumber = int.Parse(txtStudentNoDelete.Text);
                dss.studentNumber = int.Parse(txtStudentNoDelete.Text);
                dsq.studentNumber = int.Parse(txtStudentNoDelete.Text);
                handler.BLL_DeleteStudentSkill(dss);
                handler.BLL_DeleteStudentQual(dsq);
                handler.BLL_DeleteStudent(ds);
                dgvStudents.DataSource = handler.BLL_GetAllStudents();
                dgvStudents.DataBind();
                txtStudentNoDelete.Text = "";

            }
            else if(Label1.Text == "Employers")
            {
                btnDeleteStudent.Text = "Delete Employer";
                //int employerID = int.Parse(txtStudentNoDelete.Text);
                de.employerName = txtStudentNoDelete.Text;
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
            lblENterStudNotoDelete.Text = "Enter Employer name to delete employer:";
            txtStudentNoDelete.TextMode = TextBoxMode.SingleLine;
        }
    }
}