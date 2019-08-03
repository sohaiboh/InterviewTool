<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ergebnisse.aspx.cs" Inherits="InterviewTool.Planer.Ergebnisse" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Ergebnisse</h1>
    <p><style>
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
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Height="144px" Width="156px"  OnLoad="Chart1_Load">
            <series>
                <asp:Series ChartType="Pie" Name="Series1" XValueMember="ErgFrage1" YValueMembers="count">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource2" Height="144px" Width="156px">
            <series>
                <asp:Series ChartType="Pie" Name="Series1" XValueMember="ErgFrage2" YValueMembers="count">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:Chart ID="Chart3" runat="server" DataSourceID="SqlDataSource3" Height="144px" Width="156px">
            <series>
                <asp:Series ChartType="Pie" Name="Series1" XValueMember="ErgFrage3" YValueMembers="count">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:Chart ID="Chart4" runat="server" DataSourceID="SqlDataSource4" Height="144px" Width="156px">
            <series>
                <asp:Series ChartType="Pie" Name="Series1" XValueMember="ErgFrage4" YValueMembers="count">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:Chart ID="Chart5" runat="server" DataSourceID="SqlDataSource5" Height="144px" Width="156px">
            <series>
                <asp:Series ChartType="Pie" Name="Series1" XValueMember="ErgFrage5" YValueMembers="count">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
             <br />
        <asp:Chart ID="Chart6" runat="server" DataSourceID="SqlDataSource6" Height="144px" Width="156px">
            <series>
                <asp:Series ChartType="Pie" Name="Series1" XValueMember="ErgFrage6" YValueMembers="count">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
           
        <asp:Chart ID="Chart7" runat="server" DataSourceID="SqlDataSource7" Height="144px" Width="156px">
            <series>
                <asp:Series ChartType="Pie" Name="Series1" XValueMember="ErgFrage7" YValueMembers="count">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:Chart ID="Chart8" runat="server" DataSourceID="SqlDataSource8" Height="144px" Width="156px">
            <series>
                <asp:Series ChartType="Pie" Name="Series1" XValueMember="ErgFrage8" YValueMembers="count">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:Chart ID="Chart9" runat="server" DataSourceID="SqlDataSource9" Height="144px" Width="156px">
            <series>
                <asp:Series ChartType="Pie" Name="Series1" XValueMember="ErgFrage9" YValueMembers="count">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:Chart ID="Chart10" runat="server" DataSourceID="SqlDataSource10" Height="144px" Width="156px">
            <series>
                <asp:Series ChartType="Pie" Name="Series1" XValueMember="ErgFrage10" YValueMembers="count">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InterviewToolContext %>" SelectCommand="SELECT Ergebnis.ErgFrage1, COUNT(*) AS count FROM Ergebnis INNER JOIN Teilnehmer ON Ergebnis.ErgebnisId = Teilnehmer.ErgebnisID WHERE (Teilnehmer.InterviewID = @InterviewID) GROUP BY Ergebnis.ErgFrage1">
            <SelectParameters>
                <asp:QueryStringParameter Name="InterviewID" QueryStringField="interviewid" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:InterviewToolContext %>" SelectCommand="SELECT Ergebnis.ErgFrage2, COUNT(*) AS count FROM Ergebnis INNER JOIN Teilnehmer ON Ergebnis.ErgebnisId = Teilnehmer.ErgebnisID WHERE (Teilnehmer.InterviewID = @InterviewID) GROUP BY Ergebnis.ErgFrage2">
            <SelectParameters>
                <asp:QueryStringParameter Name="InterviewID" QueryStringField="interviewid" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:InterviewToolContext %>" SelectCommand="SELECT Ergebnis.ErgFrage3, COUNT(*) AS count FROM Ergebnis INNER JOIN Teilnehmer ON Ergebnis.ErgebnisId = Teilnehmer.ErgebnisID WHERE (Teilnehmer.InterviewID = @InterviewID) GROUP BY Ergebnis.ErgFrage3">
            <SelectParameters>
                <asp:QueryStringParameter Name="InterviewID" QueryStringField="interviewid" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:InterviewToolContext %>" SelectCommand="SELECT Ergebnis.ErgFrage4, COUNT(*) AS count FROM Ergebnis INNER JOIN Teilnehmer ON Ergebnis.ErgebnisId = Teilnehmer.ErgebnisID WHERE (Teilnehmer.InterviewID = @InterviewID) GROUP BY Ergebnis.ErgFrage4">
            <SelectParameters>
                <asp:QueryStringParameter Name="InterviewID" QueryStringField="interviewid" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:InterviewToolContext %>" SelectCommand="SELECT Ergebnis.ErgFrage5, COUNT(*) AS count FROM Ergebnis INNER JOIN Teilnehmer ON Ergebnis.ErgebnisId = Teilnehmer.ErgebnisID WHERE (Teilnehmer.InterviewID = @InterviewID) GROUP BY Ergebnis.ErgFrage5">
            <SelectParameters>
                <asp:QueryStringParameter Name="InterviewID" QueryStringField="interviewid" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:InterviewToolContext %>" SelectCommand="SELECT Ergebnis.ErgFrage6, COUNT(*) AS count FROM Ergebnis INNER JOIN Teilnehmer ON Ergebnis.ErgebnisId = Teilnehmer.ErgebnisID WHERE (Teilnehmer.InterviewID = @InterviewID) GROUP BY Ergebnis.ErgFrage6">
            <SelectParameters>
                <asp:QueryStringParameter Name="InterviewID" QueryStringField="interviewid" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:InterviewToolContext %>" SelectCommand="SELECT Ergebnis.ErgFrage7, COUNT(*) AS count FROM Ergebnis INNER JOIN Teilnehmer ON Ergebnis.ErgebnisId = Teilnehmer.ErgebnisID WHERE (Teilnehmer.InterviewID = @InterviewID) GROUP BY Ergebnis.ErgFrage7">
            <SelectParameters>
                <asp:QueryStringParameter Name="InterviewID" QueryStringField="interviewid" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:InterviewToolContext %>" SelectCommand="SELECT Ergebnis.ErgFrage8, COUNT(*) AS count FROM Ergebnis INNER JOIN Teilnehmer ON Ergebnis.ErgebnisId = Teilnehmer.ErgebnisID WHERE (Teilnehmer.InterviewID = @InterviewID) GROUP BY Ergebnis.ErgFrage8">
            <SelectParameters>
                <asp:QueryStringParameter Name="InterviewID" QueryStringField="interviewid" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource9" runat="server" ConnectionString="<%$ ConnectionStrings:InterviewToolContext %>" SelectCommand="SELECT Ergebnis.ErgFrage9, COUNT(*) AS count FROM Ergebnis INNER JOIN Teilnehmer ON Ergebnis.ErgebnisId = Teilnehmer.ErgebnisID WHERE (Teilnehmer.InterviewID = @InterviewID) GROUP BY Ergebnis.ErgFrage9">
            <SelectParameters>
                <asp:QueryStringParameter Name="InterviewID" QueryStringField="interviewid" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource10" runat="server" ConnectionString="<%$ ConnectionStrings:InterviewToolContext %>" SelectCommand="SELECT Ergebnis.ErgFrage10, COUNT(*) AS count FROM Ergebnis INNER JOIN Teilnehmer ON Ergebnis.ErgebnisId = Teilnehmer.ErgebnisID WHERE (Teilnehmer.InterviewID = @InterviewID) GROUP BY Ergebnis.ErgFrage10">
            <SelectParameters>
                <asp:QueryStringParameter Name="InterviewID" QueryStringField="interviewid" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
</asp:Content>
