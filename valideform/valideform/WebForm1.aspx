<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="valideform.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <fildset>
         
         <legend>
             Validation Form Example
         </legend>
   <asp:Label ID="lblname" runat="server" Text="Name: "></asp:Label><br />
   <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
   <asp:RequiredFieldValidator ID="rFname" runat="server" ErrorMessage="name field is require" ForeColor="Red" ControlToValidate="txtName"></asp:RequiredFieldValidator> 
         <br /> <br />
   <asp:RegularExpressionValidator ID="regname" runat="server" ErrorMessage="Enter valid name" ForeColor="Red" ControlToValidate="txtName" ValidationExpression="^[a-zA-Z]+$"></asp:RegularExpressionValidator> 
         <br /><br />

    <asp:Label ID="lblpass" runat="server" Text="Password"></asp:Label><br /> <br />
   <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
   <asp:RequiredFieldValidator ID="rfpass" runat="server" ErrorMessage="Password is required" ForeColor="Red" ControlToValidate="txtpass"></asp:RequiredFieldValidator>
   <asp:CustomValidator ID="cvpass" runat="server" ErrorMessage="Password must contain at least 4 character" ForeColor="red" ControlToValidate="txtpass" ValidateEmptyText="true"  OnServerValidate="rfpass_ServerValidate"></asp:CustomValidator>
         <br /> <br />

         <asp:Label ID="lblrepass" runat="server" Text="Repassword"></asp:Label><br /> <br />
         <asp:TextBox ID="txtrepass" runat="server"   TextMode="Password"></asp:TextBox>
         <asp:RequiredFieldValidator ID="rfrepass" runat="server" ErrorMessage="Retype Password" ForeColor="Red" ControlToValidate="txtrepass"></asp:RequiredFieldValidator>
         <asp:CompareValidator ID="compress" runat="server" ErrorMessage="password is not match" ForeColor="Red" ControlToValidate="txtrepass" ControlToCompare="txtpass"></asp:CompareValidator>
         <br /> <br />
         <asp:label ID="lblage" runat="server" Text="age"></asp:label><br /> <br />
         <asp:TextBox ID="txtAge" runat="server" TextMode="Number"></asp:TextBox>
         <asp:RegularExpressionValidator ID="rfage" runat="server" ErrorMessage="Age field is required" ForeColor="Red" ControlToValidate="txtAge"></asp:RegularExpressionValidator>
         <asp:RangeValidator ID="rangeAge" runat="server" ErrorMessage="Enter valid age" ForeColor="Red" ControlToValidate="txtAge"></asp:RangeValidator>
         <br /> <br />
         <asp:Label ID="lblmobile" runat="server" Text="Mobile"></asp:Label><br /> <br />
         <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="rfmobile" runat="server" ErrorMessage="Mobile field is required" ForeColor="Red" ControlToValidate="txtMobile"></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="regMobile" runat="server" ErrorMessage="Enter the mobile number" ForeColor="Red" ControlToValidate="txtMobile" ValidationExpression="^98[0-9]{8}$"></asp:RegularExpressionValidator>
         <br /> <br />

         <asp:Button ID="btnvalidator" runat="server" Text="validate" />
         <asp:ValidationSummary ID="errorSummary" runat="server" ForeColor="Red" />

     </fildset>
    </form>
</body>
</html>
