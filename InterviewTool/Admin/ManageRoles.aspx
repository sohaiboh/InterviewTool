<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageRoles.aspx.cs" Inherits="InterviewTool.Admin.ManageRoles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Rolle Verwaltung</h2>
    <p>
        <asp:TextBox ID="txtRole" runat="server"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="hinzu" />
    </p>
    <p>
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Rolle Name" />
                    
                </Columns>
            </asp:GridView>
    </p>
</asp:Content>
