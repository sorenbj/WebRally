<%@ Page Title="" Language="C#" MasterPageFile="~/Rally.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RallyProject.Index" Theme="Theme1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Image id="MainImage" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Textbox ID="MainText" runat="server" ReadOnly="true" TextMode="MultiLine" SkinID="maintext"></asp:Textbox>
</asp:Content>
