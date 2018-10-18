<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create_Employer_Profile.aspx.cs" Inherits="DEVOPS_2.Create_Employer_Profile" EnableViewState="true" %>

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
    <div class="shadow" style="z-index: 1; left: 116px; top: 160px; position: absolute; height: 100%; width: 1500px;">
    
        <asp:Label ID="lblEmployerName" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 10px; position: absolute" Text="Employer Name"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 45px; position: absolute" Text="Description"></asp:Label>
        <asp:Label ID="lblCountry" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 80px; position: absolute" Text="Country"></asp:Label>
        <asp:Label ID="lblCity" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 115px; position: absolute" Text="City"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 150px; position: absolute" Text="Email Address"></asp:Label>
        <asp:Label ID="lblVAT" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 185px; position: absolute" Text="VAT number"></asp:Label>
        <asp:Label ID="lblIndustry" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 220px; position: absolute" Text="Industry"></asp:Label>
            <asp:DropDownList ID="ddlEmployerIndustry" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 150px; top: 220px; position: absolute; width: 250px" AutoPostBack="True" OnSelectedIndexChanged="ddlEmployerIndustry_SelectedIndexChanged" ></asp:DropDownList>
            <asp:Label ID="lblAddNewIndustry" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 182px; z-index: 1; left: 420px; top: 220px; position: absolute" Text="Or add a new Industry:"></asp:Label>
            <asp:TextBox ID="txtAddNewIndustry" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 615px; top: 220px; position: absolute; width: 200px"  ></asp:TextBox>
            <asp:Button ID="btnAddNewIndustry" runat="server" Font-Size="Large" ForeColor="White" style="z-index: 1; left: 850px; top: 220px; position: absolute" Text="Add" OnClick="btnAddNewIndustry_Click" />
            <asp:TextBox ID="txtChosenIndID" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 676px; top: 160px; position: absolute; width: 91px" Enabled="False" Visible="False"  ></asp:TextBox>
        <asp:Label ID="lblLogo" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 127px; z-index: 1; left: 348px; top: 257px; position: absolute" Text="Employer Logo" Visible="false"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 290px; position: absolute" Text="Employer Username"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 325px; position: absolute" Text="Employer password"></asp:Label>
        <asp:Label ID="lblContactPerson" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 360px; position: absolute" Text="Contact Person"></asp:Label>
        <asp:Label ID="lblContactEmail" runat="server" Font-Size="Large" ForeColor="#000099" style="width: 200px; z-index: 1; left: 12px; top: 395px; position: absolute" Text="Contact Email Address"></asp:Label>

        <asp:TextBox ID="txtEmployerName" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 10px; position: absolute; width: 305px"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 45px; position: absolute; width: 305px"></asp:TextBox>
        <asp:DropDownList ID="ddlCountry" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 80px; position: absolute; width: 305px"></asp:DropDownList>
        <asp:DropDownList ID="ddlCity" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 115px; position: absolute; width: 305px"></asp:DropDownList>
        <asp:TextBox ID="txtEmail" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 150px; position: absolute; width: 305px"></asp:TextBox>
        <asp:TextBox ID="txtVAT" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 185px; position: absolute; width: 305px"></asp:TextBox>
        
                <asp:TextBox ID="txtChosenIndustry" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 220px; position: absolute; width: 300px"  ></asp:TextBox>
        <asp:FileUpload ID="uploadLogo" runat="server" BackColor="#F0F0F0" Font-Size="Large" ForeColor="#000099" style="left: 477px; position: absolute; width: 115px; top: 255px; visibility:hidden" />

        <asp:TextBox ID="txtUsername" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 290px; position: absolute; width: 305px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 325px; position: absolute; width: 305px"></asp:TextBox>
        <asp:TextBox ID="txtContactPerson" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 360px; position: absolute; width: 305px"></asp:TextBox>
        <asp:TextBox ID="txtContactEmail" runat="server" BackColor="#F0F0F0" BorderWidth="2px" Font-Size="Large" ForeColor="#000099" style="z-index: 1; left: 942px; top: 395px; position: absolute; width: 305px"></asp:TextBox>

        <asp:Button ID="btnCreateEProfile" runat="server" Font-Size="Larger" ForeColor="#000099" style="z-index: 1; left: 636px; top: 591px; position: absolute" Text="Create Profile" OnClick="btnCreateEProfile_Click1" />
        
    </div>
    </form>
</body>
</html>
