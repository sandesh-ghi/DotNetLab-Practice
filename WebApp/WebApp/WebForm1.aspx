<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <fieldset>
           <legend>
               Web server control example
           </legend>
           <asp:Label ID="lblP" runat="server" Text="Principle"></asp:Label> <br /> 
           <asp:TextBox ID="TxtPrinciple" runat="server"></asp:TextBox> <br /><br />
           
           <asp:Label ID="lblR" runat="server" Text="Rate"></asp:Label><br />
           <asp:TextBox ID="TxtRate" runat="server"></asp:TextBox> <br /><br />

           <asp:Label ID="lblT" runat="server" Text="Time"></asp:Label><br />
           <asp:TextBox ID="TxtTime" runat="server"></asp:TextBox><br /><br />

           <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" ></asp:Button ><br />
           <asp:Label ID="Result" runat="server"></asp:Label>


       </fieldset>
    </form>
</body>
</html>
