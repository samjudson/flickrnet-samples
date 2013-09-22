<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auth.aspx.cs" Inherits="WebApp.Auth" MasterPageFile="MasterPage.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
    <asp:Button runat="server" ID="AuthenticateButton" OnClick="AuthenticateButton_Click" Text="Authenticate"></asp:Button>
    </div>
    <div>
    <asp:Label runat="server" ID="ResultsLabel" />
    </div>
</asp:Content>
