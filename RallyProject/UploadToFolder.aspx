<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadToFolder.aspx.cs" Inherits="RallyProject.UploadToFolder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelUpload" runat="server" Text="File to upload to files folder"></asp:Label>
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" Width="350px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="New file name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxFileName" runat="server" Width="250px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonUpload" runat="server" OnClick="ButtonUpload_Click" Text="Upload" />
        <br />
        <br />
        <asp:Label ID="LabelMessage" runat="server" Text="Messages"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxMessage" runat="server" Width="350px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Files in Myfiles folder"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownListFiles" runat="server">
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
