<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Landing_Page.aspx.cs" Inherits="DEVOPS_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('images/land_back.png'); height: 817px; width: 1600px; z-index: 1; left: 0px; top: 0px; background-repeat:no-repeat; ">
        
    <form id="form1" runat="server" style="width: 1600px; height: 817px">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="50px" ForeColor="Yellow" style="z-index: 1; left: 109px; top: 248px; position: absolute" Text="Welcome to Career Hub"></asp:Label>
            <asp:Button ID="Button1" runat="server" BackColor="#FFB900" ForeColor="#001628" OnClick="Button1_Click1" style="z-index: 1; left: 1317px; top: 670px; position: absolute; height: 47px; width: 197px;" Text="Register" Font-Size="Larger" />
        </div>
        
    </form>
</body>
</html>
