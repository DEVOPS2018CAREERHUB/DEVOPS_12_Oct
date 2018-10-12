<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DEVOPS_2.Register" %>

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

</head>
<body id="imageSelect" style="background-image: url('images/StudReg_01.png'); background-repeat:no-repeat;" >
    <form id="form1" runat="server">
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
        
            <asp:Label ID="lblText1" runat="server" Font-Size="Large" ForeColor="Yellow" style="z-index: 1; left: 904px; top: 257px; position: absolute" Text="Student Number"></asp:Label>
        
        <asp:Label ID="Label2" runat="server" Font-Size="Large" ForeColor="Yellow" style="z-index: 1; left: 905px; top: 347px; position: absolute" Text="E-mail Address"></asp:Label>
        <asp:Label ID="Label3" runat="server" Font-Size="Large" ForeColor="Yellow" style="z-index: 1; left: 904px; top: 439px; position: absolute" Text="Password"></asp:Label>
        <asp:Label ID="Label4" runat="server" Font-Size="Large" ForeColor="Yellow" style="z-index: 1; left: 903px; top: 528px; position: absolute" Text="Confirm Password"></asp:Label>
        <asp:Button ID="Button1" runat="server" BackColor="#FFB900" Font-Size="Large" OnClick="Button1_Click" style="z-index: 1; left: 905px; top: 638px; position: absolute; width: 154px; height: 44px" Text="Register" />
        <asp:TextBox ID="txt1" runat="server" BackColor="#001E2F" Font-Size="Large" ForeColor="Yellow" style="z-index: 1; left: 950px; top: 289px; position: absolute; height: 38px; width: 210px" TextMode="Number"></asp:TextBox>
        <asp:TextBox ID="txt2" runat="server" BackColor="#001E2F" style="z-index: 1; left: 950px; top: 380px; position: absolute; width: 210px; height: 38px;" Font-Size="Large" ForeColor="Yellow"></asp:TextBox>
        
        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="txt2" ErrorMessage="Email Address is required"
            SetFocusOnError="True"></asp:RequiredFieldValidator>

        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
             ErrorMessage="Invalid Email Address" ControlToValidate="txt2"
             SetFocusOnError="True"
             ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
        </asp:RegularExpressionValidator>--%>

        <asp:TextBox ID="txt3" runat="server" BackColor="#001E2F" style="z-index: 1; left: 950px; top: 467px; position: absolute; width: 210px; height: 38px;" Font-Size="Large" ForeColor="Yellow" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txt4" runat="server" BackColor="#001E2F" style="z-index: 1; left: 950px; top: 559px; position: absolute; width: 210px; height: 38px;" Font-Size="Large" ForeColor="Yellow" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblpasswords" runat="server" Font-Size="Large" ForeColor="#FF3300" style="position: absolute; z-index: 1; left: 904px; top: 608px" Text="Password and Confirm Password do not match!"></asp:Label>
        <asp:Button ID="btnStudent" runat="server" OnClick="btnStudent_Click" style="height: 169px; width: 38px; z-index: 1; top: 219px; position: absolute; left: 836px;" BackColor="Transparent" />
        <asp:Button ID="btnEmployer" runat="server" OnClick="btnEmployer_Click" style="height: 120px; width: 38px; z-index: 1; top: 98px; position: absolute; left: 836px;" BackColor="Transparent" />      
        <asp:Label ID="lblIncorrectEmail" runat="server" Font-Size="Large" ForeColor="#FF3300" style="z-index: 1; left: 1029px; top: 348px; position: absolute" Text="Incorrect Email Format!"></asp:Label>
        <asp:Label ID="lblStudNoNotRegistered" runat="server" Font-Size="Large" ForeColor="#FF3300" style="z-index: 1; left: 1032px; top: 257px; position: absolute" Text="Not a registered student number!"></asp:Label>    
             
        
    </form>
</body>
</html>
