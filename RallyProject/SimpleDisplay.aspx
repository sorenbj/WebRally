<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleDisplay.aspx.cs" Inherits="RallyProject.SimpleDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="IdDriver" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="IdDriver" HeaderText="IdDriver" ReadOnly="True" SortExpression="IdDriver" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Nationality" HeaderText="Nationality" SortExpression="Nationality" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RallyDBConnectionString %>" SelectCommand="SELECT * FROM [Driver]"></asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="IdTeam" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="IdTeam" HeaderText="IdTeam" ReadOnly="True" SortExpression="IdTeam" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Car" HeaderText="Car" SortExpression="Car" />
                <asp:BoundField DataField="Driver" HeaderText="Driver" SortExpression="Driver" />
                <asp:BoundField DataField="Codriver" HeaderText="Codriver" SortExpression="Codriver" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:RallyDBConnectionString %>" SelectCommand="SELECT * FROM [RallyTeam]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
