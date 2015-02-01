<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewCenterCreation.aspx.cs" Inherits="MedicalCommunityAutomation.NewCenterCreation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="Label1" runat="server" Text="Create a New Centre"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="District"></asp:Label>
        <asp:DropDownList ID="districtDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="districtDropDownList_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Thana"></asp:Label>
        <asp:DropDownList ID="thanaDropDownList" runat="server" AutoPostBack="True" >
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
        <br />
        <br />
        <asp:Label ID="msgLabel" runat="server" Text="&quot;&quot;"></asp:Label>
    
    </div>
    </form>
</body>
</html>
