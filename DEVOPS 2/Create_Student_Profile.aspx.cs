using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using TypeLibrary.Models;
using TypeLibrary.Interfaces;
using BLL;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace DEVOPS_2
{
    public partial class Create_Student_Profile : System.Web.UI.Page
    {
        DBHandler BLL_handler = new DBHandler();
        //IDBHandler handler = new DBHandler();
        
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
                ddlCities.DataBind();

                ddlIndustry.DataSource = BLL_handler.BLL_GetAllIndustries();
                ddlIndustry.DataTextField = "IndustryDescription";
                ddlIndustry.DataValueField = "IndustryID";
                ddlIndustry.DataBind();

                GridView1.DataSource = BLL_handler.BLL_GetAllSkills();
                GridView1.DataBind();

                gridQuals.DataSource = BLL_handler.BLL_GetAllQualifications();
                gridQuals.DataBind();

                HttpContext.Current.Session["foo"] = new List<string>();
                HttpContext.Current.Session["foo1"] = new List<string>();
                HttpContext.Current.Session["Quals"] = new List<string>();
                HttpContext.Current.Session["Quals1"] = new List<string>();

            }

            var selectedSkills = HttpContext.Current.Session["foo"] as List<string>;
            var selectedSkills1 = HttpContext.Current.Session["foo1"] as List<string>;
            var selectedQuals = HttpContext.Current.Session["Quals"] as List<string>;
            var selectedQuals1 = HttpContext.Current.Session["Quals1"] as List<string>;

            foreach (string skill in selectedSkills)
            {
                TableRow tr = new TableRow();
                TableCell tc = new TableCell
                {
                    Text = skill
                };
                tr.Cells.Add(tc);
                tblSelectedSkills.Rows.Add(tr);
            }
            foreach (string skill1 in selectedSkills1)
            {
                TableRow tr = new TableRow();
                TableCell tc = new TableCell
                {
                    Text = skill1
                };
                tr.Cells.Add(tc);
                tblSkillIDs.Rows.Add(tr);
            }

            foreach(string qual in selectedQuals)
            {
                TableRow tr = new TableRow();
                TableCell tc = new TableCell
                {
                    Text = qual
                };
                tr.Cells.Add(tc);
                tblSelectedQuals.Rows.Add(tr);
            }
            foreach (string qual1 in selectedQuals1)
            {
                TableRow tr = new TableRow();
                TableCell tc = new TableCell
                {
                    Text = qual1
                };
                tr.Cells.Add(tc);
                tblQualIDs.Rows.Add(tr);
            }



        }

        protected void btnCreateSProfile_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            AddStudentSkill addStudentSkill = new AddStudentSkill();
            AddStudentQual addStudentQual = new AddStudentQual();
            string pathhh = "";
            HttpPostedFile profilePicture1;
            //HttpPostedFile cv1;




            //foreach (TableRow r in tblSkillIDs.Rows)
            //{
            //    addStudentSkill.studentNo = int.Parse(txtStudentNo.Text);
            //    addStudentSkill.skillID = int.Parse(r.ToString());
            //}


            int o = 0;
            int p = 0;

            foreach (TableRow s in tblSkillIDs.Rows)
            {
                foreach (TableCell c in s.Cells)
                { 
                o = Convert.ToInt32(c.Text);
                //if you want to get the string
                //int s = o = tblSkillIDs.Rows[i];
                addStudentSkill.studentNo = int.Parse(txtStudentNo.Text);
                addStudentSkill.skillID = o;
                 }
                BLL_handler.BLL_AddStudentSkill(addStudentSkill);
            }

            foreach(TableRow s in tblQualIDs.Rows)
            {
                foreach(TableCell c in s.Cells)
                {
                    p = Convert.ToInt32(c.Text);
                    addStudentQual.studentNo = int.Parse(txtStudentNo.Text);
                    addStudentQual.qualID = p;
                   
                }
                BLL_handler.BLL_AddStudentQual(addStudentQual);
            }




            if (uploadCV.HasFile)
            {
                
               
                    string f1 = Path.GetFileNameWithoutExtension(uploadCV.FileName);
                    string f2 = Path.GetExtension(uploadCV.FileName);
                    f1 = txtStudentNo.Text;
                    pathhh = "CV/" + f1;
                    uploadCV.PostedFile.SaveAs(Server.MapPath("CV/" + f1 + f2));
                    //uploadCV.SaveAs(Server.MapPath("CV\\" + uploadCV.FileName));
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('yes');</script>");

               
            }

            try
            {
                addStudent.studentNo = int.Parse(txtStudentNo.Text);
                //addStudent.studentNo = 215333608;
                addStudent.studentFirstName = txtFisrtName.Text;
                addStudent.studentLastName = txtLastName.Text;
                addStudent.studentDateOfBirth = DateTime.Parse(txtDateofBirth.Text);
                
                addStudent.countryID = Convert.ToInt32(ddlCountries.SelectedItem.Value);
                addStudent.cityID = Convert.ToInt32(ddlCities.SelectedItem.Value);
                addStudent.studentEmail = txtEmail.Text;
                //addStudent.studentEmail = "sdsdsd@dsf.f";
                addStudent.studentContactNo = txtContactNo.Text;
                //addStudent.industryID = Convert.ToInt32(ddlIndustry.SelectedItem.Value);
                addStudent.industryID = Convert.ToInt32(txtChosenIndID.Text);
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


                                                                            ///end image add


                 profilePicture1 = uploadImage.PostedFile;
                int profilepictureint = profilePicture1.ContentLength;
                byte[] bytImg = new byte[profilepictureint];
                addStudent.profilePicture = bytImg;
                addStudent.studentUsername = txtStudUsername.Text;
                addStudent.studentPassword = txtStudPassword.Text;
                //addStudent.studentPassword = "123";

                //            CV
                // cv1 = uploadCV.PostedFile;

                addStudent.cv = pathhh;

                addStudent.cvDate = DateTime.Now;
                addStudent.statusID = 1;
                addStudent.lastUpdate = DateTime.Now;
                
                ///////////////////////////////////////SKILLS//////////////////////////////////
                //foreach(TableRow r in tblSkillIDs.Rows)
                //{
                //    addStudentSkill.studentNo = int.Parse(txtStudentNo.Text);
                //    addStudentSkill.skillID = int.Parse(r.ToString());
                //}
                //BLL_handler.BLL_AddStudentSkill(addStudentSkill);
                BLL_handler.BLL_AddStudent(addStudent);
                
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You have successfully created your profile');</script>");
            }
            catch (Exception ex)
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
            Response.Redirect("View_Student_Profile.aspx?studentNumber=" + txtStudentNo.Text, false);
            
        }

        public void btnImageUpload_Click(object sender, EventArgs e)
        {
            
            HttpPostedFile profilePicture = uploadImage.PostedFile;
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TableRow tRow = GridView1.SelectedRow;
            //tblSelectedSkills.Rows.Add(tRow);
            var selectedSkills = HttpContext.Current.Session["foo"] as List<string>;
            selectedSkills.Add(tRow.Cells[2].Text);
            tblSelectedSkills.Rows.Add(tRow);

            TableRow tRow2 = GridView1.SelectedRow;
            var selectedSkillIDs = HttpContext.Current.Session["foo1"] as List<string>;
            selectedSkillIDs.Add(tRow2.Cells[1].Text);
            tblSkillIDs.Rows.Add(tRow2);

            //var selectedSkills = HttpContext.Current.Session["foo"] as List<string>;
            //selectedSkills.Add(tRow2.Cells[1].Text);


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnClear_Click1(object sender, EventArgs e)
        {
            //Table1.Controls.Add(GridView1.SelectedRow);
            //TableRow tRow = GridView1.SelectedRow;
            //Table1.Rows.Add(tRow);
            tblSelectedSkills.Controls.Clear();
            //HttpContext.Current.Session["foo"] = "";
            var selectedSkills = HttpContext.Current.Session["foo"] as List<string>;
            selectedSkills.Clear();                                                         // Add to end of create button to remove select
            GridView1.DataSource = BLL_handler.BLL_GetAllSkills();
            GridView1.DataBind();
        }

        protected void btnAddNewSkill_Click(object sender, EventArgs e)
        {
            AddNewSkill addNewSkill = new AddNewSkill();
            string newSkill = txtNewSkill.Text;
            
            if (txtNewSkill.Text != null)
            {
                addNewSkill.skillDescription = newSkill;                                             // UNCOMMENT IF FINISHED
                BLL_handler.BLL_AddNewSkill(addNewSkill);                
                //txtSkills.Text = Session["foo"].ToString();
                
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('No new Skill entered');</script>");
            }
            GridView1.DataSource = BLL_handler.BLL_GetAllSkills();
            GridView1.DataBind();
            txtNewSkill.Text = null;

        }

        protected void GridQuals_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableRow tRow = gridQuals.SelectedRow;
            var selectedQuals = HttpContext.Current.Session["quals"] as List<string>;

            selectedQuals.Add(tRow.Cells[2].Text);
            tblSelectedQuals.Rows.Add(tRow);

            TableRow tRow2 = gridQuals.SelectedRow;
            var selectedQualIDs = HttpContext.Current.Session["quals1"] as List<string>;
            selectedQualIDs.Add(tRow2.Cells[1].Text);
            tblQualIDs.Rows.Add(tRow2);
        }

        protected void btnClearQuals_Click1(object sender, EventArgs e)
        {
            tblSelectedQuals.Controls.Clear();
            var selectedQuals = HttpContext.Current.Session["Quals"] as List<string>;
            selectedQuals.Clear();
            gridQuals.DataSource = BLL_handler.BLL_GetAllQualifications();
            gridQuals.DataBind();
        }

        protected void btnAddNewQual_Click(object sender, EventArgs e)
        {
            AddNewQual addNewQual = new AddNewQual();
            string newQual = txtNewQual.Text;
            if (txtNewQual.Text != null)
            {
                addNewQual.qualDescription = newQual;
                BLL_handler.BLL_AddNewQual(addNewQual);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('No new Qualification entered');</script>");
            }
            gridQuals.DataSource = BLL_handler.BLL_GetAllQualifications();
            gridQuals.DataBind();
            txtNewQual.Text = null;
        }

        protected void btnAddNewIndustry_Click(object sender, EventArgs e)
        {
            AddNewIndustry addNewIndustry = new AddNewIndustry();
            string newIndustry = txtAddNewIndustry.Text;
            if (txtAddNewIndustry.Text != null)
            {
                addNewIndustry.industryDescription = newIndustry;
                BLL_handler.BLL_AddNewIndustry(addNewIndustry);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('No new Industry entered');</script>");
            }
            ddlIndustry.DataSource = BLL_handler.BLL_GetAllIndustries();
            ddlIndustry.DataTextField = "IndustryDescription";
            ddlIndustry.DataValueField = "IndustryID";
            ddlIndustry.DataBind();
            txtAddNewIndustry.Text = null;
            txtChosenIndustry.Text = null;
            txtChosenIndID.Text = null;
        }

        protected void ddlIndustry_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtChosenIndID.Text = ddlIndustry.SelectedIndex.ToString();
            txtChosenIndustry.Text = ddlIndustry.SelectedItem.ToString();
        }
    }
}