<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Student_HomePage.aspx.cs" Inherits="DEVOPS_2.Student_HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="CSS/search/normalize.css" />
    <link rel="stylesheet" href="CSS/search/font-awesome.min.css" />
    <link rel="stylesheet" href="CSS/search/fontello.css" />
    <link rel="stylesheet" href="CSS/search/animate.css" />
    <link rel="stylesheet" href="CSS/bootstrap.min.css" />
    <link rel="stylesheet" href="CSS/search/owl.carousel.css" />
    <link rel="stylesheet" href="CSS/search/owl.theme.css" />
    <link rel="stylesheet" href="CSS/search/owl.transitions.css" />
    <%--<link rel="stylesheet" href="../CSS/search/style.css" />--%>
    <link rel="stylesheet" href="CSS/search/responsive.css" />
    <link rel="stylesheet" href="CSS/Site.css" />
    <link rel="stylesheet" href="CSS/nmmu.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Hero Section-->
    <div class="container">
        <div class="row">
            <div class="col-md-8 col-md-offset-2">


                <div class="my-container">
                    <section style="background: url('images/header1.png') no-repeat; " class="hero d-flex align-items-center">
                        <div class="container">

                            <h1 style="color: #FFFFFF">Seach for jobs</h1>
                            <p class="text-hero">Use the filters below to find a job that suits your needs</p>
                            <div class="search-bar">
                                <form class="form-inline">
                                    <div class="row">
                                        <div class="form-group col-lg-4">

                                            <asp:DropDownList ID="ddlEmployerName" runat="server" Height="16px" Width="212px">
                                            </asp:DropDownList>
                                        </div>
                                        <div class="form-group col-lg-3">

                                            <asp:DropDownList ID="ddlJobType" runat="server" Height="16px" Width="210px">
                                            </asp:DropDownList>

                                        </div>
                                        <div class="form-group col-lg-3">
                                                                                        
                                            <asp:DropDownList ID="ddlCity" runat="server" Height="16px" Width="210px">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="form-group col-lg-2">

                                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                                    </div>
                                </form>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        </div>
                <div></div>        <div></div>        <div></div>
        <div class="container">

            <div>
                <h2>Search Results</h2>
                <div></div>
                <div>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3">
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DEVOPSconnection %>" SelectCommand="SELECT Job_Post.JobTitle, Job_Post.DateClosing, City.CityDescription, Employer.Logo, Job_Type.TypeDescription, Skill.SkillDescription, Qualification.QualificationDescription FROM City INNER JOIN Employer ON City.CityID = Employer.CityID INNER JOIN Job_Post ON Employer.Employer_ID = Job_Post.EmployerID INNER JOIN Job_Type ON Job_Post.TypeID = Job_Type.TypeID INNER JOIN Qualification ON Job_Post.QualID = Qualification.QualID INNER JOIN Skill ON Job_Post.SkillID = Skill.SkillID"></asp:SqlDataSource>
                </div>
            </div>
        </div>
        <div></div>
                <div></div>
        <div class="container">
            <asp:FormView ID="FormView1" runat="server" CellPadding="4" ForeColor="#333333" DataSourceID="SqlDataSource2" Height="239px" Width="979px">
                <EditItemTemplate>
                    JobTitle:
                    <asp:TextBox ID="JobTitleTextBox" runat="server" Text='<%# Bind("JobTitle") %>' />
                    <br />
                    DateClosing:
                    <asp:TextBox ID="DateClosingTextBox" runat="server" Text='<%# Bind("DateClosing") %>' />
                    <br />
                    JobDescription:
                    <asp:TextBox ID="JobDescriptionTextBox" runat="server" Text='<%# Bind("JobDescription") %>' />
                    <br />
                    KeyResponsibilities:
                    <asp:TextBox ID="KeyResponsibilitiesTextBox" runat="server" Text='<%# Bind("KeyResponsibilities") %>' />
                    <br />
                    CityDescription:
                    <asp:TextBox ID="CityDescriptionTextBox" runat="server" Text='<%# Bind("CityDescription") %>' />
                    <br />
                    TypeDescription:
                    <asp:TextBox ID="TypeDescriptionTextBox" runat="server" Text='<%# Bind("TypeDescription") %>' />
                    <br />
                    QualificationDescription:
                    <asp:TextBox ID="QualificationDescriptionTextBox" runat="server" Text='<%# Bind("QualificationDescription") %>' />
                    <br />
                    SkillDescription:
                    <asp:TextBox ID="SkillDescriptionTextBox" runat="server" Text='<%# Bind("SkillDescription") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <InsertItemTemplate>
                    JobTitle:
                    <asp:TextBox ID="JobTitleTextBox" runat="server" Text='<%# Bind("JobTitle") %>' />
                    <br />
                    DateClosing:
                    <asp:TextBox ID="DateClosingTextBox" runat="server" Text='<%# Bind("DateClosing") %>' />
                    <br />
                    JobDescription:
                    <asp:TextBox ID="JobDescriptionTextBox" runat="server" Text='<%# Bind("JobDescription") %>' />
                    <br />
                    KeyResponsibilities:
                    <asp:TextBox ID="KeyResponsibilitiesTextBox" runat="server" Text='<%# Bind("KeyResponsibilities") %>' />
                    <br />
                    CityDescription:
                    <asp:TextBox ID="CityDescriptionTextBox" runat="server" Text='<%# Bind("CityDescription") %>' />
                    <br />
                    TypeDescription:
                    <asp:TextBox ID="TypeDescriptionTextBox" runat="server" Text='<%# Bind("TypeDescription") %>' />
                    <br />
                    QualificationDescription:
                    <asp:TextBox ID="QualificationDescriptionTextBox" runat="server" Text='<%# Bind("QualificationDescription") %>' />
                    <br />
                    SkillDescription:
                    <asp:TextBox ID="SkillDescriptionTextBox" runat="server" Text='<%# Bind("SkillDescription") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    JobTitle:
                    <asp:Label ID="JobTitleLabel" runat="server" Text='<%# Bind("JobTitle") %>' />
                    <br />
                    DateClosing:
                    <asp:Label ID="DateClosingLabel" runat="server" Text='<%# Bind("DateClosing") %>' />
                    <br />
                    JobDescription:
                    <asp:Label ID="JobDescriptionLabel" runat="server" Text='<%# Bind("JobDescription") %>' />
                    <br />
                    KeyResponsibilities:
                    <asp:Label ID="KeyResponsibilitiesLabel" runat="server" Text='<%# Bind("KeyResponsibilities") %>' />
                    <br />
                    CityDescription:
                    <asp:Label ID="CityDescriptionLabel" runat="server" Text='<%# Bind("CityDescription") %>' />
                    <br />
                    TypeDescription:
                    <asp:Label ID="TypeDescriptionLabel" runat="server" Text='<%# Bind("TypeDescription") %>' />
                    <br />
                    QualificationDescription:
                    <asp:Label ID="QualificationDescriptionLabel" runat="server" Text='<%# Bind("QualificationDescription") %>' />
                    <br />
                    SkillDescription:
                    <asp:Label ID="SkillDescriptionLabel" runat="server" Text='<%# Bind("SkillDescription") %>' />
                    <br />
                </ItemTemplate>
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
            </asp:FormView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DEVOPSconnection %>" SelectCommand="SELECT Job_Post.JobTitle, Job_Post.DateClosing, Job_Post.JobDescription, Job_Post.KeyResponsibilities, City.CityDescription, Job_Type.TypeDescription, Qualification.QualificationDescription, Skill.SkillDescription FROM Job_Post INNER JOIN City ON Job_Post.CityID = City.CityID INNER JOIN Job_Type ON Job_Post.TypeID = Job_Type.TypeID INNER JOIN Qualification ON Job_Post.QualID = Qualification.QualID INNER JOIN Skill ON Job_Post.SkillID = Skill.SkillID INNER JOIN Employer ON Job_Post.EmployerID = Employer.Employer_ID"></asp:SqlDataSource>
        </div>
    </div>
</asp:Content>
