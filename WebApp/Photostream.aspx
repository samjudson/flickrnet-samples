<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Photostream.aspx.cs" Inherits="WebApp.Photostream" MasterPageFile="MasterPage.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="container">

        <div class="row">
            <h1>Authentication</h1>
        </div>
        <div class="row">
            <p>This page illustrates how you might call the Flickr API and return a collection of photos and display them on the screen.</p>
            <p>Don't forget to always link back to the Flickr Page for each photo you display.</p>
        </div>
        <div class="row">
            <div class="panel panel-default">
                <div class="panel-body">
                    <p>Enter your USER ID in the box below and exit the box will refresh the page and update the selection of photos.</p>
                    <p>Alternatively authenticate, and your USER ID will automatically be picked up.</p>
                </div>
            </div>
        </div>
        <form runat="server" class="form-horizontal">
            <div class="row">
                <div class="form-group">
                    <label for="UserIdTextBox" class="col-xs-2">User ID: </label>
                    <div class="col-xs-4">
                        <asp:TextBox runat="server" ID="UserIdTextBox" ClientIDMode="Static" CssClass="form-control col-xs-4" Text="41888973@N00"
                            AutoPostBack="True"></asp:TextBox>
                    </div>
                    <div class="col-xs-6">
                        <span>If you are authenticated then this box will default to your user ID.</span>
                    </div>
                </div>
            </div>
            <div class="row">
                <asp:Repeater ID="GridView1" runat="server" DataSourceID="PhotostreamDataSource">
                    <ItemTemplate>
                        <div class="pull-left" style="padding: 1rem">
                            <div>
                                <img src="<%#DataBinder.Eval(Container.DataItem, "LargeSquareThumbnailUrl")%>" alt="<%#DataBinder.Eval(Container.DataItem, "Title")%>" />
                            </div>
                            <div><%#DataBinder.Eval(Container.DataItem, "Title")%></div>
                            <div><a href="<%#DataBinder.Eval(Container.DataItem, "WebUrl")%>"><%#DataBinder.Eval(Container.DataItem, "PhotoId")%></a></div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
                <asp:ObjectDataSource ID="PhotostreamDataSource" runat="server"
                    EnableCaching="True" SelectMethod="GetPhotostream"
                    TypeName="WebApp.Photostream">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="UserIdTextBox" Name="userId"
                            PropertyName="Text" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </form>
        <div class="row">&nbsp;</div>
        <div class="row">
            <div class="panel panel-default">
                <div class="panel-body">
                    <p>Clicking the link below will redirect you to the source code for this web age (the C# file behind).</p>
                    <p>
                        <a href="https://github.com/samjudson/flickrnet-samples/blob/master/WebApp/Photostream.aspx.cs">View Source Code</a>
                    </p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

