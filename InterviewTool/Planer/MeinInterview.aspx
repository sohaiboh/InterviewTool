<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MeinInterview.aspx.cs" Inherits="InterviewTool.Planer.MeinInterview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Meine Interviews</h1>
    <p>
        <style>
            table {
    border-collapse: collapse;
    width: 100%;
                font-size: medium;
                font-weight: 700;
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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="795px">
            <Columns>
                <asp:BoundField DataField="Titel" HeaderText="Interviewname" SortExpression="Titel" />
                <asp:BoundField DataField="Termin_Beginn" HeaderText="Anfangsdatum" />
                <asp:BoundField DataField="Termin_Ende" HeaderText="Endedatum" />
                <asp:BoundField HeaderText="Teilnehmerzahl" DataField="InterviewsCount" />
                <asp:TemplateField HeaderText="Status">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Status") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Convert.ToBoolean(Eval("Status")) %>' Enabled="False"></asp:CheckBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFields="InterviewId,FachgebietID" DataNavigateUrlFormatString="TeilnehmerEinladen.aspx/?interviewid={0}&amp;FachgebietID={1}" HeaderText="Einladen" Text="TeilnehmerEinladen" />
                <asp:HyperLinkField DataNavigateUrlFields="InterviewID" DataNavigateUrlFormatString="Ergebnisse.aspx?interviewid={0}" HeaderText="Ergebnisse" Text="Ergebnisse" />
            </Columns>
        </asp:GridView>
    </p>
</asp:Content>
