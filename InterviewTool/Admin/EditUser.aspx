<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="InterviewTool.Admin.EditUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Edit User</h2>
     <style>
         .button {
         border-style: none;
             border-color: inherit;
             border-width: medium;
             background-color: #4CAF50; /* Green */
             color: white;
             padding: 16px 32px;
             text-align: center;
             text-decoration: none;
             display: inline-block;
             font-size: 16px;
    margin: 0px 2px 4px 2px;
             -webkit-transition-duration: 0.4s; /* Safari */
             transition-duration: 0.4s;
             cursor: pointer;
}

.btnAdd{
    background-color: white; 
    color: black; 
    border: 2px solid #4CAF50;
}
.btnAdd:hover {
    background-color: #4CAF50;
    color: white;
}

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
            .auto-style1 {
                font-size: large;
            }
               </style>
    <p><strong>UserName:</strong>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p><strong>Rolle hinzufügen</strong></p>
    <p>
        <asp:DropDownList ID="ddlRoles" runat="server" Height="52px" Width="180px">
        </asp:DropDownList>
       
        <asp:Button ID="btnAdd" CssClass ="button btnAdd"  runat="server" OnClick="btnAdd_Click" Text="Hinzu" Height="
            52px" Width="135px" />

   
       
    
    
        &nbsp;&nbsp;&nbsp;&nbsp;

    <p>
        &nbsp;<p>
        <asp:GridView ID="GridView1" runat="server" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
                <asp:CommandField ButtonType="Button" DeleteText="Löschen" HeaderText="Löschen" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    &nbsp;&nbsp;&nbsp;
    </p>


</asp:Content>
