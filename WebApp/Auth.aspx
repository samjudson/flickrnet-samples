<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auth.aspx.cs" Inherits="WebApp.Auth" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button runat="server" ID="AuthenticateButton" OnClick="AuthenticateButton_Click" Text="Authenticate"></asp:Button>
    </div>
    <div>
    <asp:Label runat="server" ID="ResultsLabel" />
    </div>
    </form>
    
    <div><a href="Default.aspx">Back to Home</a></div>
</body>
</html>
