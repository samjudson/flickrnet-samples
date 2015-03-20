<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" MasterPageFile="MasterPage.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

    <div class="container">

        <div class="row">
            <h1>Flickr.Net Web Sample</h1>
            <p>This sample site tries to illustrate how you might want to use the Flickr.Net API Library on a web site.</p>
            <p>It uses WebForms, simply because I've tried to keep everything simple. I'm a bit rusty on WebForms (I tend to use MVC these days).</p>
            <p>I've had a little fun upgrading it to use Bootstrap, just so it doesn't look absolutely horrible.</p>
            <p>Enjoy.</p>
        </div>
        <div class="row">
            <div class="panel panel-info">
                <div class="panel-body">
                    <p>
                        The sample includes a class called <a href="https://flickrnetsamples.codeplex.com/SourceControl/latest#WebApp/FlickrManager.cs">FlickrManager</a> which is not part of the Flickr.Net library. 
                    </p>
                    <p>
                        It is designed to show you how you might store and retrieve the authentication token.
                    </p>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
