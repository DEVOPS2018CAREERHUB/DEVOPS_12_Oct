<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create_Student_Profile.aspx.cs" Inherits="DEVOPS_2.Create_Student_Profile" EnableViewState="true"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     
    <link rel="stylesheet" href="CSS/bootstrap.min.css" />
    <link rel="stylesheet" href="CSS/bootstrap-cols.css" />
    <link rel="stylesheet" href="CSS/sm-core-css.css" type="text/css" />
    <link rel="stylesheet" href="CSS/sm-hamburger.css" />
    <link rel="stylesheet" href="CSS/jquery.smartmenus.bootstrap.css" />
    <link rel="stylesheet" href="CSS/royalslider.css" />
    <link rel="stylesheet" href="CSS/rs-default-new.css" />
    <link rel="stylesheet" href="CSS/font-awesome.min.css" />
    <link rel="stylesheet" href="CSS/nmmu.css" />
    <link rel="stylesheet" href="CSS/nmu.css" />

    <style type ="text/css">

        .shadow
        {
             background-color: #F0F0F0;
            -webkit-box-shadow: 0px 0px 10px rgba(0,0,0,1);
            color: #0000FF;
            /*opacity: .78;*/
            opacity: 90; 
        }
        .testing {
            opacity: .78; 
            width: 10px;
        }
      

    </style>

    <script id="facebook-jssdk" src="Scripts/all.js.download"></script>
    <script id="twitter-wjs" src="Scripts/widgets.js.download"></script>
    <script async="" src="Scripts/ga.js.download" type="text/javascript"></script>

