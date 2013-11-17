<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="BobSmithDemoWebApp.AddUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add User and Roles</title>
</head>
<body>
    <form id="form1" runat="server">

    <p>Make sure you have initialised your ASP.Net database using this command:
        <pre>
            C:\Windows\Microsoft.NET\Framework\v2.0.50727>aspnet_regsql.exe -S {YOUR_SERVER} -E -A mrp -d {YOUR_DATABASE}
        </pre>
    </p>

    <div>
        <asp:Button ID="Button1" runat="server" Text="Create User" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Add to Role" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
