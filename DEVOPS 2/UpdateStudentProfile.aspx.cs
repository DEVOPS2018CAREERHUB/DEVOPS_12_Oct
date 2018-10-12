using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TypeLibrary.Models;
using TypeLibrary.Interfaces;
using TypeLibrary.ViewModels;
using BLL;

namespace DEVOPS_2
{
    public partial class UpdateStudentProfile : System.Web.UI.Page
    {
        IDBHandler handler = new DBHandler();
        
        DBHandler BLL_handler = new DBHandler();

        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCountries.DataSource = handler.BLL_GetAllCountries();
            ddlCountries.DataTextField = "CountryDescription";
            ddlCountries.DataValueField = "CountryID";
            ddlCountries.DataBind();

            ddlCities.DataSource = handler.BLL_GetAllCities();
            ddlCities.DataTextField = "CityDescription";
            ddlCities.DataValueField = "CityID";
            ddlCities.DataBind();

            int studentNo = 213456854;                                  /////////////////////////////////////////////////////////
            UspGetStudentProfile vs = handler.BLL_GetStudentProfile1(studentNo);

            txtStudentNo.Text = "215333608";
            txtFirstName.Text = vs.studentFirstName;
            txtEmail.Text = vs.studentEmail;
            txtLastName.Text = vs.studentLastName;
            txtDateofBirth.Text = vs.studentDateofBirth.ToString();
            //txtc.Text = vs.countryDescription.ToString();
            //ddlCities.Text = vs.cityDescription.ToString();
            txtEmail.Text = vs.studentEmail;
            txtContactNo.Text = vs.studentContactNo;
            //txtIndustry.Text = vs.industryDescription.ToString();
            //txtQualifications.Text = vs.qualificationDescription.ToString();
            txtSkills.Text = vs.skillDescription.ToString();
            
            if(vs.driversLicense == "yes")
            {
                rbtnDriversYes.Checked = true;
            }
            else
            {
                rbtnDriversNo.Checked = true;
            }
            //byte[] bytes = (byte[])vs.studentProfilePicture;
            //string base64String = Convert.ToBase64String(bytes);
            //Image1.ImageUrl = "data:image/png;base64," + bytes;

            //DataTable dt = (DataTable)Session["dt"];
            //Image1.ImageUrl = dt.Rows[0][4].ToString() + vs.StudentProfilePicture;

            //Image1.ImageUrl = base64String;
            txtStudUsername.Text = vs.studentUsername;
            txtStudPassword.Text = vs.studentPassword;
            lblLastUpdated2.Text = vs.lastUpdate.ToString();
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            TypeLibrary.Models.UpdateStudentProfile usp = new TypeLibrary.Models.UpdateStudentProfile();
            HttpPostedFile profilePicture1;
            HttpPostedFile cv1;
            int studentNo = 215333608; ///////////////////////////////////////////////////////////////////////////////////////////
            usp.studentNo = studentNo;
            usp.firstName = txtFirstName.Text;
            usp.lastName = txtLastName.Text;
            usp.dateOfBirth = DateTime.Parse(txtDateofBirth.Text);
            usp.countryID = int.Parse(ddlCountries.Text);
            usp.cityID = Convert.ToInt32(ddlCities.SelectedItem);
            usp.email = txtEmail.Text;
            usp.contactNo = txtContactNo.Text;
            usp.industryID = 1;
            usp.qualID = 1;
            usp.skillID = 1;

            if (rbtnDriversYes.Checked == true)
            {
                usp.drivers = "yes";
            }
            else
            {
                usp.drivers = "no";
            }

            profilePicture1 = uploadImage.PostedFile;
            int profilepictureint = profilePicture1.ContentLength;
            byte[] bytImg = new byte[profilepictureint];
            usp.profilePicture = bytImg;
            usp.studentUsername = txtStudUsername.Text;
            usp.studentPassword = txtStudPassword.Text;
            //CV!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            cv1 = uploadCV.PostedFile;
            int cvint = cv1.ContentLength;
            byte[] bytCV = new byte[cvint];
            usp.cv = bytCV;
            usp.cvDate = DateTime.Now;
            usp.lastUpdated = DateTime.Now;
            usp.statusID = 1;

            BLL_handler.BLL_UpdateStudentProfile(usp);

        }
    }
}