<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InterviewTool.Admin.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><strong>Administration Section</strong></h2>
    <h2>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Admin/ManageUsers.aspx">Benutzerverwaltung</asp:HyperLink>
    </h2>
    <h2>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Admin/ManageFachgebiet.aspx">Fachgebiet Verwaltung</asp:HyperLink>
    </h2>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Erweiterte Einstellungen" CssClass="GreenButton" />
    </p>
    <p>
    </p>
    <asp:Panel ID="Panel1" runat="server" Visible="False">
        <p>
            <table style="width: 100%">
                <tr>
                    <td style="height: 24px">Email von</td>
                    <td style="height: 24px">
                        <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 23px">Email Adresse</td>
                    <td style="height: 23px">
                        <asp:TextBox ID="TextBox2" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 25px">Email Passwort</td>
                    <td style="height: 25px">
                        <asp:TextBox ID="TextBox3" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email SMTP</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email SMTP Port</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </p>
    </asp:Panel>

</asp:Content>
