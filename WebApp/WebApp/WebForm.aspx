<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApp.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>html server control</title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Html server Control</legend>
            principle:<br />
            <input type="text" id="principle" runat="server" /><br /><br />
            Rate:<br />
            <input type="text" id="rate" runat="server" /><br /><br />

            Time:<br />
            <input type="text" id="time" runat="server" /><br /><br />
            <input type="submit" value="Calculate" runat="server" onserverclick="submit_ServerClick" />

        </fieldset>
    </form>
</body>
</html>
