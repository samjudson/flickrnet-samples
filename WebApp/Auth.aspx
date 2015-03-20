<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auth.aspx.cs" Inherits="WebApp.Auth" MasterPageFile="MasterPage.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <form runat="server">
        <div class="container">
            <div class="row">
                <h1>Authentication</h1>
            </div>
            <div class="row">
                <p>
                    To begin the authentication process click the button below. 
        This will redirect you to the Flickr web site and then you will be redirected back to this page for authentication to be completed.
                </p>
            </div>
            <div class="row">
                <div>
                    <asp:Button CssClass="btn btn-primary" runat="server" ID="AuthenticateButton" OnClick="AuthenticateButton_Click" Text="Authenticate"></asp:Button>
                </div>
            </div>
            <div class="row">&nbsp;</div>
            <div class="row">
                <asp:Panel runat="server" CssClass="alert alert-success" ID="ResultPanel" Visible="False">
                    <p>
                        <asp:Label runat="server" ID="ResultsLabel" />
                    </p>
                </asp:Panel>
            </div>
            <div class="row">&nbsp;</div>
        </div>
    </form>
    <div class="container">
        <div class="row">
            <div class="panel panel-default">
                <div class="panel-body">
                    <p>Clicking the link below will redirect you to the source code for this web age (the C# file behind).</p>
                    <p>
                        <a href="https://github.com/samjudson/flickrnet-samples/blob/master/WebApp/Auth.aspx.cs">View Source Code</a>
                    </p>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
