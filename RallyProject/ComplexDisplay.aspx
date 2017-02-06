<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComplexDisplay.aspx.cs" Inherits="RallyProject.ComplexDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="teamname" HeaderText="teamname" SortExpression="teamname" />
                <asp:BoundField DataField="driver" HeaderText="driver" SortExpression="driver" />
                <asp:BoundField DataField="codriver" HeaderText="codriver" SortExpression="codriver" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RallyDBConnectionString %>" SelectCommand="select rallyteam.name as teamname, d1.name as driver, d2.name as codriver
from RallyTeam, Driver as d1, Driver as d2
where RallyTeam.Driver = d1.IdDriver and RallyTeam.Codriver = d2.IdDriver"></asp:SqlDataSource>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Very small example with query builder"></asp:Label>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Car" HeaderText="Car" SortExpression="Car" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:RallyDBConnectionString %>" SelectCommand="SELECT Name, Car FROM RallyTeam"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
