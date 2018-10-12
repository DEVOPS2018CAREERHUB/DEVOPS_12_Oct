using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using TypeLibrary.Models;
using TypeLibrary.ViewModels;
using TypeLibrary.Interfaces;
using DAL;
using System.Data;
using DEVOPS_2;

namespace DEVOPS_2
{
    public partial class View_Student_Profile : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        List<UspGetStudentProfile> vs1 = new List<UspGetStudentProfile>();
        IDBHandler handler = new DBHandler();


        protected void Page_Load(object sender, EventArgs e)
        {
            int studentNo1 = 215333608;
            btnDownloadCV.Visible = false;
            BLL_handler.BLL_GetStudentProfile(studentNo1);
            
            btnCV.Visible = false;
            btnCV.Enabled = false;

            txtCity.Enabled = false;
            txtContactNumber.Enabled = false;
            txtCountry.Enabled = false;
            txtDateOfBirth.Enabled = false;
            txtDrivers.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtIndustry.Enabled = false;
            txtLastName.Enabled = false;
            txtLastUpdated.Enabled = false;
            txtQualifications.Enabled = false;
            txtSkills.Enabled = false;
            txtStudentNumber.Enabled = false;
            txtStudentPassword.Enabled = false;
            txtStudentUsername.Enabled = false;
            
            

            int studentNo = 0;                                  /////////////////////////////////////////////////////////
            if (!IsPostBack)
            {
                studentNo = int.Parse(Request.QueryString["studentNumber"]);
                UspGetStudentProfile vs = handler.BLL_GetStudentProfile1(studentNo);
                try
                {
                    
                    txtStudentNumber.Text = studentNo.ToString();
                    txtFirstName.Text = vs.studentFirstName;
                    txtEmail.Text = vs.studentEmail;
                    txtLastName.Text = vs.studentLastName;
                    txtDateOfBirth.Text = vs.studentDateofBirth.ToString();
                    txtCountry.Text = vs.countryDescription.ToString();
                    txtCity.Text = vs.cityDescription.ToString();
                    txtEmail.Text = vs.studentEmail;
                    txtContactNumber.Text = vs.studentContactNo;
                    txtIndustry.Text = vs.industryDescription.ToString();
                    txtQualifications.Text = vs.qualificationDescription.ToString();
                    txtSkills.Text = vs.skillDescription.ToString();
                    txtDrivers.Text = vs.driversLicense;

                    //byte[] bytes = (byte[])vs.studentProfilePicture;
                    //string base64String = Convert.ToBase64String(bytes);
                    //Image1.ImageUrl = "data:image/png;base64," + bytes;

                    //DataTable dt = (DataTable)Session["dt"];
                    //Image1.ImageUrl = dt.Rows[0][4].ToString() + vs.StudentProfilePicture;

                    //Image1.ImageUrl = base64String;
                    txtStudentUsername.Text = vs.studentUsername;
                    txtStudentPassword.Text = vs.studentPassword;
                    txtLastUpdated.Text = vs.lastUpdate.ToString();
                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('There was a problem with viewing your profile.');</script>" + ex);
                }
            }
        }

        protected void btnCV_Click(object sender, EventArgs e)
        {
          
        }

