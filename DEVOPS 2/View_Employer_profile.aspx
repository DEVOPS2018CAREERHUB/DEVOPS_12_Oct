<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Employer_profile.aspx.cs" Inherits="DEVOPS_2.View_Employer_profile" EnableViewState="true" %>

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
            opacity: .78; 
        }
        #form1 {
            height: 177px;
        }
        </style>
<script id="facebook-jssdk" src="Scripts/all.js.download"></script>
    <script id="twitter-wjs" src="Scripts/widgets.js.download"></script>
    <script async="" src="Scripts/ga.js.download" type="text/javascript"></script>
    

</head>
<body style="background-image: url('images/create_Employer_profile.png'); width: 1600px; height: 900px; background-repeat:no-repeat;">
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
					<a href="AboutUs_Page.aspx">
					About Us</a></li>
					<li>
					<a href="MeetTheTeam_Page.aspx">
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
    <div class="shadow" style="z-index: 1; left: 116px; top: 151px; position: absolute; height: 100%; width: 100%;">
        


        <asp:Image ID="Image1" runat="server" style=" Width: 100px; height: 100px; z-index: 1; left: 500px; top: 39px; position: absolute;"/>
        <asp:Label ID="lblEmployerName" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 165px; position: absolute" Text="Employer Name"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 200px; position: absolute" Text="Description"></asp:Label>
        <asp:Label ID="lblCountry" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 235px; position: absolute" Text="Country"></asp:Label>
        <asp:Label ID="lblCity" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 270px; position: absolute" Text="City"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 305px; position: absolute" Text="Email Address"></asp:Label>
        <asp:Label ID="lblVAT" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 340px; position: absolute" Text="VAT number"></asp:Label>
        <asp:Label ID="lblIndustry" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 375px; position: absolute" Text="Industry"></asp:Label>
        <asp:Label ID="lblLogo" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 410px; position: absolute" Text="Employer Logo"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 445px; position: absolute" Text="Employer Username"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 480px; position: absolute" Text="Employer password"></asp:Label>
        <asp:Label ID="lblContactPerson" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 515px; position: absolute" Text="Contact Person"></asp:Label>
        <asp:Label ID="lblContactEmail" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 550px; position: absolute" Text="Contact Email Address"></asp:Label>

         <asp:TextBox ID="txtEmployerName" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 165px; position: absolute; width: 305px"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 200px; position: absolute; width: 305px"></asp:TextBox>
        <asp:DropDownList ID="ddlCountry" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 235px; position: absolute; width: 305px"></asp:DropDownList>
        <asp:DropDownList ID="ddlCity" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 270px; position: absolute; width: 305px"></asp:DropDownList>
            <asp:TextBox ID="txtCountry" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 235px; position: absolute; width: 300px"></asp:TextBox>
            <asp:TextBox ID="txtCity" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 270px; position: absolute; width: 300px"></asp:TextBox>

        <asp:TextBox ID="txtEmail" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 305px; position: absolute; width: 305px"></asp:TextBox>
        <asp:TextBox ID="txtVAT" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 340px; position: absolute; width: 305px"></asp:TextBox>
        <asp:DropDownList ID="ddlIndustry" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 375px; position: absolute; width: 305px"></asp:DropDownList>
            <asp:TextBox ID="txtIndustry" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 375px; position: absolute; width: 300px"></asp:TextBox>

        <asp:FileUpload ID="uploadLogo" runat="server" BackColor="#F0F0F0" Font-Size="Large" ForeColor="#000099" style="left: 942px; position: absolute; width: 305px; top: 410px " />

        <asp:TextBox ID="txtUsername" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 445px; position: absolute; width: 305px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 480px; position: absolute; width: 305px"></asp:TextBox>
        <asp:TextBox ID="txtContactPerson" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 515px; position: absolute; width: 305px"></asp:TextBox>
        <asp:TextBox ID="txtContactEmail" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 550px; position: absolute; width: 305px"></asp:TextBox>

        <asp:Label ID="lblUpdateHere" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 121px; position: absolute" Text="Update the fields here:" Visible="False"></asp:Label>
        <asp:Button ID="btnUpdateEmployerProfile" runat="server" Font-Size="Large" ForeColor="#000099" OnClick="btnUpdateEmployerProfile_Click" style="z-index: 1; left: 942px; top: 590px; position: absolute" Text="Update Employer Profile" />
        <asp:Button ID="btnFinalUpdate" runat="server" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 625px; position: absolute" Text="Update Profile" OnClick="btnFinalUpdate_Click" Visible="False" />

        <asp:FileUpload ID="uploadImage" runat="server" />

    </div>
    </form>
</body>
</html>
