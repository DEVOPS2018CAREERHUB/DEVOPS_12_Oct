using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using TypeLibrary.Models;
using BLL;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace DEVOPS_2
{
    public partial class Create_Student_Profile : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                txtStudentNo.Text = Request.QueryString["studentNumber"];
                txtStudPassword.Text = Request.QueryString["Spassword"];
                txtEmail.Text = Request.QueryString["Semail"];
                txtStudentNo.Enabled = false;
                //txtStudPassword.TextMode = TextBoxMode.Password;
                txtStudPassword.Enabled = false;
                txtEmail.Enabled = false;
                lblLastUpdated2.Text = DateTime.Now.ToString();

                ddlCountries.DataSource = BLL_handler.BLL_GetAllCountries();
                ddlCountries.DataTextField = "CountryDescription";
                ddlCountries.DataValueField = "CountryID";
                ddlCountries.DataBind();

                ddlCities.DataSource = BLL_handler.BLL_GetAllCities();
                ddlCities.DataTextField = "CityDescription";
                ddlCities.DataValueField = "CityID";
                //ddlCities.SelectedIndex = int.Parse("CityID");
                ddlCities.DataBind();

                ddlIndustry.DataSource = BLL_handler.BLL_GetAllIndustries();
                ddlIndustry.DataTextField = "IndustryDescription";
                ddlIndustry.DataValueField = "IndustryID";
                ddlIndustry.DataBind();
            }
        }

        protected void btnCreateSProfile_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            
            
            HttpPostedFile profilePicture1;
            HttpPostedFile cv1;
            try
            {
                addStudent.studentNo = int.Parse(txtStudentNo.Text);
                addStudent.studentFirstName = txtFisrtName.Text;
                addStudent.studentLastName = txtLastName.Text;
                addStudent.studentDateOfBirth = DateTime.Parse(txtDateofBirth.Text);
                addStudent.countryID = Convert.ToInt32(ddlCountries.SelectedItem.Value);
                addStudent.cityID = Convert.ToInt32(ddlCities.SelectedItem.Value);
                addStudent.studentEmail = txtEmail.Text;
                addStudent.studentContactNo = txtContactNo.Text;
                addStudent.industryID = Convert.ToInt32(ddlIndustry.SelectedItem.Value);
                addStudent.qualificationID = 1;
                addStudent.skillID = 1;

                if (rbtnDriversYes.Checked == true)
                {
                    addStudent.driversLicence = "yes";
                }
                else
                {
                    addStudent.driversLicence = "no";
                }
                //profile picture!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                
                /////////////////////////////////////////////////////////////end image add


                profilePicture1 = uploadImage.PostedFile;
                int profilepictureint = profilePicture1.ContentLength;
                byte[] bytImg = new byte[profilepictureint];
                addStudent.profilePicture = bytImg;
                addStudent.studentUsername = txtStudUsername.Text;
                addStudent.studentPassword = txtStudPassword.Text;
                //CV!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                cv1 = uploadCV.PostedFile;
                int cvint = cv1.ContentLength;
                byte[] bytCV = new byte[cvint];
                addStudent.cv = bytCV;
                addStudent.cvDate = DateTime.Now;
                addStudent.lastUpdate = DateTime.Now;
                addStudent.statusID = 1;

                BLL_handler.BLL_AddStudent(addStudent);
                
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You have successfully created your profile');</script>");
            }catch(Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('There was a problem with creating your profile. Please retype all the fields');</script>");
                txtStudentNo.Text = "";
                txtFisrtName.Text = "";
                txtLastName.Text = "";
                txtDateofBirth.Text = "";
                                            /////////////////////////////////add city
                txtEmail.Text = "";
                txtContactNo.Text = "";
                txtStudUsername.Text = "";
                txtStudPassword.Text = "";
            }
            Response.Redirect("View_Student_Profile.aspx?studentNumber=" + txtStudentNo.Text);

        }

        public void btnImageUpload_Click(object sender, EventArgs e)
        {
            
            HttpPostedFile profilePicture = uploadImage.PostedFile;
            
        }
    }
}