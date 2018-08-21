<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DEVOPS_2.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('images/studreg_back.png'); background-repeat:no-repeat;" >
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblText1" runat="server" Font-Size="Large" ForeColor="Yellow" style="z-index: 1; left: 904px; top: 237px; position: absolute" Text="Student Number"></asp:Label>
        </p>
        <asp:Label ID="Label2" runat="server" Font-Size="Large" ForeColor="Yellow" style="z-index: 1; left: 905px; top: 327px; position: absolute" Text="E-mail Address"></asp:Label>
        <asp:Label ID="Label3" runat="server" Font-Size="Large" ForeColor="Yellow" style="z-index: 1; left: 904px; top: 419px; position: absolute" Text="Password"></asp:Label>
        <asp:Label ID="Label4" runat="server" Font-Size="Large" ForeColor="Yellow" style="z-index: 1; left: 903px; top: 508px; position: absolute" Text="Confirm Password"></asp:Label>
        <asp:Button ID="Button1" runat="server" BackColor="#FFB900" Font-Size="Large" OnClick="Button1_Click" style="z-index: 1; left: 905px; top: 618px; position: absolute; width: 154px; height: 44px" Text="Register" />
        <asp:RadioButtonList ID="rbnStudorEmp" runat="server" Font-Size="Larger" ForeColor="Yellow" style="z-index: 1; left: 83px; top: 145px; position: absolute; height: 208px; width: 254px">
            <asp:ListItem Selected="True">Student</asp:ListItem>
            <asp:ListItem>Employer</asp:ListItem>
        </asp:RadioButtonList>
        <asp:TextBox ID="txt1" runat="server" BackColor="#001E2F" Font-Size="Large" ForeColor="Yellow" style="z-index: 1; left: 950px; top: 265px; position: absolute; height: 38px; width: 210px"></asp:TextBox>
        <asp:TextBox ID="txt2" runat="server" BackColor="#001E2F" style="z-index: 1; left: 950px; top: 356px; position: absolute; width: 210px; height: 38px;"></asp:TextBox>
        <asp:TextBox ID="txt3" runat="server" BackColor="#001E2F" style="z-index: 1; left: 950px; top: 443px; position: absolute; width: 210px; height: 38px;"></asp:TextBox>
        <asp:TextBox ID="txt4" runat="server" BackColor="#001E2F" style="z-index: 1; left: 950px; top: 535px; position: absolute; width: 210px; height: 38px;"></asp:TextBox>
    </form>
</body>
</html>
