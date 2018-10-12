<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJob.aspx.cs" Inherits="Project_DevOps.AddJob" EnableViewState="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-image: url('images1/Addjob05.png'); background-repeat: no-repeat; height: 614px; width: 1226px;">
    
        <asp:Label ID="Label1" runat="server" ForeColor="Yellow" style="z-index: 1; left: 114px; top: 43px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Job Title"></asp:Label>
        <asp:Label ID="Label3" runat="server" ForeColor="Yellow" style="z-index: 1; left: 114px; top: 79px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Date Closing"></asp:Label>
        <asp:Label ID="Label4" runat="server" ForeColor="Yellow" style="z-index: 1; left: 114px; top: 117px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Country"></asp:Label>
        <asp:DropDownList ID="empDdl" runat="server" style="z-index: 1; left: 624px; top: 431px; position: absolute; width: 140px">
        </asp:DropDownList>
        <asp:Label ID="Label5" runat="server" ForeColor="Yellow" style="z-index: 1; left: 114px; top: 202px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Job Description"></asp:Label>
        <asp:Label ID="Label6" runat="server" ForeColor="Yellow" style="z-index: 1; left: 114px; top: 277px; position: absolute; height: 23px; width: 167px; font-size: large;" Text="Key Responsibilities"></asp:Label>
        <asp:Label ID="Label7" runat="server" ForeColor="Yellow" style="z-index: 1; left: 114px; top: 355px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Qualification"></asp:Label>
        <asp:Label ID="Label8" runat="server" ForeColor="Yellow" style="z-index: 1; left: 504px; top: 358px; position: absolute; height: 23px; width: 125px; font-size: large; bottom: 170px;" Text="Skill"></asp:Label>
        <asp:Label ID="Label9" runat="server" ForeColor="Yellow" style="z-index: 1; left: 114px; top: 393px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Type"></asp:Label>
        <asp:Label ID="Label10" runat="server" ForeColor="Yellow" style="z-index: 1; left: 504px; top: 392px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Duration"></asp:Label>
        <asp:Label ID="Label11" runat="server" ForeColor="Yellow" style="z-index: 1; left: 114px; top: 429px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Start Date"></asp:Label>
        <asp:Label ID="Label12" runat="server" ForeColor="Yellow" style="z-index: 1; left: 504px; top: 430px; position: absolute; height: 23px; width: 101px; font-size: large;" Text="Employer"></asp:Label>
        <asp:Label ID="Label13" runat="server" ForeColor="Yellow" style="z-index: 1; left: 114px; top: 469px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Posted By"></asp:Label>
        <asp:Label ID="Label14" runat="server" ForeColor="Yellow" style="z-index: 1; left: 504px; top: 466px; position: absolute; height: 23px; width: 125px; font-size: large;" Text="Status"></asp:Label>
        
    
        <asp:TextBox ID="jobTitletxt" runat="server" style="z-index: 1; left: 281px; top: 45px; position: absolute; width: 151px" ToolTip="e.g Partime Web Designer"></asp:TextBox>
        
    
        <asp:TextBox ID="dateClosingtxt" runat="server" style="z-index: 1; left: 282px; top: 81px; position: absolute; width: 151px" TextMode="Date"></asp:TextBox>
        <asp:DropDownList ID="countryDdl" runat="server" style="z-index: 1; left: 282px; top: 119px; position: absolute; width: 151px">
        </asp:DropDownList>
        <asp:DropDownList ID="cityDdl" runat="server" style="z-index: 1; left: 281px; top: 157px; position: absolute; width: 151px">
        </asp:DropDownList>
        <asp:TextBox ID="jobDesctxt" runat="server" style="z-index: 1; left: 282px; top: 197px; position: absolute; width: 347px; height: 53px" OnTextChanged="jobDesctxt_TextChanged"></asp:TextBox>
        <asp:Label ID="Label16" runat="server" ForeColor="Yellow" style="z-index: 1; left: 111px; top: 153px; position: absolute; height: 27px; width: 125px; font-size: large;" Text="City"></asp:Label>
        
    
        <asp:Label ID="Label18" runat="server" ForeColor="Yellow" style="z-index: 1; left: 558px; top: 92px; position: absolute; font-size: large" Text="Add Job"></asp:Label>
        <asp:Label ID="Label19" runat="server" ForeColor="Yellow" style="z-index: 1; left: 558px; top: 119px; position: absolute; font-size: large" Text="Update Job"></asp:Label>
        
    
        <asp:TextBox ID="keyRestxt" runat="server" style="z-index: 1; left: 280px; top: 276px; position: absolute; width: 347px; height: 53px"></asp:TextBox>
        <asp:DropDownList ID="qualDdl" runat="server" style="z-index: 1; left: 280px; top: 356px; position: absolute; width: 192px; height: 26px;">
        </asp:DropDownList>
        <asp:DropDownList ID="skillDdl" runat="server" style="z-index: 1; left: 622px; top: 357px; position: absolute; width: 151px">
        </asp:DropDownList>
        <asp:DropDownList ID="typeDdl" runat="server" style="z-index: 1; left: 280px; top: 393px; position: absolute; width: 151px">
        </asp:DropDownList>
        <asp:TextBox ID="duarationtxt" runat="server" style="z-index: 1; left: 622px; top: 393px; position: absolute; height: 17px; width: 151px" ToolTip="Job duration in WEEKS"></asp:TextBox>
        <asp:CompareValidator ControlToValidate="duarationtxt" runat="server" ErrorMessage="Numbers only please" Operator="DataTypeCheck" Type="Integer" ></asp:CompareValidator>
        <asp:TextBox ID="startDatetxt" runat="server" style="z-index: 1; left: 280px; top: 429px; position: absolute; width: 151px" TextMode="Date"></asp:TextBox>
        <asp:TextBox ID="postedBytxt" runat="server" style="z-index: 1; left: 280px; top: 467px; position: absolute; width: 151px" ToolTip="Employee Name"></asp:TextBox>
        <asp:CompareValidator ControlToValidate="postedBytxt" runat="server" ErrorMessage="Letters only please" Operator="DataTypeCheck" Type="String" ></asp:CompareValidator>
        <asp:DropDownList ID="statusDdl" runat="server" style="z-index: 1; left: 622px; top: 469px; position: absolute; width: 151px">
        </asp:DropDownList>
        
    
        <asp:TextBox ID="jobIDtxt" runat="server" style="z-index: 1; left: 581px; top: 45px; position: absolute; height: 15px" Visible="False"></asp:TextBox>
        <asp:CompareValidator ControlToValidate="jobIDtxt" runat="server" ErrorMessage="Numbers only please" Operator="DataTypeCheck" Type="Integer" ></asp:CompareValidator>
        <asp:Label ID="jobIDLbl" runat="server" ForeColor="Yellow" style="z-index: 1; left: 490px; top: 48px; position: absolute; width: 80px; font-size: large" Text="Job ID" Visible="False"></asp:Label>
        <asp:RadioButton ID="addRBtn" runat="server" AutoPostBack="True" Checked="True" GroupName="but" OnCheckedChanged="addRBtn_CheckedChanged" style="z-index: 1; left: 533px; top: 91px; position: absolute" ToolTip="Select to Add new job" />
        <asp:RadioButton ID="updateRBtn" runat="server" AutoPostBack="True" GroupName="but" OnCheckedChanged="updateRBtn_CheckedChanged" style="z-index: 1; left: 533px; top: 118px; position: absolute" ToolTip="Select to Update existing job" />
        <asp:Button ID="AddBtn" runat="server" BackColor="Yellow" OnClick="AddBtn_Click" style="z-index: 1; left: 279px; top: 521px; position: absolute" Text="Add" />
        <asp:Button ID="UpdateBtn" runat="server" BackColor="Yellow" OnClick="UpdateBtn_Click" style="z-index: 1; left: 277px; top: 522px; position: absolute" Text="Update" Visible="False" />
        
    
    </div>
    </form>
</body>
</html>
