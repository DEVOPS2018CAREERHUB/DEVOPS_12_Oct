<%@ Page Title="" Language="C#" MasterPageFile="~/STUDENT/STUD.Master" AutoEventWireup="true" CodeBehind="STUD_HomePage.aspx.cs" Inherits="DEVOPS_2.STUDENT.STUD_HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../CSS/main.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <!--opening div bootstrap -->
            <!-- placeholder start -->
        </div>
        <div class="row tbsRow">
            <div class="col-sm-12 tbsHnopad">
                <div class="col-sm-12 BoxArtYellow   tbsVpad ">
                    <h2>Hello
                        <asp:Label ID="lblUser" runat="server" Text="Label"></asp:Label></h2>
                    <p></p>
                    <p></p>
                    <asp:GridView ID="dgvTotalAppliedJobs" runat="server"></asp:GridView>
                </div>
            </div>
        </div>
    </div>

    <div style="height: 25px"></div>
    <%--SIDE FILTER--%>
    <section>
        <%----------------TOP ROW----------------%>
        <div class="row tbsRow">
            <div class="col-sm-3 tbsColFirst" style="left: 0px; top: 0px; height: inherit">
                <div class="col-sm-12 rowSizer BoxLightGrey tbsVpad " style="height: 500px;">
                    <div class="NewsPTitle">
                        <h3 style="color: #FFFFFF;"></h3>
                        <%----------------ACCORDION FILTER STARTS HERE----------------%>
                        <div class="panel-group" id="accordion">
                            <%----------------CLOSING DATE FILTER----------------%>
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    <h4 class="panel-title">
                                        <a data-toggle="collapse" data-parent="#accordion" href="#collapse1">Jobs Posted</a>
                                    </h4>
                                </div>
                                <div id="collapse1" class="panel-collapse collapse in">
                                    <div class="panel-body">
                                        <asp:GridView ID="dgvPosts" runat="server" BorderStyle="None" GridLines="None" ShowHeader="False" Width="235px"></asp:GridView>


                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <div class="col-sm-9 tbsColLast" style="left: 0px; top: 0px">
                <div class="col-sm-12 rowSizer BoxLightGrey TextWhite  tbsVpad " style="height: 500px;">
                    <div class="col-sm-12 tbsHnopad">
                        <div class="col-sm-12 rowSizer tbsHnopad" style="height: 267px;">
                            <h3 style="color: #FFFFFF;">Jobs Applied </h3>
                            <div>
                                <asp:GridView ID="dgvAppliedJobs" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal">
                                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                    <SortedDescendingHeaderStyle BackColor="#242121" />
                                </asp:GridView>

                                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
