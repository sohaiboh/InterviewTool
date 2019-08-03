<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Interview.aspx.cs" Inherits="InterviewTool.Teilnehmer.Interview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        label{
            margin-left: 5px;
        }
    </style>
    <h1>
        <strong>&nbsp;Interview Name: <asp:Label ID="Label1" runat="server"></asp:Label>
        &nbsp;&nbsp;
        </strong>
    </h1>
    
    <br />
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="Frageid,InterviewId" DataSourceID="SqlDataSource1" OnItemDataBound="ListView1_ItemDataBound">
        <AlternatingItemTemplate>
           <div class="jumbotron">
                 
                <asp:Label ID="Anwortformat1" runat="server" Text='<%# Eval("Anwortformat") %>' Visible="false" />
                <asp:Label ID="FrageidLabel1" runat="server" Text='<%# Eval("Frageid") %>' Visible="false" />
                <asp:Label ID="BezeichnungLabel" runat="server" Text='<%# Eval("Bezeichnung") %>' Font-Size="X-Large" />
                <br />
                    <asp:Image 
                        ImageUrl=<%# string.Format("~/Content/Uploads/{0}", Eval("Bilddatei1")) %>
                        runat="server" Visible="true" ID="Bilddatei1" Width="200" Height="200" />
                 
                <asp:Label ID="AudiodateiLabel" runat="server" Text='<%# Eval("Audiodatei") %>' Visible="false" />
                <audio controls runat="server" id="audio1" visible="false">
                  <source src="<%# string.Format("/Content/Uploads/{0}", Eval("Audiodatei")) %>" type="audio/mpeg">
                  Your browser does not support the audio element.
                </audio>
            
                <br />
                
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Answers" /><br />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Answers" /><br />
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Answers" /><br />
                    <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Answers" /><br />
                <asp:TextBox ID="range1" runat="server" TextMode="Range"></asp:TextBox>


                </div>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <span style="">Frageid:
            <asp:Label ID="FrageidLabel1" runat="server" Text='<%# Eval("Frageid") %>' />
            <br />
            InterviewId:
            <asp:Label ID="InterviewIdLabel1" runat="server" Text='<%# Eval("InterviewId") %>' />
            <br />
            Bezeichnung:
            <asp:TextBox ID="BezeichnungTextBox" runat="server" Text='<%# Bind("Bezeichnung") %>' />
            <br />
            Bilddatei1:
            <asp:TextBox ID="Bilddatei1TextBox" runat="server" Text='<%# Bind("Bilddatei1") %>' />
            <br />
            Bildatei2:
            <asp:TextBox ID="Bildatei2TextBox" runat="server" Text='<%# Bind("Bildatei2") %>' />
            <br />
            Audiodatei:
            <asp:TextBox ID="AudiodateiTextBox" runat="server" Text='<%# Bind("Audiodatei") %>' />
            <br />
            Anwortformat:
            <asp:TextBox ID="AnwortformatTextBox" runat="server" Text='<%# Bind("Anwortformat") %>' />
            <br />
            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            <br />
            <br />
            </span>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <span>No data was returned.</span>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <span style="">InterviewId:
            <asp:TextBox ID="InterviewIdTextBox" runat="server" Text='<%# Bind("InterviewId") %>' />
            <br />
            Bezeichnung:
            <asp:TextBox ID="BezeichnungTextBox" runat="server" Text='<%# Bind("Bezeichnung") %>' />
            <br />
            Bilddatei1:
            <asp:TextBox ID="Bilddatei1TextBox" runat="server" Text='<%# Bind("Bilddatei1") %>' />
            <br />
            Bildatei2:
            <asp:TextBox ID="Bildatei2TextBox" runat="server" Text='<%# Bind("Bildatei2") %>' />
            <br />
            Audiodatei:
            <asp:TextBox ID="AudiodateiTextBox" runat="server" Text='<%# Bind("Audiodatei") %>' />
            <br />
            Anwortformat:
            <asp:TextBox ID="AnwortformatTextBox" runat="server" Text='<%# Bind("Anwortformat") %>' />
            <br />
            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
            <br />
            <br />
            </span>
        </InsertItemTemplate>
        <ItemTemplate>
            <div class="jumbotron">
                 
                <asp:Label ID="Anwortformat1" runat="server" Text='<%# Eval("Anwortformat") %>' Visible="false" />
                <asp:Label ID="FrageidLabel1" runat="server" Text='<%# Eval("Frageid") %>' Visible="false" />
                <asp:Label ID="BezeichnungLabel" runat="server" Text='<%# Eval("Bezeichnung") %>' Font-Size="X-Large" />
                <br />
                    <asp:Image 
                        ImageUrl=<%# string.Format("~/Content/Uploads/{0}", Eval("Bilddatei1")) %>
                        runat="server" Visible="true" ID="Bilddatei1" Width="200" Height="200" />
                 
                <asp:Label ID="AudiodateiLabel" runat="server" Text='<%# Eval("Audiodatei") %>' Visible="false" />
                <audio controls runat="server" id="audio1" visible="false">
                  <source src="<%# string.Format("/Content/Uploads/{0}", Eval("Audiodatei")) %>" type="audio/mpeg">
                  Your browser does not support the audio element.
                </audio>
            
                <br />
                
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Answers" /><br />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Answers" /><br />
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Answers" /><br />
                    <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Answers" /><br />
                <asp:TextBox ID="range1" runat="server" TextMode="Range"></asp:TextBox>


                </div>
        </ItemTemplate>
        <LayoutTemplate>
            <div id="itemPlaceholderContainer" runat="server" style="">
                <span runat="server" id="itemPlaceholder" />
            </div>
            <div style="">
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <span style="">Frageid:
            <asp:Label ID="FrageidLabel" runat="server" Text='<%# Eval("Frageid") %>' />
            <br />
            InterviewId:
            <asp:Label ID="InterviewIdLabel" runat="server" Text='<%# Eval("InterviewId") %>' />
            <br />
            Bezeichnung:
            <asp:Label ID="BezeichnungLabel" runat="server" Text='<%# Eval("Bezeichnung") %>' />
            <br />
            Bilddatei1:
            <asp:Label ID="Bilddatei1Label" runat="server" Text='<%# Eval("Bilddatei1") %>' />
            <br />
            Bildatei2:
            <asp:Label ID="Bildatei2Label" runat="server" Text='<%# Eval("Bildatei2") %>' />
            <br />
            Audiodatei:
            <asp:Label ID="AudiodateiLabel" runat="server" Text='<%# Eval("Audiodatei") %>' />
            <br />
            Anwortformat:
            <asp:Label ID="AnwortformatLabel" runat="server" Text='<%# Eval("Anwortformat") %>' />
            <br />
            <br />
            </span>
        </SelectedItemTemplate>
    </asp:ListView>
    <p>
        <asp:Button ID="btnSave" runat="server" CssClass="GreenButton" OnClick="btnSave_Click" Text="Speichern" />
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InterviewToolDBConnectionString1 %>" DeleteCommand="DELETE FROM [Frage] WHERE [Frageid] = @Frageid AND [InterviewId] = @InterviewId" InsertCommand="INSERT INTO [Frage] ([InterviewId], [Bezeichnung], [Bilddatei1], [Bildatei2], [Audiodatei], [Anwortformat]) VALUES (@InterviewId, @Bezeichnung, @Bilddatei1, @Bildatei2, @Audiodatei, @Anwortformat)" SelectCommand="SELECT [Frageid], [InterviewId], [Bezeichnung], [Bilddatei1], [Bildatei2], [Audiodatei], [Anwortformat] FROM [Frage] WHERE ([InterviewId] = @InterviewId)" UpdateCommand="UPDATE [Frage] SET [Bezeichnung] = @Bezeichnung, [Bilddatei1] = @Bilddatei1, [Bildatei2] = @Bildatei2, [Audiodatei] = @Audiodatei, [Anwortformat] = @Anwortformat WHERE [Frageid] = @Frageid AND [InterviewId] = @InterviewId">
            <DeleteParameters>
                <asp:Parameter Name="Frageid" Type="Int32" />
                <asp:Parameter Name="InterviewId" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="InterviewId" Type="Int32" />
                <asp:Parameter Name="Bezeichnung" Type="String" />
                <asp:Parameter Name="Bilddatei1" Type="String" />
                <asp:Parameter Name="Bildatei2" Type="String" />
                <asp:Parameter Name="Audiodatei" Type="String" />
                <asp:Parameter Name="Anwortformat" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter Name="InterviewId" QueryStringField="InterviewId" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Bezeichnung" Type="String" />
                <asp:Parameter Name="Bilddatei1" Type="String" />
                <asp:Parameter Name="Bildatei2" Type="String" />
                <asp:Parameter Name="Audiodatei" Type="String" />
                <asp:Parameter Name="Anwortformat" Type="String" />
                <asp:Parameter Name="Frageid" Type="Int32" />
                <asp:Parameter Name="InterviewId" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
    </p>
</asp:Content>