</head>
<body style=" width: 1600px; height: 900px; background-repeat:no-repeat;">
    <form id="form1" runat="server" style="width: 1600px; height: 900px">
        <div class="container-fluid navbar-blue-gradient navbar-fixed-top tbsZindex">
            <div class="container" style="padding-left: 0px; height: 45px">
                <div id="navbarDefault" class="navbar navbar-default" role="navigation">
                    <div class="navbar-header">
                        <!------------ ICONS ------------>
                        <ul class="SocialIcons nav navbar-nav navbar-right hidden-xs hidden-sm hidden-md sm" data-smartmenus-id="15286296449682358">
                            <li><a class="navbar-icon" href="http://www.facebook.com/mandelauni">
                                <img alt="facebook" src="images/facebook.png" /></a></li>
                            <li><a class="navbar-icon" href="http://www.twitter.com/mandelauni">
                                <img alt="twitter" src="images/twitterwhite.png" /></a></li>
                            <li><a class="navbar-icon" href="https://plus.google.com/113939268207479606258?prsrc=3">
                                <img alt="googleplus" src="images/googleplus.png" /></a></li>
                            <li><a class="navbar-icon" href="https://www.youtube.com/user/NMMUonTube">
                                <img alt="youtube" src="images/youtube.png" /></a></li>
                            <li><a class="navbar-icon" href="https://instagram.com/mandelauniversity">
                                <img alt="Instagram" src="images/instagramwhite.png" /></a></li>
                            <li style="width: 20px"></li>
                            <li></li>

                            <li><a class="navbar-icon" href="~/Help">
                                <img alt="Help" src="images/help.png" /></a></li>
                            <li style="width: 15px"></li>
                            <li><a class="navbar-icon" href="~/LandingPage">
                                <img alt="Logout" src="images/login.png" /></a></li>
                        </ul>
                    </div>
                    				<ul id="divNavbarTop" class="nav navbar-nav sm" data-smartmenus-id="15270843286636987">
					<li>
					<a href="Landing_Page.aspx">
					Home</a></li>
					<li>
					<a href="AboutUsPage">
					About Us</a></li>
					<li>
					<a href="MeetTheTeamPage">
					Meet the Team</a></li>					
				</ul>

                </div>
            </div>
        </div>
        <%--------------------------------------------------------------%>

        <!-- LOGO & TRANSPARENT BACKGROUND -->

        <div id="LogoBar" class="container-fluid transparentBackgroundDarkBlue">
            <div class="container">
                <div class="row">

                    <div class="MegaDropDownDiv">
                        <div id="divLogo" class="col-xs-2 col-sm-3 tbsHnopad">
                            <a href="http://gradstud.mandela.ac.za/" id="aLogo">
                                <img id="imgLogo" class="img-responsive imgLogo" src="images/MandelaUniversity_logo_B.png" alt="Logo" />
                                <img id="imgLogoS" class="img-responsive imgLogoS" src="images/MandelaUniversity_logo_s_B.png" alt="Logo" />
                            </a>
                        </div>
                        <div id="divText" class="col-xs-10 col-sm-9">
                            <div class="row">
                                <div id="divStrapLine" class="col-xs-12 tbsHnopad">
                                    <p id="StrapLine" class="StrapLine">Change the world</p>
                                </div>
                                <div id="DepartmentEntity" class="col-xs-12 tbsHnopad">
                                    <p class="EntityHeader" style="font-family: Arial, Helvetica, sans-serif; font-size: xx-large;">Career Hub</p>

                                </div>

                            </div>
                        </div>
                    </div>

                    <div id="divSearchOnMobile" class="col-xs-4 hidden-md hidden-lg">
                    </div>
                </div>
            </div>
        </div>
        <div style="background-image: url('/images/Landing.jpg'); background-repeat: no-repeat; background-attachment: fixed; background-position: inherit bottom bottom;"></div>


    <div class="shadow" style="z-index: 1; left: 116px; top: 170px; position: absolute; height: 1300px; width: 1270px;">
    
        <asp:Label ID="lblStudentNo" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 12px; top: 10px; position: absolute" Text="Student Number"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 45px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 80px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="lblDateofBirth" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 115px; position: absolute" Text="Date of Birth"></asp:Label>
        <asp:Label ID="lblCountry" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 150px; position: absolute" Text="Country"></asp:Label>
        <asp:Label ID="lblCity" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 185px; position: absolute" Text="City"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 220px; position: absolute" Text="Email Address"></asp:Label>
        <asp:Label ID="lblContactNo" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 255px; position: absolute" Text="Contact Number"></asp:Label>
        <asp:Label ID="lblIndustry" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 290px; position: absolute" Text="Industry"></asp:Label>
        <asp:Label ID="lblQual" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 350px; position: absolute" Text="Qualifications"></asp:Label>
        <asp:Label ID="lblSkill" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 660px; position: absolute" Text="Skills"></asp:Label>
        <asp:Label ID="lblDrivers" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 975px; position: absolute" Text="Drivers License"></asp:Label>
        <asp:Label ID="lblStudUsername" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 180px; z-index: 1; left: 12px; top: 1010px; position: absolute" Text="Student Username"></asp:Label>
        <asp:Label ID="lblStudPassword" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 180px; z-index: 1; left: 12px; top: 1045px; position: absolute" Text="Student Password"></asp:Label>
        <asp:Label ID="lblCV" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 1080px; position: absolute" Text="CV"></asp:Label>
        <asp:Label ID="lbllastUpdated" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 150px; z-index: 1; left: 12px; top: 1115px; position: absolute" Text="Last Updated"></asp:Label>


        <asp:TextBox ID="txtStudentNo" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 10px; position: absolute; width: 305px" TextMode="Number"></asp:TextBox>
        <asp:TextBox ID="txtFisrtName" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 45px; position: absolute; width: 305px"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 80px; position: absolute; width: 305px"></asp:TextBox>
        <asp:TextBox ID="txtDateofBirth" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 115px; position: absolute; width: 305px" TextMode="Date" ></asp:TextBox>
        <asp:DropDownList ID="ddlCountries" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 150px; position: absolute; width: 305px">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlCities" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 185px; position: absolute; width: 305px"  >
        </asp:DropDownList>
        <asp:TextBox ID="txtEmail" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 220px; position: absolute; width: 305px"  ></asp:TextBox>
        <asp:TextBox ID="txtContactNo" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 255px; position: absolute; width: 305px" ></asp:TextBox>
        <asp:DropDownList ID="ddlIndustry" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 220px; top: 295px; position: absolute; width: 250px" AutoPostBack="True" OnSelectedIndexChanged="ddlIndustry_SelectedIndexChanged" ></asp:DropDownList>
        <asp:Label ID="lblAddNewIndustry" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 182px; z-index: 1; left: 480px; top: 293px; position: absolute" Text="Or add a new Industry:"></asp:Label>
        <asp:TextBox ID="txtAddNewIndustry" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 670px; top: 290px; position: absolute; width: 200px"  ></asp:TextBox>
        <asp:Button ID="btnAddNewIndustry" runat="server" Font-Size="Large" ForeColor="White" style="z-index: 1; left: 900px; top: 290px; position: absolute" Text="Add" OnClick="btnAddNewIndustry_Click" />
        <asp:TextBox ID="txtChosenIndustry" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 992px; top: 290px; position: absolute; width: 250px"  ></asp:TextBox>
            <asp:TextBox ID="txtChosenIndID" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 676px; top: 230px; position: absolute; width: 91px" Enabled="False" Visible="False"  ></asp:TextBox>
        <asp:TextBox ID="txtQual" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 325px; position: absolute; width: 305px" ></asp:TextBox>
        <asp:TextBox ID="txtSkills" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 360px; position: absolute; width: 305px" ></asp:TextBox>
        <asp:RadioButton GroupName="Drivers" ID="rbtnDriversYes" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 975px; position: absolute; width: 152px" Text="Yes"/>
        <asp:RadioButton GroupName="Drivers" ID="rbtnDriversNo" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 1094px; top: 975px; position: absolute; width: 152px" Text="No"/>
        
