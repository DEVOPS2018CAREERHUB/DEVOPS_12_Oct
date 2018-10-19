<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJob.aspx.cs" Inherits="Project_DevOps.AddJob" EnableViewState="true"%>

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
	<div style="background-image: url('images1/Addjob05.png'); background-repeat: no-repeat; height: 614px; width: 1226px;">
	
		<asp:Label ID="Label1" runat="server" ForeColor="Yellow" style="z-index: 1; left: 105px; top: 123px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Job Title"></asp:Label>
		<asp:Label ID="Label3" runat="server" ForeColor="Yellow" style="z-index: 1; left: 106px; top: 180px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Date Closing"></asp:Label>
		<asp:Label ID="Label4" runat="server" ForeColor="Yellow" style="z-index: 1; left: 105px; top: 214px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Country"></asp:Label>
		<asp:Label ID="Label5" runat="server" ForeColor="Yellow" style="z-index: 1; left: 106px; top: 272px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Job Description"></asp:Label>
		<asp:Label ID="Label6" runat="server" ForeColor="Yellow" style="z-index: 1; left: 102px; top: 356px; position: absolute; height: 24px; width: 167px; font-size: large;" Text="Key Responsibilities"></asp:Label>
		<asp:Label ID="Label7" runat="server" ForeColor="Yellow" style="z-index: 1; left: 103px; top: 413px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Qualification"></asp:Label>
		<asp:Label ID="Label8" runat="server" ForeColor="Yellow" style="z-index: 1; left: 496px; top: 454px; position: absolute; height: 23px; width: 85px; font-size: large; bottom: 76px; right: 318px;" Text="Skill"></asp:Label>
		<asp:Label ID="Label9" runat="server" ForeColor="Yellow" style="z-index: 1; left: 104px; top: 452px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Type"></asp:Label>
		<asp:Label ID="Label10" runat="server" ForeColor="Yellow" style="z-index: 1; left: 494px; top: 492px; position: absolute; height: 23px; width: 93px; font-size: large; right: 312px;" Text="Duration"></asp:Label>
		<asp:Label ID="Label11" runat="server" ForeColor="Yellow" style="z-index: 1; left: 102px; top: 491px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Start Date"></asp:Label>
		<asp:Label ID="Label13" runat="server" ForeColor="Yellow" style="z-index: 1; left: 102px; top: 539px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Posted By"></asp:Label>
		<asp:Label ID="Label14" runat="server" ForeColor="Yellow" style="z-index: 1; left: 493px; top: 536px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Status"></asp:Label>
		
	
		<asp:TextBox ID="jobTitletxt" runat="server" style="z-index: 1; left: 272px; top: 108px; position: absolute; width: 151px" ToolTip="e.g Partime Web Designer"></asp:TextBox>
		
	
		<asp:TextBox ID="dateClosingtxt" runat="server" style="z-index: 1; left: 274px; top: 173px; position: absolute; width: 151px" TextMode="Date"></asp:TextBox>
		<asp:DropDownList ID="countryDdl" runat="server" style="z-index: 1; left: 275px; top: 211px; position: absolute; width: 151px">
		</asp:DropDownList>
		<asp:DropDownList ID="cityDdl" runat="server" style="z-index: 1; left: 603px; top: 422px; position: absolute; width: 151px">
		</asp:DropDownList>
		<asp:TextBox ID="jobDesctxt" runat="server" style="z-index: 1; left: 275px; top: 250px; position: absolute; width: 347px; height: 53px" OnTextChanged="jobDesctxt_TextChanged"></asp:TextBox>
		<asp:Label ID="Label16" runat="server" ForeColor="Yellow" style="z-index: 1; left: 501px; top: 414px; position: absolute; height: 27px; width: 125px; font-size: large;" Text="City"></asp:Label>
		
	
		<asp:Label ID="Label18" runat="server" ForeColor="Yellow" style="z-index: 1; left: 565px; top: 149px; position: absolute; font-size: large" Text="Add Job"></asp:Label>
		<asp:Label ID="Label19" runat="server" ForeColor="Yellow" style="z-index: 1; left: 565px; top: 191px; position: absolute; font-size: large" Text="Update Job"></asp:Label>
		
	
		<asp:TextBox ID="keyRestxt" runat="server" style="z-index: 1; left: 275px; top: 337px; position: absolute; width: 347px; height: 53px"></asp:TextBox>
		<asp:DropDownList ID="qualDdl" runat="server" style="z-index: 1; left: 275px; top: 419px; position: absolute; width: 192px; height: 26px;">
		</asp:DropDownList>
		<asp:DropDownList ID="skillDdl" runat="server" style="z-index: 1; left: 604px; top: 454px; position: absolute; width: 151px">
		</asp:DropDownList>
		<asp:DropDownList ID="typeDdl" runat="server" style="z-index: 1; left: 276px; top: 451px; position: absolute; width: 151px">
		</asp:DropDownList>
		<asp:TextBox ID="duarationtxt" runat="server" style="z-index: 1; left: 605px; top: 490px; position: absolute; height: 23px; width: 151px" ToolTip="Job duration in WEEKS"></asp:TextBox>
		<asp:CompareValidator ControlToValidate="duarationtxt" runat="server" ErrorMessage="Numbers only please" Operator="DataTypeCheck" Type="Integer" ></asp:CompareValidator>
		<asp:TextBox ID="startDatetxt" runat="server" style="z-index: 1; left: 275px; top: 490px; position: absolute; width: 151px" TextMode="Date"></asp:TextBox>
		<asp:TextBox ID="postedBytxt" runat="server" style="z-index: 1; left: 275px; top: 527px; position: absolute; width: 151px" ToolTip="Employee Name"></asp:TextBox>
		<asp:CompareValidator ControlToValidate="postedBytxt" runat="server" ErrorMessage="Letters only please" Operator="DataTypeCheck" Type="String" ></asp:CompareValidator>
		<asp:DropDownList ID="statusDdl" runat="server" style="z-index: 1; left: 606px; top: 533px; position: absolute; width: 151px">
		</asp:DropDownList>
		
	
		<asp:TextBox ID="jobIDtxt" runat="server" style="z-index: 1; left: 597px; top: 109px; position: absolute; height: 15px" Visible="False"></asp:TextBox>
		<asp:CompareValidator ControlToValidate="jobIDtxt" runat="server" ErrorMessage="Numbers only please" Operator="DataTypeCheck" Type="Integer" ></asp:CompareValidator>
		<asp:Label ID="jobIDLbl" runat="server" ForeColor="Yellow" style="z-index: 1; left: 490px; top: 111px; position: absolute; width: 80px; font-size: large" Text="Job ID" Visible="False"></asp:Label>
		<asp:RadioButton ID="addRBtn" runat="server" AutoPostBack="True" Checked="True" GroupName="but" OnCheckedChanged="addRBtn_CheckedChanged" style="z-index: 1; left: 533px; top: 154px; position: absolute" ToolTip="Select to Add new job" />
		<asp:RadioButton ID="updateRBtn" runat="server" AutoPostBack="True" GroupName="but" OnCheckedChanged="updateRBtn_CheckedChanged" style="z-index: 1; left: 537px; top: 192px; position: absolute" ToolTip="Select to Update existing job" />
		<asp:Button ID="AddBtn" runat="server" BackColor="Yellow" OnClick="AddBtn_Click" style="z-index: 1; left: 282px; top: 600px; position: absolute" Text="Add" ForeColor="Black" />
		<asp:Button ID="UpdateBtn" runat="server" BackColor="Yellow" OnClick="UpdateBtn_Click" style="z-index: 1; left: 277px; top: 600px; position: absolute" Text="Update" Visible="False" ForeColor="Black" />
		
	
		<br />
		<asp:Label ID="LblEmpName" runat="server" ForeColor="Red" style="z-index: 1; left: 697px; top: 284px; position: absolute; height: 31px" Text="Label"></asp:Label>
		<asp:Button ID="btnView" runat="server" BackColor="Yellow" ForeColor="Black" OnClick="btnView_Click" style="z-index: 1; left: 698px; top: 600px; position: absolute" Text="View" />
	
	    
		
	
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
