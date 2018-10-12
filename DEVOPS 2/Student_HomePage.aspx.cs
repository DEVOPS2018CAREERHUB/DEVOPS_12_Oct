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
    public partial class Student_HomePage : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
            ddlEmployerName.DataSource = BLL_handler.BLL_GetAllEmployers();
            ddlEmployerName.DataMember = "EmployerName";
            ddlEmployerName.DataValueField = "EmployerID";
            ddlEmployerName.Items.Add("--Please select Employer Name--");
            ddlEmployerName.DataBind();

            ddlJobType.DataSource = BLL_handler.BLL_GetAllJobTypes();
            ddlJobType.DataTextField = "TypeDescription";
            ddlJobType.DataValueField = "TypeID";
            ddlJobType.Items.Add("--Please select Job Type--");
            ddlJobType.DataBind();

            ddlCity.DataSource = BLL_handler.BLL_GetAllCities();
            ddlCity.DataTextField = "CityDescription";
            ddlCity.DataValueField = "CityID";
            ddlCity.Items.Add("--Please select a city--");
            ddlCity.DataBind();
 
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            UspSearchJobs ss = new UspSearchJobs();
            try
            {
            ss.cityID = Convert.ToInt32(ddlCity.SelectedItem.Value);

            ss.employerID = Convert.ToInt32(ddlEmployerName.SelectedItem.Value);
                ss.typeID = Convert.ToInt32(ddlJobType.SelectedItem.Value);

            }
            catch { }
            

        }

        //protected void dgvJobSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //string id = dgvJobSearchResult.SelectedRow.Cells[0].Text;
        //    //string name = dgvJobSearchResult.SelectedRow.Cells[1].Text;
        //    //string description = (dgvJobSearchResult.SelectedRow.FindControl("lblDescription") as Label).Text;

            
        //    //dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
        //    //        new DataColumn("Name", typeof(string)),
        //    //        new DataColumn("Description",typeof(string)) });
        //    //dt.Rows.Add(id, name, description);
        //    //FormView1.DataSource = BLL_handler.;
        //    //FormView1.DataBind();
        //}
    }
}