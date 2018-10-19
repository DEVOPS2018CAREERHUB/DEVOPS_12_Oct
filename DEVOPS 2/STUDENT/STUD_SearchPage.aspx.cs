using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using TypeLibrary.ViewModels;

namespace DEVOPS_2.STUDENT
{
    public partial class STUD_SearchPage : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            //N_A------------------------------------------------------------------------------------------------------
                //------------------------------SEARCH DROPDOWN LISTS---------------------------

                ddlEmployerName.DataSource = BLL_handler.BLL_GetAllEmployerNames();
                ddlEmployerName.DataTextField = "EmployerName";
                ddlEmployerName.DataValueField = "Employer_ID";
                ddlEmployerName.DataBind();
                ddlEmployerName.Items.Insert(0, new ListItem("--Select a Employer--", ""));

                ddlJobType.DataSource = BLL_handler.BLL_GetAllJobTypes();
                ddlJobType.DataTextField = "TypeDescription";
                ddlJobType.DataValueField = "TypeID";
                ddlJobType.DataBind();
                ddlJobType.Items.Insert(0, new ListItem("--Select a Employment Type--", ""));

                ddlCity.DataSource = BLL_handler.BLL_GetAllCities();
                ddlCity.DataTextField = "CityDescription";
                ddlCity.DataValueField = "CityID";
                ddlCity.DataBind();
                ddlCity.Items.Insert(0, new ListItem("--Select a City--", ""));

            //------------------------------JOB LIST GRIDVIEW---------------------------

            //dgvJobList.DataSource = BLL_handler.BLL_GetMostRecentJobPosts();
            //dgvJobList.DataBind();


            //------------------------------ACCORDION FILTER LISTS---------------------------
            dgvClosingDate.DataSource = BLL_handler.BLL_GetJobTotalsByClosingDate();
            dgvClosingDate.DataBind();

            //dgvByQual.DataSource = BLL_handler.BLL_GetJobTotalsByQualification();
            //dgvByQual.DataBind();

            //dgvBySkill.DataSource = BLL_handler.BLL_GetJobTotalsBySkill();
            //dgvBySkill.DataBind();

        }

        protected void dgvJobList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}