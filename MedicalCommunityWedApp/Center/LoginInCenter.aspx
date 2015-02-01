<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginInCenter.aspx.cs" Inherits="MedicalCommunityAutomation.LoginInCenter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Center Login</h1>
        <p style="text-align: center">
            Center Code
            <asp:TextBox ID="centerCodeTextBox" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: center">
            Password
            <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: center">
            <asp:Button ID="centerLoginButton" runat="server" OnClick="centerLoginButton_Click" Text="Login" />
        </p>
        <p style="text-align: center">
            <asp:Label ID="msgLabel" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
