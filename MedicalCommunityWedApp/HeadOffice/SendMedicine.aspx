<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendMedicine.aspx.cs" Inherits="CommunityMedicine.UI.SendMedicine" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="myApp">
<head runat="server">
    <title></title>
</head>
<body ng-controller="myController">
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
                    <asp:DropDownList  ng-model="name" ID="medicineDropDownList" runat="server">
                    </asp:DropDownList>
                </td>
                <td>Quantity</td>
                <td>
                    <asp:TextBox ng-model="quantity" ID="quantityTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <button type="button" ng-click="AddMedicine(name,quantity)" class="btn btn-success">Add</button>
                </td>
            </tr>
        </table>
        <br />
        <br />
       <div class="form-group">
                    <table id="tbl" runat="server" class="table table-hover">
                        <thead>
                            <tr>
                                <td>Name</td>
                                <td>Quantity</td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="aMedicine in medicines">
                                <td>{{aMedicine.Name}}</td>
                                <td>{{aMedicine.Quantity}}</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
        <br />
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                           <asp:Label ID="messageLabel" runat="server"></asp:Label>
        <br/>
         <input type="hidden" id="medicineName" runat="server"/>
        <input type="hidden" id="medicineQuantity" runat="server"/>
    </div>
    </form>
       <script src="../Scripts/angular.js"></script>
    <script>
        var myApplication = angular.module("myApp", []);
        myApplication.controller("myController", function ($scope) {
            $scope.medicines = [];
            $scope.AddMedicine = function (name, quantity) {
                if (name != String.empty && quantity != String.empty) {
                    $scope.medicines.push({ Name: name, Quantity: quantity });
                    var medicineName = name.split(",");
                    document.getElementById("medicineName").value += medicineName[0] + ",";
                    document.getElementById("medicineQuantity").value += quantity + ",";
                }
            };
        });
    </script>
</body>
</html>
