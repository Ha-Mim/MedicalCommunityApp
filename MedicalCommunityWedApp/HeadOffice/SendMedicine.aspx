<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendMedicine.aspx.cs" Inherits="CommunityMedicine.UI.SendMedicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>District</td>
                <td>
                    <asp:DropDownList ID="districtDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="districtDropDownList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Thana</td>
                <td>
                    <asp:DropDownList ID="thanaDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="thanaDropDownList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Center</td>
                <td>
                    <asp:DropDownList ID="centerDropDownList" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
        <br />
        <br />
        <h1>Add Medicine</h1>
        <table style="width:100%;">
            <tr>
                <td>Select Medicine</td>
                <td>
                    <asp:DropDownList ID="medicineDropDownList" runat="server">
                    </asp:DropDownList>
                </td>
                <td>Quantity</td>
                <td>
                    <asp:TextBox ID="quantityTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="addMedicineButton" runat="server" Text="Add" OnClick="addMedicineButton_Click" />
                    <asp:Label ID="messageLabel" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:GridView ID="medicineGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Name"></asp:TemplateField>
                <asp:TemplateField HeaderText="Quantity"></asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="saveButton" runat="server" Text="Save" />
        <br/>

    </div>
    </form>
</body>
</html>
