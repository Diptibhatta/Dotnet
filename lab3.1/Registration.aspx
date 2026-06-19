<%@ Page Language="C#" AutoEventWireup="true" 
CodeBehind="Registration.aspx.cs" 
Inherits="lab3.Registration" %>

<html>
<body>

<form id="form1" runat="server">

<h2>Registration Form</h2>

Name:
<asp:TextBox ID="txtName" runat="server"></asp:TextBox>

<asp:RequiredFieldValidator 
ID="valName" runat="server"
ControlToValidate="txtName"
ErrorMessage="Enter Name"
ForeColor="Red">
</asp:RequiredFieldValidator>

<br/><br/>


Email:
<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

<asp:RequiredFieldValidator
ID="valEmail"
runat="server"
ControlToValidate="txtEmail"
ErrorMessage="Enter Email"
ForeColor="Red">
</asp:RequiredFieldValidator>

<br/><br/>


Password:
<asp:TextBox ID="txtPassword" 
runat="server" TextMode="Password">
</asp:TextBox>

<asp:RequiredFieldValidator
ID="valPassword"
runat="server"
ControlToValidate="txtPassword"
ErrorMessage="Enter Password"
ForeColor="Red">
</asp:RequiredFieldValidator>


<br/><br/>

Age:
<asp:TextBox ID="txtAge" runat="server"></asp:TextBox>

<asp:RangeValidator
ID="valAge"
runat="server"
ControlToValidate="txtAge"
MinimumValue="18"
MaximumValue="60"
Type="Integer"
ErrorMessage="Age must be between 18-60"
ForeColor="Red">
</asp:RangeValidator>


<br/><br/>

<asp:Button ID="btnRegister"
runat="server"
Text="Register"
OnClick="btnRegister_Click"/>


<br/><br/>

<asp:Label ID="lblMessage"
runat="server"
ForeColor="Green">
</asp:Label>


</form>

</body>
</html>