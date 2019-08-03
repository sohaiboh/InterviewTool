<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="InterviewTool.Admin.ManageUsers" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Benutzer Verwaltung</h2>
    <p>&nbsp;</p>
    <p>
        <style>
            table {
    border-collapse: collapse;
    width: 100%;
                font-size: medium;
            }

th, td {
    text-align: center;
    padding: 8px;
                font-size: large;
            }

th {
    background-color: #4CAF50;
    color: white;
}
</style>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting">
            <Columns> 
                <asp:BoundField DataField="UserName"  HeaderText="Email Adresse" SortExpression="UserName" />
                <asp:HyperLinkField DataNavigateUrlFields="UserName" DataNavigateUrlFormatString="EditUser.aspx?username={0}" HeaderText="Verwalten" Text="Bearbeitung" />
                <asp:CommandField ButtonType="Button" HeaderText="Löschen" ShowDeleteButton="True" ShowHeader="True" DeleteText="Löschen" ControlStyle-CssClass="GreenButton"/>
            </Columns>
        </asp:GridView>
    </p>

    <p>
           <style>
.button {
    background-color: #4CAF50; /* Green */
    border: none;
    color: white;
    padding: 16px 32px;
    text-align: center;
    text-decoration: none;
    display: inline-block;
    font-size: 16px;
    margin: 4px 2px;
    -webkit-transition-duration: 0.4s; /* Safari */
    transition-duration: 0.4s;
    cursor: pointer;
}

.btnCreate{
    background-color: white; 
    color: black; 
    border: 2px solid #4CAF50;
}
.btnCreate:hover {
    background-color: #4CAF50;
    color: white;
}
               </style>
        &nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <h3>
         Nutzer erstellen</h3>
    <table class="nav-justified">
        <tr>
            <td>Nutzer Email Adresse</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
   

            <td>&nbsp;</td>
            <td>

                <asp:Button class="button btnCreate" ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Erstellen" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <p> 
  
        &nbsp;</p>
</asp:Content>
