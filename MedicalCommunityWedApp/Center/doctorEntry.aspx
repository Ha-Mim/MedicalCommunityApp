<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="doctorEntry.aspx.cs" Inherits="MedicalCommunityWedApp.Center.doctorEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
        <table  runat="server">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>Degree</td>
                <td>
                    <asp:TextBox ID="degreeTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>Specialization</td>
                <td>
                    <asp:TextBox ID="specializationTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td></td>
                <td>
                    <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                </td>
            </tr>
        </table>
        <asp:Label ID="msgLabel" runat="server" ></asp:Label>
    </div>
    </form>
</body>
</html>
