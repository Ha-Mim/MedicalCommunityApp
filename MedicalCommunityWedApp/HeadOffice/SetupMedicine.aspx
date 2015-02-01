<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SetupMedicine.aspx.cs" Inherits="MedicalCommunityAutomation.SetupMedicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Basic Medicine Setup</h1>
        <p style="text-align: center">
            Generic Name
            <asp:TextBox ID="genericNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: center">
            Mg/ML<asp:TextBox ID="quantityTextBox" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <p style="text-align: center">
            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
        </p>
        <p style="text-align: center">
            <asp:Label ID="msgLabel" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