<%--        <asp:Button ID="btnImageUpload" runat="server" Text="Choose image file" BackColor="#F0F0F0" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 420px; position: absolute; width: 152px" OnClick="btnImageUpload_Click"/>--%>
        <asp:FileUpload ID="uploadImage" runat="server" BackColor="#F0F0F0" Font-Size="Large" ForeColor="#000099" style="left: 509px; position: absolute; width: 64px; top: 436px; visibility:hidden" />
        <%--        <asp:Label ID="lblImageChosen" runat="server" ForeColor="Red" Text="No Image chosen" Font-Size="Large" style="width: 150px; z-index: 1; left: 1100px; top: 430px; position: absolute"></asp:Label>--%>
        
        <asp:TextBox ID="txtStudUsername" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 1010px; position: absolute; width: 305px" ></asp:TextBox>
        <asp:TextBox ID="txtStudPassword" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 1045px; position: absolute; width: 305px" ></asp:TextBox>

      <%--  <asp:Button ID="btnCVUpload" runat="server" Text="Upload CV file" BackColor="#F0F0F0" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 535px; position: absolute; width: 152px"/>
        <asp:Label ID="lblCVUpload" runat="server" ForeColor="Red" Text="No CV Uploaded" Font-Size="Large" style="width: 150px; z-index: 1; left: 1100px; top: 535px; position: absolute"></asp:Label>
        --%>
        <asp:FileUpload ID="uploadCV" runat="server" BackColor="#F0F0F0" Font-Size="Large" ForeColor="#000099" style="left: 942px; position: absolute; width: 305px; top: 1080px " />

        <asp:Label ID="lblLastUpdated2" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 1115px; position: absolute; width: 150px" Enabled="False" ></asp:Label>


        <asp:Button ID="btnCreateSProfile" runat="server" Font-Size="Larger" ForeColor="White" style="z-index: 1; left: 636px; top: 1180px; position: absolute" Text="Create Profile" OnClick="btnCreateSProfile_Click" />


<div style="border-width: 2px; border-style:solid; border-color: #000000; top: 650px; left: 220px; width: 660px; z-index: 1; position: absolute; height: 300px;">
     <div style="border-width: 1px; overflow: scroll; height: 200px; width: 250px; top: 10px; left: 10px; z-index: 1; position: absolute;">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
        </asp:GridView>
    </div>

        <asp:Button ID="btnClear" runat="server" Text="Clear Table" style="width:108px; position: absolute; top: 89px; left: 282px; " OnClick="btnClear_Click1"/>

        <div style="border-width: 1px; overflow: scroll; height: 200px; width: 250px; top: 10px; right: 10px; z-index: 1; position: absolute;">
        <asp:Table ID="tblSelectedSkills" runat="server" BorderWidth="1px" Enabled="false">
        </asp:Table>
        </div>

        <asp:TextBox ID="txtNewSkill" runat="server" BackColor="#F0F0F0" BorderWidth="1px" Font-Size="Large" ForeColor="#000099" Style="width: 225px; position: absolute; top: 228px; left: 10px" ToolTip="Add a new Skill here if it is not in the list" ></asp:TextBox>
        <asp:Button ID="btnAddNewSkill" runat="server" Text="Add new Skill" style="width:138px; position: absolute; top: 228px; left: 276px; " OnClick="btnAddNewSkill_Click"/>
        <asp:Table ID="tblSkillIDs" runat="server" BorderWidth="1px" Enabled="false" Style="top: 228px; width: 180px; height: 50px; position:absolute; right: 10px; " >
        </asp:Table>
     
</div>

<div style="border-width: 2px; border-style:solid; border-color: #000000; top: 348px; left: 220px; width: 660px; z-index: 1; position: absolute; height: 300px;">
    <div style="border-width: 1px; overflow: scroll; height: 200px; width: 250px; top: 10px; left: 10px; z-index: 1; position: absolute;">
        <asp:GridView ID="gridQuals" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridQuals_SelectedIndexChanged" >
        </asp:GridView>
    </div>

        <asp:Button ID="btnClearQuals" runat="server" Text="Clear Table" style="width:108px; position: absolute; top: 89px; left: 282px; " OnClick="btnClearQuals_Click1"/>

        <div style="border-width: 1px; overflow: scroll; height: 200px; width: 250px; top: 10px; right: 10px; z-index: 1; position: absolute;">
        <asp:Table ID="tblSelectedQuals" runat="server" BorderWidth="1px" Enabled="false">
        </asp:Table>
        </div>

        <asp:TextBox ID="txtNewQual" runat="server" BackColor="#F0F0F0" BorderWidth="1px" Font-Size="Large" ForeColor="#000099" Style="width: 225px; position: absolute; top: 228px; left: 10px" ToolTip="Add a new Qualification here if it is not in the list" ></asp:TextBox>
        <asp:Button ID="btnAddNewQual" runat="server" Text="Add new Qualification" style="width:179px; position: absolute; top: 228px; left: 276px; " OnClick="btnAddNewQual_Click"/>
        <asp:Table ID="tblQualIDs" runat="server" BorderWidth="1px" Enabled="false" Style="top: 228px; width: 180px; height: 50px; position:absolute; right: 10px; " >
        </asp:Table>
</div>

    </div>
    </form>
</body>
</html>
