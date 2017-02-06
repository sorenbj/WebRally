<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleEdit.aspx.cs" Inherits="RallyProject.SimpleEdit" %>

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
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="IdDriver" HeaderText="IdDriver" ReadOnly="True" SortExpression="IdDriver" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Nationality" HeaderText="Nationality" SortExpression="Nationality" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RallyDBConnectionString %>" DeleteCommand="DELETE FROM [Driver] WHERE [IdDriver] = @IdDriver" InsertCommand="INSERT INTO [Driver] ([IdDriver], [Name], [Nationality]) VALUES (@IdDriver, @Name, @Nationality)" SelectCommand="SELECT * FROM [Driver]" UpdateCommand="UPDATE [Driver] SET [Name] = @Name, [Nationality] = @Nationality WHERE [IdDriver] = @IdDriver">
            <DeleteParameters>
                <asp:Parameter Name="IdDriver" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="IdDriver" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Nationality" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Nationality" Type="String" />
                <asp:Parameter Name="IdDriver" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="IdTeam" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="IdTeam" HeaderText="IdTeam" ReadOnly="True" SortExpression="IdTeam" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Car" HeaderText="Car" SortExpression="Car" />
                <asp:BoundField DataField="Driver" HeaderText="Driver" SortExpression="Driver" />
                <asp:BoundField DataField="Codriver" HeaderText="Codriver" SortExpression="Codriver" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:RallyDBConnectionString %>" DeleteCommand="DELETE FROM [RallyTeam] WHERE [IdTeam] = @IdTeam" InsertCommand="INSERT INTO [RallyTeam] ([IdTeam], [Name], [Car], [Driver], [Codriver]) VALUES (@IdTeam, @Name, @Car, @Driver, @Codriver)" SelectCommand="SELECT * FROM [RallyTeam]" UpdateCommand="UPDATE [RallyTeam] SET [Name] = @Name, [Car] = @Car, [Driver] = @Driver, [Codriver] = @Codriver WHERE [IdTeam] = @IdTeam">
            <DeleteParameters>
                <asp:Parameter Name="IdTeam" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="IdTeam" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Car" Type="String" />
                <asp:Parameter Name="Driver" Type="Int32" />
                <asp:Parameter Name="Codriver" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Car" Type="String" />
                <asp:Parameter Name="Driver" Type="Int32" />
                <asp:Parameter Name="Codriver" Type="Int32" />
                <asp:Parameter Name="IdTeam" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
