using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using TypeLibrary.ViewModels;
using TypeLibrary.Models;

namespace DEVOPS_2
{
    public partial class Employer_HomePage : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlCity.DataSource = BLL_handler.BLL_GetAllCities();
            ddlCity.DataTextField = "CityDescription";
            ddlCity.DataValueField = "CityID";
            ddlCity.Items.Add("--Please select a city--");
            ddlCity.DataBind();

            ddlQualifications.DataSource = BLL_handler.BLL_GetAllQualifications();
            ddlQualifications.DataTextField = "QualificationsDescription";
            ddlQualifications.DataValueField = "QualID";
            ddlQualifications.Items.Add("--Please select Job type--");
            ddlQualifications.DataBind();

            ddlSkills.DataSource = BLL_handler.BLL_GetAllSkills();
            ddlSkills.DataTextField = "SkillsDescription";
            ddlSkills.DataValueField = "SkillsID";
            ddlSkills.Items.Add("--Please select skills--");
            ddlSkills.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            UspSearchStudents ss = new UspSearchStudents();
            try
            {
                ss.cityID = Convert.ToInt32(ddlCity.SelectedItem.Value);

                ss.qualificationID = Convert.ToInt32(ddlQualifications.SelectedItem.Value);
                ss.skillID = Convert.ToInt32(ddlSkills.SelectedItem.Value);

            }
            catch { }
        }
    }
}