<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InterviewTool.Planer.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Planer</h2>
<br />
<table class="nav-justified">
    <tr>
        <td class="text-center" style="height: 21px">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Planer/MeinInterview.aspx">Meine Interviews</asp:HyperLink>
        </td>
        <td class="text-center" style="height: 21px">
            &nbsp;</td>
        <td class="text-center" style="height: 21px">
        </td>
        <td class="text-center" style="height: 21px">
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Planer/NeuInterview.aspx">Neu Interview</asp:HyperLink>
        </td>
    </tr>
</table>
</asp:Content>
