<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NeuInterview2.aspx.cs" Inherits="InterviewTool.Planer.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Neu Interview</h1>
    <table style="width: 100%">
        <tr>
            <td style="height: 27px">Datei Typ</td>
            <td style="height: 27px">
                <asp:DropDownList ID="ddlFileType" runat="server" OnSelectedIndexChanged="ddlFileType_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Value="Choose Option">Möglichkeit wählen</asp:ListItem>
                    <asp:ListItem Value="Picture">Bild</asp:ListItem>
                    <asp:ListItem>Audio</asp:ListItem>
                </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td style="height: 27px">
                <asp:Label ID="lblFiletype" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr runat="server" id="audioRow" visible="false">
            <td>Audio</td>
            <td>

                <asp:FileUpload ID="FileUploadAudio" runat="server" />
            </td>
            <td  
 >
                <asp:Label ID="lblAudio" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr runat="server" id="pictureRow" visible="false">
            <td style="height: 24px">Bild</td>
            <td style="height: 24px">
                <asp:FileUpload ID="FileUploadPicture" runat="server" />
            </td>
            <td style="height: 24px">
                <asp:Label ID="lblpicture" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 24px">Frage</td>
            <td style="height: 24px">
                <asp:TextBox ID="txtfrage" runat="server"></asp:TextBox>
            </td>
            <td style="height: 24px">
                <asp:Label ID="lblfrage" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 24px">Antwort Typ</td>
            <td style="height: 24px">
                <asp:DropDownList ID="ddlAnswerType" runat="server" OnSelectedIndexChanged="ddlAnswerType_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Value="Möglichkeit wählen">Choose Option</asp:ListItem>
                    <asp:ListItem>Text</asp:ListItem>
                    <asp:ListItem>Skalar</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="height: 24px">
                <asp:Label ID="lblAnswertype" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr runat="server" id="antwort1" visible="false">
            <td style="height: 24px">Mögliche Antwort 1</td>
            <td style="height: 24px">
                <asp:TextBox ID="MöglicheAntwort1" runat="server" ></asp:TextBox>
            </td>
            <td style="height: 24px">
                <asp:Label ID="lblMögliche1" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr runat="server" id="antwort2" visible="false" >
            <td>Mögliche Antwort 2</td>
            <td>
                <asp:TextBox ID="MöglicheAntwort2" runat="server" ></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblMögliche2" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr runat="server" id="antwort3" visible="false">
            <td>Mögliche Antwort 3</td>
            <td>
                <asp:TextBox ID="MöglicheAntwort3" runat="server" ></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr runat="server" id="antwort4" visible="false">
            <td>Mögliche Antwort 4</td>
            <td>
                <asp:TextBox ID="MöglicheAntwort4" runat="server" ></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr runat="server" id="antskalaranfang" visible="false">
            <td>Skalar Anfangswert</td>
            <td>
                <asp:TextBox ID="txtAnfangwert" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblAnfang" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr runat="server" id="antskalarend" visible="false">
            <td>Skalar Endwert</td>
            <td>
                <asp:TextBox ID="txtEndwert" runat="server" ></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblEnd" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr runat="server" id="antskalarschritt" visible="false">
            <td>Skalar Schrittweite</td>
            <td>
                <asp:TextBox ID="txtSchrittweite" runat="server" ></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lblSchritt" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" CssClass="GreenButton" />
                <asp:Button ID="btnDone" runat="server" Text="Done" OnClick="btnDone_Click" CssClass="GreenButton" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
