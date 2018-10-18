using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TypeLibrary.ViewModels;
using BLL;
using DAL;
using TypeLibrary.Interfaces;
using TypeLibrary.Models;
using System.Data;

namespace DEVOPS_2
{
    public partial class View_Employer_profile : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        //UspGetEmployerProfile gep = new UspGetEmployerProfile();
        //List<UspGetEmployerProfile> gep2 = UspGetEmployerProfile();
        IDBHandler handler = new DBHandler();


        protected void Page_Load(object sender, EventArgs e)
        {
            string employerEmail = "";
            //UspGetEmployerProfile gep = handler.BLL_GetEmployerProfile1(employerName);
            //DataSet ds = handler.BLL_GetEmployerProfile1();

            txtContactEmail.Enabled = false;
            txtContactPerson.Enabled = false;
            txtDescription.Enabled = false;
            txtEmail.Enabled = false;
            txtEmployerName.Enabled = false;
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            txtVAT.Enabled = false;
            ddlCity.Enabled = false;
            ddlCountry.Enabled = false;
            ddlIndustry.Enabled = false;

            if (!IsPostBack)
            {
                employerEmail = Request.QueryString["employerEmail"];
                txtEmail.Text = employerEmail.ToString();
                UspGetEmployerProfile gep = handler.BLL_GetEmployerProfile1(txtEmail.Text);
                try
                {
                    txtEmployerName.Text = gep.employerName.ToString();
                    txtContactEmail.Text = gep.contactEmail.ToString();
                    txtContactPerson.Text = gep.contactPerson.ToString();
                    txtDescription.Text = gep.employerDescription.ToString();
                    txtEmail.Text = employerEmail.ToString();
                    txtEmployerName.Text = gep.employerName.ToString();
                    txtPassword.Text = gep.employerPassword.ToString();
                    txtUsername.Text = gep.employerUsername.ToString();
                    txtVAT.Text = gep.vatNo.ToString();
                    txtCountry.Text = gep.countryDescription.ToString();
                    txtCity.Text = gep.cityDescription.ToString();
                    txtIndustry.Text = gep.industryDescription.ToString();
                }catch(Exception ex)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('There was a problem with viewing your profile.');</script>" + ex);

                }
            }
            

        }

        protected void btnFinalUpdate_Click(object sender, EventArgs e)
        {
            HttpPostedFile logo;
            UpdateEmployerProfile uep = new UpdateEmployerProfile();
            
            try
            {
                
                uep.cityID = Convert.ToInt32(ddlCity.SelectedItem.Value);
                uep.contactEmail = txtContactEmail.Text;
                uep.contactPerson = txtContactPerson.Text;
                uep.countryID = Convert.ToInt32(ddlCountry.SelectedItem.Value);
                uep.employerDescription = txtDescription.Text;
                uep.email = txtEmail.Text;
                uep.employerPassword = txtPassword.Text;
                uep.employerUserName = txtUsername.Text;
                

                //logo = uploadImage.PostedFile;
                //int profilepictureint = logo.ContentLength;
                //byte[] bytImg = new byte[profilepictureint];
                //uep.logo = bytImg;
                uep.logo = null;

                uep.employerName = txtEmployerName.Text;
                uep.statusID = 1;
                uep.vatNo = txtVAT.Text;
                uep.industryID = Convert.ToInt32(ddlIndustry.SelectedItem.Value);

                BLL_handler.BLL_UpdateEmployerProfile(uep);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You have successfully updated your profile');</script>");

            }
            catch(Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You profile was not updated');</script>");
            }
        }

        protected void btnUpdateEmployerProfile_Click(object sender, EventArgs e)
        {
            lblUpdateHere.Visible = true;
            btnUpdateEmployerProfile.Visible = false;
            btnFinalUpdate.Visible = true;
            ddlCountry.Enabled = true;
            txtCountry.Style.Add("visibility", "hidden");
            txtCountry.Enabled = false;
            ddlCity.Enabled = true;
            txtCity.Style.Add("visibility", "hidden");
            txtCity.Enabled = false;
            ddlIndustry.Enabled = true;
            txtIndustry.Style.Add("visibility", "hidden");
            txtIndustry.Enabled = false;

            txtCity.Enabled = true;
            txtContactEmail.Enabled = true;
            txtContactPerson.Enabled = true;
            txtCountry.Enabled = true;
            txtDescription.Enabled = true;
            txtEmail.Enabled = true;
            txtEmployerName.Enabled = true;
            txtIndustry.Enabled = true;
            txtPassword.Enabled = true;
            txtUsername.Enabled = true;
            txtVAT.Enabled = true;

            ddlCity.Visible = true;
            ddlCountry.Visible = true;
            ddlIndustry.Visible = true;

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
}