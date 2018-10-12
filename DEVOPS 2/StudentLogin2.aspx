<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentLogin2.aspx.cs" Inherits="Project_DevOps.StudentLogin2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-image: url('images1/StudReg_02.jpg'); height: 642px; width: 1240px; background-repeat: no-repeat;">
      <asp:TextBox ID="studPasswordtxt" runat="server" TextMode ="Password" style="z-index: 1; left: 812px; top: 276px; position: absolute; height: 26px; width: 271px" OnTextChanged="studPasswordtxt_TextChanged"></asp:TextBox>
    
        <asp:Button ID="StudBtn" runat="server" style="z-index: 1; left: 761px; top: 171px; position: absolute; height: 127px; background-color : transparent; width: 34px; margin-left: 0px; bottom: 268px;" OnClick="StudBtn_Click" />
    
        <asp:Button ID="EmpBtn" runat="server" style="z-index: 1; left: 760px; top: 81px; position: absolute; width: 35px; height: 85px; background-color : transparent; margin-right: 0px;" OnClick="EmpBtn_Click" />
    
        <asp:TextBox ID="studUsernametxt" runat="server" style="z-index: 1; left: 809px; top: 207px; position: absolute; height: 24px; width: 274px" OnTextChanged="studUsernametxt_TextChanged"></asp:TextBox>
    
        <asp:Label ID="studLoginlbl" runat="server" ForeColor="Yellow" style="z-index: 1; left: 806px; top: 178px; position: absolute; width: 269px; height: 24px; font-size: large; margin-top: 0px;" Text="Student Username"></asp:Label>
        <asp:Label ID="studPasswordlbl" runat="server" ForeColor="Yellow" style="z-index: 1; left: 810px; top: 247px; position: absolute; height: 24px; width: 251px; font-size: large" Text="Student Password"></asp:Label>
    
        <asp:Button ID="nmuBtn" runat="server" style="z-index: 1; left: 797px; top: 78px; position: absolute; height: 86px; width: 305px; margin-top: 4px; background-color : transparent" BorderColor="#091B27" OnClick="nmuBtn_Click" />
    
        <asp:Button ID="RegisterBtn" runat="server" BackColor="Yellow" OnClick="RegisterBtn_Click" style="z-index: 1; left: 821px; top: 360px; position: absolute; height: 37px; width: 80px; font-size: medium; right: 351px" Text="Register" />
        <asp:Button ID="studLoginBtn" runat="server" BackColor="Yellow" style="z-index: 1; left: 1010px; top: 352px; position: absolute; height: 34px; width: 86px; font-size: medium; bottom: 171px; margin-top: 9px;" Text="Login" OnClick="studLoginBtn_Click" />
    
        <asp:Label ID="errorLbl" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 816px; top: 322px; position: absolute; height: 26px; width: 234px; font-size: medium; font-weight: 700" Text="Incorrect Username or Password"></asp:Label>
    
    </div>
    </form>
</body>
</html>
