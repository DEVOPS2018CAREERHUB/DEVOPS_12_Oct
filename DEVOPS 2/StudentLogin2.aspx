﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentLogin2.aspx.cs" Inherits="Project_DevOps.StudentLogin2" %>

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
<body>
	<form id="form1" runat="server">
	<div style="background-image: url('images1/StudReg_02.jpg'); height: 642px; width: 1240px; background-repeat: no-repeat;">
	  <asp:TextBox ID="studPasswordtxt" runat="server" TextMode ="Password" style="z-index: 1; left: 812px; top: 276px; position: absolute; height: 26px; width: 271px" OnTextChanged="studPasswordtxt_TextChanged"></asp:TextBox>
	
		<asp:Button ID="EmpBtn" runat="server" style="z-index: 1; left: 760px; top: 81px; position: absolute; width: 35px; height: 85px; background-color : transparent; margin-right: 0px;" OnClick="EmpBtn_Click" />
	
		<asp:TextBox ID="studUsernametxt" runat="server" style="z-index: 1; left: 809px; top: 207px; position: absolute; height: 24px; width: 274px" OnTextChanged="studUsernametxt_TextChanged"></asp:TextBox>
	
		<asp:Label ID="studLoginlbl" runat="server" ForeColor="Yellow" style="z-index: 1; left: 806px; top: 178px; position: absolute; width: 269px; height: 24px; font-size: large; margin-top: 0px;" Text="Student Username"></asp:Label>
		<asp:Label ID="studPasswordlbl" runat="server" ForeColor="Yellow" style="z-index: 1; left: 810px; top: 247px; position: absolute; height: 24px; width: 251px; font-size: large" Text="Student Password"></asp:Label>
	
		<asp:Button ID="RegisterBtn" runat="server" BackColor="Yellow" OnClick="RegisterBtn_Click" style="z-index: 1; left: 821px; top: 360px; position: absolute; height: 37px; width: 80px; font-size: medium; right: 351px" Text="Register" />
		<asp:Button ID="studLoginBtn" runat="server" BackColor="Yellow" style="z-index: 1; left: 1010px; top: 352px; position: absolute; height: 34px; width: 86px; font-size: medium; bottom: 171px; margin-top: 9px;" Text="Login" OnClick="studLoginBtn_Click" />
	
		<asp:Label ID="errorLbl" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 816px; top: 322px; position: absolute; height: 26px; width: 234px; font-size: medium; font-weight: 700" Text="Incorrect Username or Password"></asp:Label>
	
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

					<div id="divSearchOnMobile" class="col-xs-4 hidden-md hidden-lg">
					</div>
				</div>
			</div>
		</div>
	</form>
</body>
</html>