        protected void btnDownloadCV_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpdateStudentProfile_Click(object sender, EventArgs e)
        {
            lblUpdateHere.Visible = true;
            btnUpdateStudentProfile.Visible = false;
            btnFinalUpdate.Visible = true;
            ddlCountries.Enabled = true;
            txtCountry.Style.Add("visibility", "hidden");
            txtCountry.Enabled = false;
            ddlCities.Enabled = true;
            txtCity.Style.Add("visibility", "hidden");
            txtCity.Enabled = false;
            ddlIndustries.Enabled = true;
            txtIndustry.Style.Add("visibility", "hidden");
            txtIndustry.Enabled = false;
            txtDrivers.Enabled = false;
            txtDrivers.Style.Add("visibility", "hidden");
            rbtnDriversYes.Enabled = true;
            rbtnDriversNo.Enabled = true;
            txtStudentNumber.Enabled = false;

            txtCity.Enabled = true;
            txtContactNumber.Enabled = true;
            txtCountry.Enabled = true;
            txtDateOfBirth.Enabled = true;
            txtDrivers.Enabled = true;
            txtEmail.Enabled = true;
            txtFirstName.Enabled = true;
            txtIndustry.Enabled = true;
            txtLastName.Enabled = true;
            txtLastUpdated.Enabled = true;
            txtQualifications.Enabled = true;
            txtSkills.Enabled = true;
            txtStudentNumber.Enabled = true;
            txtStudentPassword.Enabled = true;
            txtStudentUsername.Enabled = true;
            ddlCountries.Enabled = true;
            ddlCities.Enabled = true;
            ddlIndustries.Enabled = true;

            ddlCountries.Visible = true;
            ddlCities.Visible = true;
            ddlIndustries.Visible = true;
            rbtnDriversYes.Visible = true;
            rbtnDriversNo.Visible = true;
            rbtnDriversNo.Enabled = true;
            rbtnDriversYes.Enabled = true;
            uploadCV.Enabled = true;
            uploadCV.Visible = true;
            uploadImage.Enabled = true;
            uploadCV.Visible = true;

            ddlCountries.DataSource = BLL_handler.BLL_GetAllCountries();
            ddlCountries.DataTextField = "CountryDescription";
            ddlCountries.DataValueField = "CountryID";
            ddlCountries.DataBind();

            ddlCities.DataSource = BLL_handler.BLL_GetAllCities();
            ddlCities.DataTextField = "CityDescription";
            ddlCities.DataValueField = "CityID";
            ddlCities.DataBind();

            ddlIndustries.DataSource = BLL_handler.BLL_GetAllIndustries();
            ddlIndustries.DataTextField = "IndustryDescription";
            ddlIndustries.DataValueField = "IndustryID";
            ddlIndustries.DataBind();


        }

        protected void btnFinalUpdate_Click(object sender, EventArgs e)
        {
            //int studentNo = 213456854; 
            HttpPostedFile profilePicture1;
            HttpPostedFile cv1;

           

            TypeLibrary.Models.UpdateStudentProfile up1 = new TypeLibrary.Models.UpdateStudentProfile();

            try
            {
                up1.studentNo = int.Parse(txtStudentNumber.Text);
                up1.firstName = txtFirstName.Text;
                up1.lastName = txtLastName.Text;
                up1.dateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
                up1.countryID = Convert.ToInt32(ddlCountries.SelectedItem.Value);
                up1.cityID = Convert.ToInt32(ddlCities.SelectedItem.Value);
                up1.email = txtEmail.Text;
                up1.contactNo = txtContactNumber.Text;
                up1.industryID = Convert.ToInt32(ddlIndustries.SelectedItem.Value);
                up1.qualID = 1;
                up1.skillID = 1;

                if (rbtnDriversYes.Checked == true)
                {
                    up1.drivers = "yes";
                }
                else
                {
                    up1.drivers = "no";
                }

                //profile picture!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                profilePicture1 = uploadImage.PostedFile;
                int profilepictureint = profilePicture1.ContentLength;
                byte[] bytImg = new byte[profilepictureint];
                up1.profilePicture = bytImg;
                /////////////////////////////////////////////////////////////end image add

                up1.studentUsername = txtStudentUsername.Text;
                up1.studentPassword = txtStudentPassword.Text;
                //CV!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                cv1 = uploadImage.PostedFile;
                int cvint = cv1.ContentLength;
                byte[] bytCV = new byte[cvint];
                up1.cv = bytCV;
                up1.cvDate = DateTime.Now;
                up1.lastUpdated = DateTime.Now;
                up1.statusID = 1;

                BLL_handler.BLL_UpdateStudentProfile(up1);

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You have successfully updated your profile');</script>");

            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You profile was not updated');</script>");

            }


        }
    }
}