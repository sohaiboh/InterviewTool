<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageFachgebiet.aspx.cs" Inherits="InterviewTool.Admin.ManageFachgebiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style> 
input[type=text] {
    width: 130px;
    box-sizing: border-box;
    border: 2px solid #ccc;
    border-radius: 4px;
    font-size: 16px;
    background-color: white;

    background-position: 10px 10px; 
    background-repeat: no-repeat;
    padding: 12px 20px 12px 40px;
    -webkit-transition: width 0.4s ease-in-out;
    transition: width 0.4s ease-in-out;
}

input[type=text]:focus {
    width: 100%;
}
</style>
        <h1>Fachgebiet Verwaltung</h1>
<p>
    <input type="text" name="txtfachgebiet" ID="txtfachgebiet" placeholder="Hinzu..."  >
        
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Hinzu" CssClass="GreenButton" />
        
        </p>
        <p>
        
            <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Löschen" ControlStyle-CssClass="GreenButton"  />
            </Columns>
        </asp:GridView>
    </asp:Content>
