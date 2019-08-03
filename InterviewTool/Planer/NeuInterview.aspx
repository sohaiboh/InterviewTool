<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NeuInterview.aspx.cs" Inherits="InterviewTool.Planer.NeuInterview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Neu Interview</h1>
    <p>&nbsp;</p>
    <table style="width: 100%">
        <tr>
            <td style="height: 22px; text-align: center; font-size: large;width: 553px;" ><strong>Titel</strong></td>
            <td style="height: 22px; margin-left: 40px;">
                <asp:TextBox ID="txt1" runat="server" Height="22px" Width="230px"></asp:TextBox>
                <br />
                <asp:Label ID="TitelMissing" runat="server" EnableTheming="True" Visible="False"></asp:Label>
                <br />
                <hr />

            </td>
        </tr>
        <tr>
            <td style="height: 22px; font-size: large; width: 553px;"><strong>Fachgebiet</strong></td>
            <td style="height: 22px ; text-align: center;"  >
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="179px" HorizontalAlign="Center">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:BoundField DataField="Name" HeaderText="Fachgebiet" />
                    </Columns>
                </asp:GridView>
                <asp:Label ID="fachgebieterror" runat="server" Visible="False"></asp:Label>
                <br />
                <hr />
            </td>
        </tr>
        <tr>
            <td style="height: 22px; font-size: large; width: 553px;"><strong>Gruppe</strong></td>
            <td style="height: 22px">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" >

                    <asp:ListItem>Einzelveranstaltung</asp:ListItem>
                    <asp:ListItem>Nummer der Hauptveranstaltung</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Label ID="GruppeMissing" runat="server" Visible="False"></asp:Label>
                <br />
                <hr />

                <asp:ListBox ID="ListBox2" runat="server" Visible="False" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged"></asp:ListBox>
                <br />
                <br />

                <asp:Label ID="Label1" runat="server" Visible="False" ></asp:Label>
                <asp:Button ID="triggerbutton" runat="server" Text="Gehört dazu" Visible="False" OnClick="triggerbutton_Click" EnableTheming="True" CssClass="GreenButton" />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td style="height: 22px; font-size: large; width: 553px;" ><strong>Termin Beginn </strong> </td>
            <td style="height: 22px">
               
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>jQuery UI Datepicker - Default functionality</title>
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
                    <script src="../Scripts/jquery-1.12.4.js"></script>
                    <script src="../Scripts/jquery-ui.js"></script>
                   
                     <script>  $( function() {
      $("#datepicker1").datepicker();

      var s = document.getElementById('datepicker');
     
      
      
  });
                         
  </script>
                    
</head>
                <p>Datum: <input type="text" id="datepicker" name="datepicker">
                </p>
                <asp:Label ID="lblbegintermin" runat="server"></asp:Label>
                <br />
                <br />
                <hr />

            </td>
        </tr>
        <tr>
            <td style="height: 22px; font-size: large; width: 553px;"><strong>Termin Ende</strong></td>
            <td style="height: 22px">
               
<%--               <head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>jQuery UI Datepicker - Default functionality</title>--%>
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
                    <script src="../Scripts/jquery-1.12.4.js"></script>
                    <script src="../Scripts/jquery-ui.js"></script>
                   
  <script>
  $( function() {
    $( "#datepicker" ).datepicker();
  } );
  </script>
<%--</head>--%>
                 <p>Datum: <input type="text" id="datepicker1" name="datepicker1">
                </p>

                <asp:Label ID="lblendtermin" runat="server"></asp:Label>
                <br />
                <hr />

            </td>
        </tr>
        <tr>
            <td style="font-size: large; width: 553px;"valign="top"><strong>Min. Anzahl Teilnehmer</strong></td>
            <td>
                <asp:TextBox ID="txtminanzahl" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblminanzahl" runat="server"></asp:Label>
                <hr />
            </td>
                

        </tr>
    </table>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        
        <asp:Button ID="btnWeiter" runat="server" Text="Weiter "  style="margin-left:550px;" OnClick="btnWeiter_Click" CssClass="GreenButton"  />
    </p>
</asp:Content>
