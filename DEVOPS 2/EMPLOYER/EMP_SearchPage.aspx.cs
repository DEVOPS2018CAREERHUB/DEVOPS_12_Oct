using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using TypeLibrary.ViewModels;

namespace DEVOPS_2.EMPLOYER
{
    public partial class EMP_SearchPage : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            //N_A------------------------------------------------------------------------------------------------------
            //------------------------------SEARCH DROPDOWN LISTS---------------------------
            ddlCity.DataSource = BLL_handler.BLL_GetAllCities();
            ddlCity.DataTextField = "CityDescription";
            ddlCity.DataValueField = "CityID";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, new ListItem("--Select a city--", ""));

            ddlQualifications.DataSource = BLL_handler.BLL_GetAllQualifications();
            ddlQualifications.DataTextField = "QualificationDescription";
            ddlQualifications.DataValueField = "QualID";
            ddlQualifications.DataBind();
            ddlQualifications.Items.Insert(0, new ListItem("--Select a Employer--", ""));

            ddlSkills.DataSource = BLL_handler.BLL_GetAllJobTypes();
            ddlSkills.DataTextField = "TypeDescription";
            ddlSkills.DataValueField = "TypeID";
            ddlSkills.DataBind();
            ddlSkills.Items.Insert(0, new ListItem("--Select a job type--", ""));

            //------------------------------STUDENT LIST GRIDVIEW---------------------------
            //dgvStudentList.DataSource = BLL_handler.BLL_GetMostRecentStudents();
            //dgvStudentList.DataBind();

            //------------------------------ACCORDION FILTER LISTS---------------------------
            dgvDrivers.DataSource = BLL_handler.BLL_GetStudentTotalsByDrivers();
            dgvDrivers.DataBind();


            dgvByQual.DataSource = BLL_handler.BLL_GetStudentTotalsByQualification();
            dgvByQual.DataBind();

            dgvBySkill.DataSource = BLL_handler.BLL_GetStudentTotalsBySkill();
            dgvBySkill.DataBind();
        }

        protected void dgvStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (dgvStudentList_SelectedIndex == "View Details")


        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}