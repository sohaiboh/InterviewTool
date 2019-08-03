<%@ Page Title="Kontakt" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="InterviewTool.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Kontaktseite</h3>
    <address>
        HTW Berlin<br />
        Wilhelminenhof<br />
        <abbr title="Kontakt">P:</abbr>
        030123456
    </address>

    <address>
       <%-- <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Firma</strong> <a href="mailto:Marketing@example.com">Firma@example.com</a>--%>
    </address>
</asp:Content>
