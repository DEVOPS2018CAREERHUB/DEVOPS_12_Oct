<%@ Page Title="Getting Started" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="GettingStarted_Page.aspx.cs" Inherits="DEVOPS_2.GettingStarted_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
        .auto-style2 {
            width: 421px;
            height: 243px;
        }
    </style>
            <link rel="stylesheet" href="CSS/Help/responsive.css" />
    <link rel="stylesheet" href="CSS/Help/style.css" />
    <link rel="stylesheet" type="text/css" href="CSS/Help/ootstrap.css"/>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <div class="container MainContent">
        <div></div>
        <div class="PageHeader">
            <h1>Getting Started</h1>
        </div>
    <%----------------TOP ROW----------------%>
    <div class="row tbsRow">
        <div class="col-sm-8 tbsColFirst">
            <div class="col-sm-12 rowSizer BoxBlack TextWhite  tbsVpad " style="height: 297px;">
                <div class="col-sm-12 tbsHnopad">
                    <div class="col-sm-12 rowSizer tbsHnopad" style="height: 267px;">
                        <div>
                        <div style="text-align: center">
                            <img src="images/Profile_2.png" class="auto-style2" />
                        </div></div>
                    </div>
                </div>

            </div>
        </div>
        <div class="col-sm-4 tbsColLast" style="left: 0px; top: 0px; height:inherit">
            <div class="col-sm-12 rowSizer BoxLightYellow TextWhite  tbsVpad " style="height: 297px;">
                <div class="NewsPTitle text-center">
                    <span style="font-weight: bolder; font-size: x-large;">1</span>
                    <i class="la la-user"></i>
                    <h3 style="font-family: Arial, Helvetica, sans-serif">Create a profile</h3>
                    <p style="color: #FFFFFF">Your profile will serve as a quick view version of your CV. Along with your profile you'll need to upload a recent copy of your CV. Please keep in mind that you'll need to update your CV every three months.</p>
                </div>
            </div>         
        </div>
    </div>

    <%----------------MIDDLE ROW---------%>
    <div class="row tbsRow">
        <div class="col-sm-4 tbsColFirst" style="left: 0px; top: 0px; height: inherit">
            <div class="col-sm-12 rowSizer BoxLightBlue TextWhite  tbsVpad " style="height: 297px;">
                <div class="NewsPTitle text-center">
                    <span style="font-weight: bolder; font-size: x-large;">2</span>
                    <i class="la la-user"></i>
                    <h3 style="font-family: Arial, Helvetica, sans-serif">Specify & Search for a Job</h3>
                    <p style="color: #FFFFFF">Use the filters to tailor the search to your requirements. Click on one of the results to view the job details.</p>
                </div>
            </div>
        </div>

        <div class="col-sm-8 tbsColLast" style="left: 0px; top: 0px">
            <div class="col-sm-12 rowSizer BoxBlack TextWhite  tbsVpad " style="height: 297px;">
                <div class="col-sm-12 tbsHnopad">
                    <div class="col-sm-12 rowSizer tbsHnopad" style="height: 267px;">
                        <div style="text-align: center">
                            <img src="images/Search.jpg" class="auto-style2" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
        <%----------------TOP ROW----------------%>
    <div class="row tbsRow">
        <div class="col-sm-8 tbsColFirst">
            <div class="col-sm-12 rowSizer BoxBlack TextWhite  tbsVpad " style="height: 297px;">
                <div class="col-sm-12 tbsHnopad">
                    <div class="col-sm-12 rowSizer tbsHnopad" style="height: 267px;">
                        <div style="text-align: center">
                            <img src="images/Apply.png" class="auto-style2"/>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <div class="col-sm-4 tbsColLast" style="left: 0px; top: 0px; height:inherit">
            <div class="col-sm-12 rowSizer BoxLightYellow TextWhite  tbsVpad " style="height: 297px;">
                <div class="NewsPTitle text-center">
                    <span style="font-weight: bolder; font-size: x-large;">3</span>
                    <i class="la la-user"></i>
                    <h3 style="font-family: Arial, Helvetica, sans-serif">Apply for a Job</h3>
                    <p style="color: #FFFFFF">Once you find job job that peeks your interest click apply.</p>
                </div>
            </div>         
        </div>
    </div>
               <div><div class="row tbsRow">
<div class="col-sm-12 tbsHnopad">
<div class="col-sm-12 BoxArtYellow   tbsVpad ">
<div class="row tbsRow">
<div style="text-align: center;">
<p><span style="font-size: large;"><strong>Get it? - <a href="Register.aspx" target="_blank">Got it...</a></strong></span></p></div>
<p>	&nbsp;</p></div></div></div></div></div>

            </div>
</asp:Content>
