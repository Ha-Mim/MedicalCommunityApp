<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginCodePassword.aspx.cs" Inherits="MedicalCommunityWedApp.HeadOffice.LoginCodePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
        <asp:TextBox ID="codeTextBox" runat="server" OnTextChanged="codeTextBox_TextChanged"></asp:TextBox>
        <br />
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
