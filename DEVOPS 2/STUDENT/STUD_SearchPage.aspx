﻿<%@ Page Title="Search Jobs" Language="C#" MasterPageFile="~/STUDENT/STUD.Master" AutoEventWireup="true" CodeBehind="STUD_SearchPage.aspx.cs" Inherits="DEVOPS_2.STUDENT.STUD_SearchPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<link rel="stylesheet" href="../CSS/bootstrap.min.css" />--%>
    <link rel="stylesheet" href="../CSS/main.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
        p.ex2 {
    padding-left: 85px;
        }
                h1.ex1 {
    padding-left: 85px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section style="height: 30px"></section>
    <%---------------------------------------------------SEARCH PANEL---------------------------------------------------%>
    <section style="background-image: url(../Images/header1.png); background-size: 100% 100%; background-position: center">
        <section id="intro" class="section-intro">
            <div style="height: 20px"></div>
            <div class="overlay">
                <div class="container">
                    <div class="main-text">
                        <h1 class="ex1" style="color: #ffffff">Welcome To Hub Search</h1>
                        <p class="ex2" style="color: #ffffff">Use the filters below to tailor the job search to your needs</p>
                    </div>
                </div>
                <div class="row semi-transp-light main-search-form-wrap">
                    <div class="col-xs-1" style="width: 85px">
                    </div>
                    <div class="col-md-3 col-sm-6 search-col text-left">
                        <label for="job_employer" class="main-search-form-label">Employer</label>
                        <asp:DropDownList ID="ddlEmployerName" runat="server" Height="35px" Width="220px"></asp:DropDownList>

                    </div>
                    <div class="col-md-3 col-sm-6 search-col text-left">
                        <label for="job_type" class="main-search-form-label">Employment Type</label>
                        <asp:DropDownList ID="ddlJobType" runat="server" Height="35px" Width="220px"></asp:DropDownList>
                        <div id="location_suggest" class="dropdown-menu" style="display: none; margin-left: 15px; width: 60%">
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 search-col text-left">
                        <label for="job_Location" class="main-search-form-label">City</label>
                        <asp:DropDownList ID="ddlCity" runat="server" Height="35px" Width="220px"></asp:DropDownList>
                    </div>

                    <div class="col-xs-2 search-col text-left">
                        <label>&nbsp;</label>
                        <label for="job_search" class="main-search-form-label">&nbsp;</label>
                        <label for="job_search" class="main-search-form-label">&nbsp;</label>
                        <div></div>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" />
                        <%--<asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"/>--%>
                    </div>
                </div>
            </div>
            <div></div>
        </section>
    </section>
    <div style="height: 25px"></div>
    <%--SIDE FILTER--%>
    <%---------------------------------------------------SIDE FILTER---------------------------------------------------%>
    <section>
        <%----------------TOP----------------%>
        <div class="row tbsRow">
            <div class="col-sm-3 tbsColFirst" style="left: 0px; top: 0px; height: inherit">
                <div class="col-sm-12 rowSizer BoxLightGrey tbsVpad " style="height: 500px;">
                    <div class="NewsPTitle">
                        <h3 style="color: #FFFFFF;">Filter</h3>
                        <%----------------ACCORDION FILTER STARTS HERE----------------%>
                        <div class="panel-group" id="accordion">
                            <%----------------CLOSING DATE FILTER----------------%>
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#collapse1">Closing Date</a>
                                    </h4>
                                </div>
                                <div id="collapse1" class="panel-collapse collapse in">
                                    <div class="panel-body">
                                        <asp:GridView ID="dgvClosingDate" runat="server" BorderStyle="None" GridLines="Horizontal" ShowHeader="False" Width="235px"></asp:GridView>

                                    </div>
                                </div>
                            </div>
                            <%----------------QUALIFICATION FILTER----------------%>
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#collapse2">Qualification</a>
                                    </h4>
                                </div>
                                <div id="collapse2" class="panel-collapse collapse">
                                    <div class="panel-body">
                                        <asp:GridView ID="dgvByQual" runat="server" BorderStyle="None" GridLines="None"  ShowHeader="False"></asp:GridView>

                                    </div>
                                </div>
                            </div>
                            <%----------------SKILL FILTER----------------%>
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#collapse3">Skill</a>
                                    </h4>
                                </div>
                                <div id="collapse3" class="panel-collapse collapse">
                                    <div class="panel-body">
                                        <asp:GridView ID="dgvBySkill" runat="server" BorderStyle="None" GridLines="None"  ShowHeader="False"></asp:GridView>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <%---------------------------------------------------SEARCH RESULTS LIST (GRIDVIEW)---------------------------------------------------%>
            <div class="col-sm-9 tbsColLast" style="left: 0px; top: 0px">
                <div class="col-sm-12 rowSizer BoxLightGrey TextWhite  tbsVpad " style="height: 500px;">
                    <div class="col-sm-12 tbsHnopad">
                        <div class="col-sm-12 rowSizer tbsHnopad" style="height: 267px;">
                            <h3 style="color: #FFFFFF;">Search Results</h3>
                            <div>
                                <asp:GridView ID="dgvJobList" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="JobID" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="Horizontal">
                                    <Columns>
                                        <asp:BoundField DataField="JobID" HeaderText="JobID" InsertVisible="False" ReadOnly="True" SortExpression="JobID" />
                                        <asp:BoundField DataField="JobTitle" HeaderText="JobTitle" SortExpression="JobTitle" />
                                        <asp:BoundField DataField="CityDescription" HeaderText="CityDescription" SortExpression="CityDescription" />
                                        <asp:BoundField DataField="TypeDescription" HeaderText="TypeDescription" SortExpression="TypeDescription" />
                                        <asp:BoundField DataField="DateClosing" HeaderText="DateClosing" SortExpression="DateClosing" />
                                        <asp:CommandField ShowSelectButton="True" />
                                    </Columns>
                                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                    <SelectedRowStyle BackColor="#FDB819" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                    <SortedDescendingHeaderStyle BackColor="#242121" />
                                </asp:GridView>
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DEVOPSconnection %>" SelectCommand="uspGetMostRecentJobPosts" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <%---------------------------------------------------VIEW DETAILS OF SELECTED JOB---------------------------------------------------%>
    <div style="height: 5px"></div>
    <section>
        <div class="row tbsRow">
            <div class="col-sm-3 tbsColFirst" style="left: 0px; top: 0px; height: inherit">
                <div class="col-sm-12 rowSizer tbsVpad " style="height: 500px;">
                </div>
            </div>
            <div class="col-sm-9 tbsColLast" style="left: 0px; top: 0px">
                <div class="col-sm-12 rowSizer BoxLightGrey TextWhite  tbsVpad " style="height: 500px;">
                    <div class="col-sm-12 tbsHnopad">
                        <div class="col-sm-12 rowSizer tbsHnopad" style="height: 267px;">
                            <h3 style="color: #FFFFFF;">Details</h3>
                            <div>
                                
<asp:DetailsView ID="dvJobDetails" runat="server" Height="50px" Width="800px" AutoGenerateRows="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="JobID" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal">
    <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
    <Fields>
        <asp:BoundField DataField="JobID" HeaderText="JobID" InsertVisible="False" ReadOnly="True" SortExpression="JobID" />
        <asp:BoundField DataField="JobTitle" HeaderText="JobTitle" SortExpression="JobTitle" />
        <asp:BoundField DataField="DatePosted" HeaderText="DatePosted" SortExpression="DatePosted" />
        <asp:BoundField DataField="DateClosing" HeaderText="DateClosing" SortExpression="DateClosing" />
        <asp:BoundField DataField="JobDescription" HeaderText="JobDescription" SortExpression="JobDescription" />
        <asp:BoundField DataField="KeyResponsibilities" HeaderText="KeyResponsibilities" SortExpression="KeyResponsibilities" />
        <asp:BoundField DataField="EmployerName" HeaderText="EmployerName" SortExpression="EmployerName" />
        <asp:BoundField DataField="TypeDescription" HeaderText="TypeDescription" SortExpression="TypeDescription" />
        <asp:BoundField DataField="SkillDescription" HeaderText="SkillDescription" SortExpression="SkillDescription" />
        <asp:BoundField DataField="QualificationDescription" HeaderText="QualificationDescription" SortExpression="QualificationDescription" />
        <asp:ButtonField ButtonType="Button" Text="Apply" />
    </Fields>
    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                </asp:DetailsView>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DEVOPSconnection %>" SelectCommand="uspGetSelectedJobDetails" SelectCommandType="StoredProcedure">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="dgvJobList" Name="jobPostID" PropertyName="SelectedValue" Type="Int32" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <div>
    </div>
    <div>
    </div>
</asp:Content>
