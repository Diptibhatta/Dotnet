<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleInterest.aspx.cs" Inherits="lab3.SimpleInterest" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Simple Interest Calculator</title>
</head>

<body>

<form id="form1" runat="server">

<h2>Simple Interest Calculator</h2>

Principal:
<asp:TextBox ID="txtPrincipal" runat="server"></asp:TextBox>

<br /><br />

Rate:
<asp:TextBox ID="txtRate" runat="server"></asp:TextBox>

<br /><br />

Time:
<asp:TextBox ID="txtTime" runat="server"></asp:TextBox>

<br /><br />

<asp:Button ID="btnCalculate"
runat="server"
Text="Calculate"
OnClick="btnCalculate_Click"/>

<br /><br />

<asp:Label ID="lblResult" runat="server"></asp:Label>

</form>

</body>
</html>