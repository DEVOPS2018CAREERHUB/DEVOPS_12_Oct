<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Student_Profile.aspx.cs" Inherits="DEVOPS_2.View_Student_Profile" EnableViewState="true" %>

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
            opacity: 90; 
        }
        #form1 {
            height: 177px;
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
        <div style=" background-repeat: no-repeat; background-attachment: fixed; background-position: inherit bottom bottom;"></div>
    <div class="shadow" style="z-index: 1; left: 116px; top: 170px; position: absolute; height: 136%; width: 1169px;">

            <asp:Image ID="Image1" runat="server" style="width: 150px; height: 150px; position: absolute; top: 17px; left: 556px;" Visible="False"/>

            <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 150px; position: absolute" Text="Student Number"></asp:Label>
            <asp:Label ID="Label2" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 185px; position: absolute" Text="First Name"></asp:Label>
            <asp:Label ID="Label3" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 220px; position: absolute" Text="Last Name"></asp:Label>
            <asp:Label ID="Label4" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 255px; position: absolute" Text="Date of Birth"></asp:Label>
            <asp:Label ID="Label5" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 290px; position: absolute" Text="Country"></asp:Label>
            <asp:Label ID="Label6" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 325px; position: absolute" Text="City"></asp:Label>
            <asp:Label ID="Label7" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 360px; position: absolute" Text="Email"></asp:Label>
            <asp:Label ID="Label8" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 395px; position: absolute" Text="Contact Number"></asp:Label>
            <asp:Label ID="Label9" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 430px; position: absolute" Text="Industry"></asp:Label>
            <asp:Label ID="Label10" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 465px; position: absolute" Text="Qualifications"></asp:Label>
            <asp:Label ID="Label11" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 500px; position: absolute" Text="Skills"></asp:Label>
            <asp:Label ID="Label12" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 535px; position: absolute" Text="Drivers License"></asp:Label>
            <asp:Label ID="Label13" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 570px; position: absolute" Text="Student Username"></asp:Label>
            <asp:Label ID="Label14" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 605px; position: absolute" Text="Student Password"></asp:Label>
            <asp:Label ID="Label15" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 640px; position: absolute" Text="CV"></asp:Label>
            <asp:Label ID="Label17" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 680px; position: absolute" Text="Profile picture"></asp:Label>
            <asp:Label ID="Label16" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 24px; top: 715px; position: absolute" Text="Last Updated date"></asp:Label>


            <asp:TextBox ID="txtStudentNumber" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 150px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtFirstName" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 185px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtLastName" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 220px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtDateOfBirth" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 255px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtCountry" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 290px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtCity" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 325px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtEmail" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 360px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtContactNumber" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 395px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtIndustry" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 430px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtQualifications" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 465px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtSkills" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 500px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtDrivers" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 535px; position: absolute; width: 300px"></asp:TextBox>
             <asp:RadioButton GroupName="Drivers" ID="rbtnDriversYes" Enabled="false" Visible="false" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 790px; top: 535px; position: absolute; width: 152px" Text="Yes"/>
        <asp:RadioButton GroupName="Drivers" ID="rbtnDriversNo" Enabled="false" Visible="false" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 535px; position: absolute; width: 152px" Text="No"/>
        
            <asp:TextBox ID="txtStudentUsername" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 570px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtStudentPassword" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 605px; position: absolute; width: 300px"></asp:TextBox>
            <asp:Button ID="btnCV" Text="Click here to open CV" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 638px; position: absolute; width: 300px" OnClick="btnCV_Click"></asp:Button>
            <asp:FileUpload ID="uploadCV" runat="server" BackColor="#F0F0F0" Font-Size="Large" ForeColor="#000099" style="left: 800px; position: absolute; width: 305px; top: 638px " />
            <asp:FileUpload ID="uploadImage" runat="server" BackColor="#F0F0F0" Font-Size="Large" ForeColor="#000099" style="left: 800px; position: absolute; width: 305px; top: 675px " />
            <asp:TextBox ID="txtLastUpdated" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 715px; position: absolute; width: 300px"></asp:TextBox>

            <asp:DropDownList ID="ddlCountries" runat="server" BackColor="#F0F0F0" Enabled="false" Visible="false" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 290px; position: absolute; width: 305px;">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlCities" runat="server" BackColor="#F0F0F0" Enabled="false" Visible="false" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 325px; position: absolute; width: 305px;">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlIndustries" runat="server" BackColor="#F0F0F0" Enabled="false" Visible="false" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 430px; position: absolute; width: 305px;">
            </asp:DropDownList>

            <asp:Button ID="btnDownloadCV" runat="server" Font-Size="Large" ForeColor="#000099" OnClick="btnDownloadCV_Click" Enabled="false" style="z-index: 1; left: 168px; top: 57px; position: absolute" Text="Download CV" />

            <asp:Button ID="btnUpdateStudentProfile" runat="server" Font-Size="Large" ForeColor="#000099" OnClick="btnUpdateStudentProfile_Click" style="z-index: 1; left: 800px; top: 755px; position: absolute" Text="Update Student Profile" />
            <asp:Label ID="lblUpdateHere" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 96px; position: absolute" Text="Update the fields here:" Visible="False"></asp:Label>

            <asp:Button ID="btnFinalUpdate" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 800px; top: 805px; position: absolute" Text="Update Profile" OnClick="btnFinalUpdate_Click" Visible="False" />

            <asp:Label ID="lblMyProfile" runat="server" Font-Size="XX-Large" ForeColor="Red" style="z-index: 1; left: 450px; top: 63px; position: absolute" Text="My Profile"></asp:Label>

        </div>
    </form>
</body>
</html>
