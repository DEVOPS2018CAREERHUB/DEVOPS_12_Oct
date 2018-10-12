<%@ Page Title="" Language="C#" MasterPageFile="~/Employer.Master" AutoEventWireup="true" CodeBehind="Employer_HomePage.aspx.cs" Inherits="DEVOPS_2.Employer_HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../CSS/search/normalize.css" />
    <link rel="stylesheet" href="../CSS/search/font-awesome.min.css" />
    <link rel="stylesheet" href="../CSS/search/fontello.css" />
    <link rel="stylesheet" href="../CSS/search/animate.css" />
    <link rel="stylesheet" href="../CSS/bootstrap.min.css" />
    <link rel="stylesheet" href="../CSS/search/owl.carousel.css" />
    <link rel="stylesheet" href="../CSS/search/owl.theme.css" />
    <link rel="stylesheet" href="../CSS/search/owl.transitions.css" />
    <%--<link rel="stylesheet" href="../CSS/search/style.css" />--%>
    <link rel="stylesheet" href="../CSS/search/responsive.css" />
    <link rel="stylesheet" href="../CSS/Site.css" />
    <link rel="stylesheet" href="../CSS/nmmu.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Hero Section-->
    <div class="container">
        <div></div>
        <div></div>
        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <div class="my-container">
                    <section style="background: url('images/header2.png') no-repeat;" class="hero d-flex align-items-center">
                        <div class="container">

                            <h1 style="color: #FFFFFF">Seach for jobs</h1>
                            <p class="text-hero">Use the filters below to find a job that suits your needs</p>
                            <div class="search-bar">
                                <form class="form-inline">
                                    <div class="row">
                                        <div class="form-group col-lg-4">
                                            <asp:DropDownList ID="ddlCity" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="form-group col-lg-3">
                                            <asp:DropDownList ID="ddlQualifications" runat="server"></asp:DropDownList>
                                        </div>
                                        <div class="form-group col-lg-3">
                                            <asp:DropDownList ID="ddlSkills" runat="server"></asp:DropDownList>
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

        <div class="container">
                    <div></div>
        <div></div>
            <div>
                <h2>Search Results</h2>
                <div></div>
                <div>
                    <asp:GridView ID="dgvStudentSearchResult" runat="server" Width="615px"></asp:GridView>
                </div>
            </div>
        </div>
                <div></div>
        <div>
            <asp:FormView ID="FormView1" runat="server"></asp:FormView>
        </div>
    </div>

</asp:Content>
