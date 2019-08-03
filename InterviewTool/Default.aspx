<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InterviewTool._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <h1>
        
        Interview Tool</h1>
    <p><span class="_5yl5"><span style="font-size: large"><strong>Hallo und herzlich willkommen</strong></span></span></p>
<p>
    </p>
    <asp:Panel ID="Panel1" runat="server" Visible="False">
        <br /> 
        <table style="width: 100%">
            <tr>
                <td style="padding: inherit; margin: auto">
                    <asp:ListBox ID="ListBox1" runat="server" Width="195px" ></asp:ListBox>

                </td>
                <td style="padding: inherit; margin: auto">
                    <span style="font-size: medium"><strong>Bitte wählen Sie ein Fachgebiet aus, dann<br /> tragen Sie Ihre Kompetenz ein. </strong></span>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                </td>
                <td >

                    <asp:Button ID="Button1" runat="server" Text="Speichern" OnClick="Button1_Click" CssClass="btn btn-primary"  />

                </td>
                

            </tr>
        </table>
         </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Visible="true">
            <table style="width: 100%">
                <tr>
                    <td style="height: 40px">
                        <asp:Label ID="Label1" runat="server" Text="Rolen"></asp:Label>
                    </td>
                    <td style="height: 40px">
                        
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <br />
    </asp:Panel>
<p>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
    </p>
<p>&nbsp;</p>



</asp:Content>
