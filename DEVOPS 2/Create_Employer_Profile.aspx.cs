using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using TypeLibrary.Models;


namespace DEVOPS_2
{
    public partial class Create_Employer_Profile : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            txtEmployerName.Text = Request.QueryString["employerName"];
            //txtPassword.TextMode = TextBoxMode.Password;
            txtPassword.Text = Request.QueryString["Epassword"];
            txtEmployerName.Enabled = false;
            //txtPassword.TextMode = TextBoxMode.Password;
            txtPassword.Enabled = false;
            txtEmail.Text = Request.QueryString["Eemail"];
            txtEmail.Enabled = false;

            ddlCountry.DataSource = BLL_handler.BLL_GetAllCountries();
            ddlCountry.DataTextField = "CountryDescription";
            ddlCountry.DataValueField = "CountryID";
            ddlCountry.DataBind();

            ddlCity.DataSource = BLL_handler.BLL_GetAllCities();
            ddlCity.DataTextField = "CityDescription";
            ddlCity.DataValueField = "CityID";
            ddlCity.DataBind();

            ddlIndustry.DataSource = BLL_handler.BLL_GetAllIndustries();
            ddlIndustry.DataTextField = "IndustryDescription";
            ddlIndustry.DataValueField = "IndustryID";
            ddlIndustry.DataBind();


            }
        }

        protected void btnCreateEProfile_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnCreateEProfile_Click1(object sender, EventArgs e)
        {
            AddEmployer addEmployer = new AddEmployer();
            HttpPostedFile Logo1;

            try
            {
                addEmployer.employerName = txtEmployerName.Text;
                addEmployer.employerDescription = txtDescription.Text;
                addEmployer.countryID = Convert.ToInt32(ddlCountry.SelectedItem.Value);
                addEmployer.cityID = Convert.ToInt32(ddlCity.SelectedItem.Value);
                addEmployer.industryID = Convert.ToInt32(ddlIndustry.SelectedItem.Value);
                addEmployer.email = txtEmail.Text;
                addEmployer.vatNo = txtVAT.Text;
                Logo1 = uploadLogo.PostedFile;
                int logoint = Logo1.ContentLength;
                byte[] bytLogo = new byte[logoint];
                addEmployer.logo = bytLogo;
                addEmployer.employerUsername = txtUsername.Text;
                addEmployer.employerPassword = txtPassword.Text;
                addEmployer.contactPerson = txtContactPerson.Text;
                addEmployer.contactEmail = txtContactEmail.Text;
                addEmployer.statusID = 1;
                //addEmployer.industryID = 1;

                BLL_handler.BLL_AddEmployer(addEmployer);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You have successfully created your profile');</script>");
                Response.Redirect("View_Employer_profile.aspx?employerEmail=" + txtEmail.Text);

            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('There was a problem with creating your profile. Please retype all the fields');</script>");
                txtEmployerName.Text = "";
                txtDescription.Text = "";
                txtEmail.Text = "";
                txtVAT.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtContactPerson.Text = "";
                txtContactEmail.Text = "";

            }
        }
    }
}