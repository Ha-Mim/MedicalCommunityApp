<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiseaseSetUp.aspx.cs" Inherits="MedicalCommunityAutomation.DiseaseSetUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Disease_SetUp"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="descriptionTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Treatment Procedure"></asp:Label>
        <asp:TextBox ID="treatmentProcedureTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Prefered Drugs"></asp:Label>
        <asp:TextBox ID="preferedDrugsTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" />
        <br />
        <br />
        <asp:Label ID="msgLabel" runat="server" Text="&quot;&quot;"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
