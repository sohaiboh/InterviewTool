<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TeilnehmerEinladen.aspx.cs" Inherits="InterviewTool.Planer.TeilnehmerEinladen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Teilnehmer Einladen</h1>
    <p>
        &nbsp;</p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox2" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    <p>
        &nbsp;</p>
    <p>
       
        <asp:Button  CssClass ="GreenButton" ID="btnShowAllUsers" runat="server" OnClick="btnShowAllUsers_Click" Text="Alle Nutzer anzeigen"  />
    </p>
    <asp:Panel ID="Panel1" runat="server" Visible="False">
        <p>
            Alle Nutzer</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        </p>
    </asp:Panel>
    <p>
       
           
        <asp:Button  CssClass ="GreenButton" ID="btnSendInvitation" runat="server" OnClick="btnSendInvitation_Click" Text="Einladung schicken" />
    &nbsp;&nbsp;<input class="GreenButton" id="Button1" type="button" value="Zufällig einladen" /></p>
    <p>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </p>

    <script>

        $(document).ready(function () {
            
            $('#Button1').click(function () {

                $('input:checkbox').each(function () {
                    console.log(this);
                    if(getRandomInt(0, 2) == 1)
                        $(this).prop('checked', true);
                    else
                        $(this).prop('checked', false);
                })
                //alert('clicked');
            });

        });

        function getRandomInt(min, max) {
            min = Math.ceil(min);
            max = Math.floor(max);
            return Math.floor(Math.random() * (max - min)) + min; //The maximum is exclusive and the minimum is inclusive
        }

        function getRandomArbitrary(min, max) {
            return Math.random() * (max - min) + min;
        }


    </script>
</asp:Content>
