<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployerLogin.aspx.cs" Inherits="Project_DevOps.EmployerLogin" %>

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
        .testing {
            opacity: .78; 
            width: 10px;
        }
      

    </style>

    <script id="facebook-jssdk" src="Scripts/all.js.download"></script>
    <script id="twitter-wjs" src="Scripts/widgets.js.download"></script>
    <script async="" src="Scripts/ga.js.download" type="text/javascript"></script>
</head>
<body style="height: 19px">
    <form id="form1" runat="server">
    <div style="background-image: url('images1/EmpReg_0.jpg'); background-repeat: no-repeat; height: 620px; width: 1254px;">
    
        <asp:TextBox ID="empPasswordtxt" runat="server" TextMode ="Password" style="z-index: 1; left: 709px; top: 294px; position: absolute; height: 26px; width: 271px"></asp:TextBox>
    
        <asp:Button ID="studBtn" runat="server" style="z-index: 1; left: 679px; top: 170px; position: absolute; height: 127px; background-color : transparent; width: 30px; margin-left: 0px;" OnClick="studBtn_Click" />
    
        <asp:TextBox ID="empUsernametxt" runat="server" style="z-index: 1; left: 710px; top: 219px; position: absolute; height: 24px; width: 265px"></asp:TextBox>
    
        <asp:Label ID="empLoginlbl" runat="server" ForeColor="Yellow" style="z-index: 1; left: 714px; top: 190px; position: absolute; width: 269px; height: 24px; font-size: large; margin-top: 0px;" Text="Employer Email"></asp:Label>
        <asp:Label ID="empPasswordlbl" runat="server" ForeColor="Yellow" style="z-index: 1; left: 712px; top: 264px; position: absolute; height: 24px; width: 251px; font-size: large" Text="Employer Password"></asp:Label>
    
        <asp:Button ID="RegisterBtn" runat="server" BackColor="Yellow" OnClick="RegisterBtn_Click" style="z-index: 1; left: 715px; top: 397px; position: absolute; height: 37px; width: 80px; font-size: medium; right: 471px" Text="Register" />
        <asp:Button ID="empLoginBtn" runat="server" BackColor="Yellow" style="z-index: 1; left: 885px; top: 390px; position: absolute; height: 34px; width: 86px; font-size: medium; bottom: 161px; margin-top: 9px;" Text="Login" OnClick="empLoginBtn_Click" />
    
        <asp:Label ID="errorLbl" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 717px; top: 337px; position: absolute; height: 26px; width: 262px; font-size: medium; font-weight: 700" Text="Incorrect Username or Password"></asp:Label>
    
        <asp:HyperLink ID="HypLinkForgot" runat="server"  style="top: 362px; font-weight: 700; visibility:visible"  >Forgot Password</asp:HyperLink>
    
        
       <%-- <asp:Login ID="Login1" runat="server" ForeColor="#FFCC00" Width="301px"  >
            <LayoutTemplate>
                <table cellpadding="1" cellspacing="0" style="border-collapse:collapse; z-index: 1; left: 706px; top: 151px; position: absolute; width: 268px;">
                    <tr>
                        <td>
                            <table cellpadding="0">
                                <tr>
                                    <td align="center" colspan="2">
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DEVOPSconnection %>" ProviderName="System.Data.SqlClient" SelectCommand="uspCheckEmployerLogin" SelectCommandType="StoredProcedure">
                                            <SelectParameters>
                                                <asp:ControlParameter ControlID="UserName" Name="employerEmail" PropertyName="Text" Type="String" />
                                                <asp:ControlParameter ControlID="Password" Name="employerPassword" PropertyName="Text" Type="String" />
                                            </SelectParameters>
                                        </asp:SqlDataSource>
                                        Log In</td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Email:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="UserName" runat="server" Width="174px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time." />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2" style="color:Red;">
                                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" colspan="2">
                                        <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" OnClick="LoginButton_Click" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
        </asp:Login>--%>
    
    </div>
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
                    </div>
                </div>
            </div>
                    <div id="divSearchOnMobile" class="col-xs-4 hidden-md hidden-lg">
                    </div>
    </form>
</body>
</html>
