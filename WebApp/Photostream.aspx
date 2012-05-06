<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Photostream.aspx.cs" Inherits="WebApp.Photostream" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
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
    </form>
</body>
</html>
