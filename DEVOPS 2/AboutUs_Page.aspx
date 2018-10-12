<%@ Page Title="About Us" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="AboutUs_Page.aspx.cs" Inherits="DEVOPS_2.AboutUs_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <div class="container MainContent">
        <div></div>
        <div class="PageHeader">
            <h1>About Us</h1>
        </div>
        <div class="row">
            <!--opening div bootstrap -->
            <!-- placeholder start -->
            <div class="GenericWide col-sm-12 tbsVpad BoxWhite">
                <p>
                    <img alt="Vision and mission" style="margin-left: 200px; width: 732px; height: 281px" src="Images/background6.png" /></p>
                <h2>Vision</h2>
                <p >Our vision as a strategically placed unit within a values-driven and engaged institution is to become the first choice career services centre that provides good quality services to our students, alumni as well as national and international employers that recruit from Nelson Mandela University.</p>
                <p align:"right">&nbsp;</p>
                <h2>Mission</h2>
                <p><%--<img alt="mission" style="width: 200px; float: left; height: 288px; margin-right: 20px" src="./Vision and Mission_files/mission_vision_big.jpg">--%></p>
                <p>Guided by the institution’s vision, mission, values and principles, and operating within the ambit of the goals and strategic objectives of the Engagement Office the Graduate and Student Placement Unit seeks to optimise the provision of graduate and student recruitment services to internal and external stakeholders seeking to employ the institutions graduates and students.</p>
            </div>
            <!-- placeholder finish-->
            <div class="col-sm-3 tbsColLast">

                <div class="col-sm-12" style="min-height: 0px;">
                </div>
            </div>
        </div>
    </div>
    <!--container-->
</asp:Content>
