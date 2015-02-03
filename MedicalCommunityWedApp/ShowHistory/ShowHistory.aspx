<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowHistory.aspx.cs" Inherits="MedicalCommunityWedApp.ShowHistory.ShowHistory" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        Voter id
        <asp:TextBox ID="voterIdTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="showDBuetailsButton" runat="server" Text="Show" OnClick="showDBuetailsButton_Click" />
        &nbsp; Address<asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
        <br />
        Name<asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" />
        <br />
        <asp:GridView ID="showHistoryGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Center" HeaderText="Center" />
                <asp:BoundField DataField="Destrict" HeaderText="Destrict" />
                <asp:BoundField DataField="Thana" HeaderText="Thana" />
                <asp:BoundField DataField="Diseases" HeaderText="Diseases" />
            </Columns>
        </asp:GridView>
    
        <br />
        Export or print In PDF&nbsp; <asp:Button ID="printButton" runat="server" Text="Print" OnClick="printButton_Click" />
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
