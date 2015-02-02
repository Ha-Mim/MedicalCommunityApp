<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="diseaseWiseReport.aspx.cs" Inherits="MedicalCommunityWedApp.Center.diseaseWiseReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Disease"></asp:Label>
        <asp:DropDownList ID="diseaseDropDownList" runat="server"></asp:DropDownList>
        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Date Between"></asp:Label>
        <asp:DropDownList ID="firstDateDropDownList" runat="server"></asp:DropDownList>
        <asp:Label ID="Label3" runat="server" Text="And"></asp:Label>
        <asp:DropDownList ID="secondDropDownList" runat="server"></asp:DropDownList>
        <br/>
        <asp:GridView ID="reportGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="District Name">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Name") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Total Patients">
                     <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Patient") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="% Over Population">
                     <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Population") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </div>
    </form>
</body>
</html>
