<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="treatmentGiven.aspx.cs" Inherits="MedicalCommunityWedApp.Center.treatmentGiven" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="myApp">
<head runat="server">
    <title></title>
</head>
<body ng-controller="myController">
    <form id="form1" runat="server">
    <div>
         <asp:Label ID="Label9" runat="server" Text="Voter Id"></asp:Label>
        <asp:TextBox ID="voterIdTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="showDetailsButton" runat="server" Text="Show Details" OnClick="showDetailsButton_Click" />
        <br/>
        <asp:Label ID="Label10" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label11" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="addressTextBox" runat="server" Width="266px"></asp:TextBox>
        <br/>
        <asp:Label ID="Label12" runat="server" Text="Date Of Birth"></asp:Label>
        <asp:TextBox ID="dateOfBirthTextBox" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label13" runat="server" Text="Service Given"></asp:Label>
        <asp:TextBox ID="serviceGivenTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="Label14" runat="server" Text="Times"></asp:Label>
        <br/>
        <asp:HyperLink ID="HyperLink1" runat="server">Show All History</asp:HyperLink>
        <br/>
        <asp:Label ID="Label1" runat="server" Text="Observation"></asp:Label>
        <asp:TextBox ID="observationTextBox" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="Date"></asp:Label>
        <asp:Calendar ID="dateCalendar" runat="server"></asp:Calendar>
        <asp:Label ID="Label4" runat="server" Text="Doctor"></asp:Label>
        <asp:DropDownList ID="doctorDropDownList" runat="server"></asp:DropDownList>
        <br/>
          <asp:Label ID="Label5" runat="server" Text="Disease"></asp:Label>
        <asp:DropDownList ng-model="disease" ID="diseaseDropDownList" runat="server"></asp:DropDownList>
        <br/>
          <asp:Label ID="Label6" runat="server" Text="Medicine"></asp:Label>
        <asp:DropDownList ng-model="medicine" ID="medicineDropDownList" runat="server"></asp:DropDownList>
        <br/>
          <asp:Label ID="Label7" runat="server" Text="Dose"></asp:Label>
        <asp:DropDownList ng-model="dose" ID="doseDropDownList" runat="server"></asp:DropDownList>
        <br/>
        <asp:RadioButtonList ng-model="timeOfMeal" ID="timeOfMealRadioButtonList" runat="server">
            <asp:ListItem>Before Meal</asp:ListItem>
            <asp:ListItem>After Meal</asp:ListItem>
        </asp:RadioButtonList>
       
         <br/>  
        <asp:Label ID="Label2" runat="server" Text="Quantity Given"></asp:Label>
        <asp:TextBox ng-model="quantity" ID="quantitygivenTextBox" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label8" runat="server" Text="Note"></asp:Label>
        <asp:TextBox ng-model="note" ID="noteTextBox" runat="server"></asp:TextBox>
        <br/>
         <button type="button" ng-click="AddMedicine(disease, medicine,dose,timeOfMeal, quantity,note)" class="btn btn-success">Add</button>
        <asp:Label ID="msgLabel" runat="server" ></asp:Label>
          <div class="form-group">
                    <table id="tbl" runat="server" class="table table-hover">
                        <thead>
                            <tr>
                                <td>Disease</td>
                                <td>Medicine</td>
                                <td>Dose</td>
                                <td>Before/After Meal</td>
                                <td>Quantity Given</td>
                                <td>Note</td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr ng-repeat="aTreatment in treatments">
                                <td>{{aTreatment.Disease}}</td>
                                <td>{{aTreatment.Medicine}}</td>
                                <td>{{aTreatment.Dose}}</td>
                                <td>{{aTreatment.TimeOfMeal}}</td>
                                <td>{{aMedicine.Quantity}}</td>
                                <td>{{aTreatment.Note}}</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <p>
                    <asp:Button ID="saveButton" runat="server" Text="Save" CssClass="btn btn-primary"  />
                </p>
            </div>
      <input type="hidden" id="disease" runat="server"/>
        <input type="hidden" id="medicine" runat="server"/>
          <input type="hidden" id="dose" runat="server"/>
        <input type="hidden" id="timeOfMeal" runat="server"/>
          <input type="hidden" id="quantity" runat="server"/>
        <input type="hidden" id="note" runat="server"/>
    </form>
     <script src="../Scripts/angular.js"></script>
    <script>
        var myApplication = angular.module("myApp", []);
        myApplication.controller("myController", function ($scope) {
            $scope.medicines = [];
            $scope.AddMedicine = function (disease, medicine,dose,timeOfMeal, quantity,note) {
                if (disease != String.empty && quantity != String.empty && medicine!=String.empty && dose!=String.empty && timeOfMeal!=String.empty && note!=String.empty) {
                    $scope.treatments.push({ Disease: disease, Medicine:medicine,Dose:dose, TimeOfMeal:timeOfMeal, Quantity: quantity,Note:note });
                 
                    document.getElementById("disease").value += disease + ",";
                    document.getElementById("medicine").value += medicine + ",";
                    document.getElementById("dose").value += dose + ",";
                    document.getElementById("timeOfMeal").value += timeOfMeal + ",";
                    document.getElementById("quantity").value += quantity + ",";
                    document.getElementById("note").value += note + ",";
                }
            };
        });
    </script>
</body>
</html>
