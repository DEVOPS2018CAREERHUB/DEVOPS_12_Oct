using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.DirectoryServices;

namespace DEVOPS_2
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            lblpasswords.Visible = false;
            lblIncorrectEmail.Visible = false;
            lblStudNoNotRegistered.Visible = false;
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Button clickedButton = (Button)sender;
            //Button clickedButton = sender as Button;
            string testNo = "s" + txt1.Text;
            //IsExistInAD(testNo); ------- not needed

            if (lblText1.Text == "Student Number") { 

                int studentNo = int.Parse(txt1.Text);
                string email = txt2.Text;
                string password = txt3.Text;
                string Cpassword = txt4.Text;
                bool testEmail = emailIsValid(txt2.Text);

                //if (IsExistInAD(testNo) == true)                                                  AD1
                //{ //////// START OF AD TEST IF                                                    AD2
                    if (password != Cpassword)
                    {
                        lblpasswords.Visible = true;
                        password = "";
                        Cpassword = "";
                    }
                    else
                    {
                        lblpasswords.Visible = false;
                    }

                    //validate email format
                    if (testEmail == true)
                    {

                    }
                    else
                    {

                        lblIncorrectEmail.Visible = true;

                    }
                    if (testEmail == true && (txt3.Text == txt4.Text))
                    {
                        Response.Redirect("Create_Student_Profile.aspx?studentNumber=" + txt1.Text + "&Spassword=" + txt3.Text + "&Semail=" + txt2.Text);

                    }
               // }///////////////end of AD TEST IF                                                 AD3
                else                                                                          
               {                                                                                 
                    lblStudNoNotRegistered.Visible = true;                                           
                }                                                                                 

            }else if(lblText1.Text == "Employer Name")
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  
                string emplopyerName = txt1.Text;
                string employerEmail = txt2.Text;
                string employerPassword = txt3.Text;
                string employerCPassword = txt4.Text;
                bool testEmail = emailIsValid(txt2.Text);
                
                if (employerPassword != employerCPassword)
                {
                    lblpasswords.Visible = true;
                    
                    employerPassword = "";
                    employerCPassword = "";
                }
                else
                {
                    lblpasswords.Visible = false;
                }

                //validate email format
                if (testEmail == true)
                {
                    
                }
                else
                {
                    
                    lblIncorrectEmail.Visible = true;

                }
                if (testEmail == true && (txt3.Text == txt4.Text))
                {
                    Response.Redirect("Create_Employer_Profile.aspx?employerName=" + txt1.Text + "&Epassword=" + txt3.Text + "&Eemail=" + txt2.Text);
                }

            }


            //make it possible to go back to this page after going to next page - false

        }
        

        protected void btnStudent_Click(object sender, EventArgs e)
        {
            lblText1.Text = "Student Number";
            //txt1.Text = "";
            txt1.TextMode = TextBoxMode.Number;
        }

        protected void btnEmployer_Click(object sender, EventArgs e)
        {
            lblText1.Text = "Employer Name";
            txt1.Text = "";
            txt1.TextMode = TextBoxMode.SingleLine;
        }

        //protected void CustValidator_ServerValidate(object source, ServerValidateEventArgs args)
        //{
        //    if (string.IsNullOrWhiteSpace(args.Value))
        //    {
        //        Label1.Text = CustValidator.ErrorMessage;
        //        args.IsValid = false;
        //    }
        //    else
        //    {
        //        Label1.Text = "Whats your name";
        //        args.IsValid = true;
        //    }
        //}

        //public bool IsValidEmail(string source)
        //{
        //    return new EmailAddressAttribute().IsValid(source);
        //}

        public bool emailIsValid(string enteredEmail)
        {
            string expresion;
            //enteredEmail = txt2.Text;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(enteredEmail, expresion))
            {
                if (Regex.Replace(enteredEmail, expresion, string.Empty).Length == 0)
                {
                    return true;                   
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        bool IsExistInAD(string loginName)

        {
            ////////////////////////////////////////////////////// method to search validate student number ------------------------------------------------
            string UserName = "s" + txt1.Text;

            //string UserName = ExtractUserName(loginName);

            DirectoryEntry entryRoot = new DirectoryEntry("LDAP://RootDSE");

            //string domain = (string)entryRoot.Properties["defaultNamingContext"][0];
            //string domain = (string)entryRoot.Properties["NMMU.AC.ZA"][0];

            //DirectoryEntry entryDomain = new DirectoryEntry("LDAP://" + domain);
            DirectoryEntry entryDomain = new DirectoryEntry("LDAP://mandela.ac.za");

            //DirectorySearcher search = new DirectorySearcher();
            DirectorySearcher search = new DirectorySearcher(entryDomain);

            search.Filter = String.Format("(SAMAccountName={0})", UserName);

            search.PropertiesToLoad.Add("cn");

            search.PropertiesToLoad.Add("samacountname");

            search.PropertiesToLoad.Add("givenname");

            search.PropertiesToLoad.Add("sn");

            SearchResult result = search.FindOne();

            //string samacountname = (string)result.Properties["samaccountname"][0];

            if (result == null)

            {

                return false;

            }

            else

            {

                return true;

            }
        }




    }
}