<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="DEVOPS_2.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forgot Password</title>
    <style type="text/css">
        .auto-style3 {
            width: 195px;
            height: 33px;
            color: #FFCC00;
        }
        .auto-style5 {
            width: 195px;
            font-size: large;
            color: #FFCC00;
            height: 33px;
        }
        .auto-style6 {
            width: 284px;
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-repeat: no-repeat; background-image: url('images1/Addjob05.png'); height: 610px; width: 1226px; font-size: medium; font-weight: 700;">
    
        <asp:Label ID="lblForgotPassword" runat="server" ForeColor="#FFCC00" style="font-size: x-large; font-weight: 700; z-index: 1; left: 552px; top: 54px; position: absolute" Text="Forgot Password"></asp:Label>
        <table style="z-index: 1; left: 387px; top: 115px; position: absolute; height: 94px; width: 489px">
            <tr>
                <td class="auto-style5">Username</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtUsename" runat="server" Width="272px"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td class="auto-style3">Email</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtEmail" runat="server" Width="272px"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td class="auto-style3">New Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtNewPassword" runat="server" Width="272px"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td class="auto-style3">Comfirm Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtComfirmPassword" runat="server" Width="272px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
        <asp:Button ID="btnRestPassword" runat="server" BackColor="#FFCC00" ForeColor="Black" style="z-index: 1; left: 741px; top: 282px; position: absolute; width: 129px; font-size: medium; font-weight: 700" Text="Rest Password" />
    
    </div>
    </form>
</body>
</html>
