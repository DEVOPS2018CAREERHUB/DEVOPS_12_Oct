using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using TypeLibrary.Models;
using TypeLibrary.ViewModels;
using BLL;
using DAL;

namespace Project_DevOps
{
    public partial class AddJob : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
               // empUsernametxt.text = Request.QueryString[""];

                countryDdl.DataSource = BLL_handler.BLL_GetAllCountries();
                countryDdl.DataTextField = "CountryDescription";
                countryDdl.DataValueField = "CountryID";
                countryDdl.DataBind();

                cityDdl.DataSource = BLL_handler.BLL_GetAllCities();
                cityDdl.DataTextField = "CityDescription";
                cityDdl.DataValueField = "CityID";
                cityDdl.DataBind();

                qualDdl.DataSource = BLL_handler.BLL_GetAllQualifications();
                qualDdl.DataTextField = "QualificationDesctiption";
                qualDdl.DataValueField = "QualID";
                qualDdl.DataBind();

                typeDdl.DataSource = BLL_handler.BLL_GetAllJobType();
                typeDdl.DataTextField = "JobDescription";
                typeDdl.DataValueField = "JobID";
                typeDdl.DataBind();

                skillDdl.DataSource = BLL_handler.BLL_GetAllSkills();
                skillDdl.DataTextField = "SkillDescription";
                skillDdl.DataValueField = "SkillID";
                skillDdl.DataBind();

                statusDdl.DataSource = BLL_handler.BLL_GetAllStatus();
                statusDdl.DataTextField = "StatusDescription";
                statusDdl.DataValueField = "StatusID";
                statusDdl.DataBind();
            }
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            AddJobPost jobpost = new AddJobPost();
            try
            {
                jobpost.jobTitle = jobTitletxt.Text;
                jobpost.datePosted = DateTime.Now;
                jobpost.dateClosing = DateTime.Parse(dateClosingtxt.Text);
                jobpost.countryID = Convert.ToInt32(countryDdl.SelectedItem.Value);
                jobpost.cityID = Convert.ToInt32(cityDdl.SelectedItem.Value);
                jobpost.jobDescription = jobDesctxt.Text;
                jobpost.keyResponsibilities = keyRestxt.Text;
                jobpost.qualID = Convert.ToInt32(qualDdl.SelectedItem.Value);
                jobpost.skillID = Convert.ToInt32(skillDdl.SelectedItem.Value);
                jobpost.typeID = Convert.ToInt32(typeDdl.SelectedItem.Value);
                jobpost.duration = int.Parse(duarationtxt.Text);
                jobpost.startDate = DateTime.Parse(startDatetxt.Text);
                jobpost.postedBy = postedBytxt.Text;
                jobpost.statusID = Convert.ToInt32(statusDdl.SelectedItem.Value);

                BLL_handler.BLL_AddJobPost(jobpost);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You have successfully added a job post');</script>");
            }
            catch(Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('There was a problem with creating your profile. Please retype all the fields');</script>");
                jobTitletxt.Text = "";
                dateClosingtxt.Text = "";
                jobDesctxt.Text = "";
                keyRestxt.Text = "";
                duarationtxt.Text = "";
                startDatetxt.Text = "";
                postedBytxt.Text = "";
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateJobPost jobpost = new UpdateJobPost();
            try
            {
                jobpost.jobID = int.Parse(jobIDtxt.Text);
                jobpost.jobTitle = jobTitletxt.Text;
                jobpost.dateClosing = DateTime.Parse(dateClosingtxt.Text);
                jobpost.countryID = Convert.ToInt32(countryDdl.SelectedItem.Value);
                jobpost.cityID = Convert.ToInt32(cityDdl.SelectedItem.Value);
                jobpost.jobDescription = jobDesctxt.Text;
                jobpost.keyResponsibilities = keyRestxt.Text;
                jobpost.qualID = Convert.ToInt32(qualDdl.SelectedItem.Value);
                jobpost.skillID = Convert.ToInt32(skillDdl.SelectedItem.Value);
                jobpost.typeID = Convert.ToInt32(typeDdl.SelectedItem.Value);
                jobpost.duration = int.Parse(duarationtxt.Text);
                jobpost.startDate = DateTime.Parse(startDatetxt.Text);
                
                jobpost.postedBy = postedBytxt.Text;
                jobpost.statusID = Convert.ToInt32(statusDdl.SelectedItem.Value);

                BLL_handler.BLL_UpdateJopPost(jobpost);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You have successfully updated a job post');</script>");
            }
            catch(Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('There was a problem with adding a job post. Please retype all the fields');</script>");
                jobTitletxt.Text = "";
                dateClosingtxt.Text = "";
                jobDesctxt.Text = "";
                keyRestxt.Text = "";
                duarationtxt.Text = "";
                startDatetxt.Text = "";
                postedBytxt.Text = "";

            }
        }

        protected void addRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (addRBtn.Checked == true)
            {
                AddBtn.Visible = true;
                UpdateBtn.Visible = false;
            }

            else
            {
                addRBtn.Visible = false;
            }
        }

        protected void updateRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(updateRBtn.Checked == true)
            {
                jobIDLbl.Visible = true;
                jobIDtxt.Visible = true;
                UpdateBtn.Visible = true;
                AddBtn.Visible = false;
            }

            else
            {
                UpdateBtn.Visible = false;
            }
        }

        protected void jobDesctxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}