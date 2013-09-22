<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Photostream.aspx.cs" Inherits="WebApp.Photostream" MasterPageFile="MasterPage.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
    User ID: 
        <asp:TextBox runat="server" ID="UserIdTextBox" Text="41888973@N00" 
            AutoPostBack="True"></asp:TextBox>
    </div>
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="PhotostreamDataSource">
            <Columns>
                <asp:BoundField DataField="PhotoId" HeaderText="PhotoId" 
                    SortExpression="PhotoId" />
                <asp:HyperLinkField DataNavigateUrlFields="WebUrl" DataTextField="Title" />
                <asp:ImageField DataAlternateTextField="Title" 
                    DataImageUrlField="LargeSquareThumbnailUrl">
                </asp:ImageField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="PhotostreamDataSource" runat="server" 
            EnableCaching="True" SelectMethod="GetPhotostream" 
            TypeName="WebApp.Photostream">
            <SelectParameters>
                <asp:ControlParameter ControlID="UserIdTextBox" Name="userId" 
                    PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
    <div>
        <a href="https://flickrnetsamples.codeplex.com/SourceControl/latest#WebApp/Photostream.aspx.cs">View Source Code</a>
    </div>
</asp:Content>

