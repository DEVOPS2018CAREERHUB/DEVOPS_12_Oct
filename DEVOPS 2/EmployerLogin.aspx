<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployerLogin.aspx.cs" Inherits="Project_DevOps.EmployerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 19px">
    <form id="form1" runat="server">
    <div style="background-image: url('images1/EmpReg_0.jpg'); background-repeat: no-repeat; height: 620px; width: 1254px;">
    
        <asp:TextBox ID="empPasswordtxt" runat="server" TextMode ="Password" style="z-index: 1; left: 709px; top: 294px; position: absolute; height: 26px; width: 271px"></asp:TextBox>
    
        6<asp:Button ID="studBtn" runat="server" style="z-index: 1; left: 679px; top: 170px; position: absolute; height: 127px; background-color : transparent; width: 30px; margin-left: 0px;" OnClick="studBtn_Click" />
    
        <asp:Button ID="empBtn" runat="server" style="z-index: 1; left: 678px; top: 82px; position: absolute; width: 31px; height: 85px; background-color : transparent" OnClick="empBtn_Click" />
    
        <asp:TextBox ID="empUsernametxt" runat="server" style="z-index: 1; left: 710px; top: 219px; position: absolute; height: 24px; width: 265px"></asp:TextBox>
    
        <asp:Label ID="empLoginlbl" runat="server" ForeColor="Yellow" style="z-index: 1; left: 714px; top: 190px; position: absolute; width: 269px; height: 24px; font-size: large; margin-top: 0px;" Text="Employer Email"></asp:Label>
        <asp:Label ID="empPasswordlbl" runat="server" ForeColor="Yellow" style="z-index: 1; left: 712px; top: 264px; position: absolute; height: 24px; width: 251px; font-size: large" Text="Employer Password"></asp:Label>
    
        <asp:Button ID="nmuBtn" runat="server" style="z-index: 1; left: 711px; top: 75px; position: absolute; height: 104px; width: 269px; margin-top: 4px; background-color : transparent" BorderColor="#091B27" OnClick="nmuBtn_Click" />
    
        <asp:Button ID="RegisterBtn" runat="server" BackColor="Yellow" OnClick="RegisterBtn_Click" style="z-index: 1; left: 715px; top: 371px; position: absolute; height: 37px; width: 80px; font-size: medium; right: 471px" Text="Register" />
        <asp:Button ID="empLoginBtn" runat="server" BackColor="Yellow" style="z-index: 1; left: 885px; top: 362px; position: absolute; height: 34px; width: 86px; font-size: medium; bottom: 161px; margin-top: 9px;" Text="Login" OnClick="empLoginBtn_Click" />
    
        <asp:Label ID="errorLbl" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 717px; top: 337px; position: absolute; height: 26px; width: 234px; font-size: medium; font-weight: 700" Text="Incorrect Username or Password"></asp:Label>
    
    </div>
    </form>
</body>
</html>
