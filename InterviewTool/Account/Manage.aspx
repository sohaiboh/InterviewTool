<%@ Page Title="Benutzer Verwaltung" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="InterviewTool.Account.Manage" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>

    <div>
        <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
            <p class="text-success"><%: SuccessMessage %></p>
        </asp:PlaceHolder>
    </div>

    <div class="row">
        <div class="col-md-12">
            <div class="form-horizontal">
                <h4>Ändern sich Ihre Benutzereinstellungen</h4>
                <hr />
                <dl class="dl-horizontal">
                    <%--<dt>Passwort:</dt>
                    <dd>
                        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Change]" Visible="false" ID="ChangePassword" runat="server" />
                        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Create]" Visible="false" ID="CreatePassword" runat="server" />
                    </dd>--%>
<%--                    <dt>External Logins:</dt>
                    <dd><%: LoginsCount %>
                        <asp:HyperLink NavigateUrl="/Account/ManageLogins" Text="[Manage]" runat="server" />

                    </dd>--%>
                    <%--
                        Phone Numbers can used as a second factor of verification in a two-factor authentication system.
                        See <a href="http://go.microsoft.com/fwlink/?LinkId=403804">this article</a>
                        for details on setting up this ASP.NET application to support two-factor authentication using SMS.
                        Uncomment the following blocks after you have set up two-factor authentication
                    --%>
                    <%--
                    <dt>Phone Number:</dt>
                    <% if (HasPhoneNumber)
                       { %>
                    <dd>
                        <asp:HyperLink NavigateUrl="/Account/AddPhoneNumber" runat="server" Text="[Add]" />
                    </dd>
                    <% }
                       else
                       { %>
                    <dd>
                        <asp:Label Text="" ID="PhoneNumber" runat="server" />
                        <asp:HyperLink NavigateUrl="/Account/AddPhoneNumber" runat="server" Text="[Change]" /> &nbsp;|&nbsp;
                        <asp:LinkButton Text="[Remove]" OnClick="RemovePhone_Click" runat="server" />
                    </dd>
                    <% } %>
                    --%>

                    <dd>
                        <% if (TwoFactorEnabled)
                          { %> 
                        <%--
                        Enabled
                        <asp:LinkButton Text="[Disable]" runat="server" CommandArgument="false" OnClick="TwoFactorDisable_Click" />
                        --%>
                        <% }
                          else
                          { %> 
                        <%--
                        Disabled
                        <asp:LinkButton Text="[Enable]" CommandArgument="true" OnClick="TwoFactorEnable_Click" runat="server" />
                        --%>
                        <% } %>

                          <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
                    <script src="../Scripts/jquery-1.12.4.js"></script>
                    <script src="../Scripts/jquery-ui.js"></script>

                    <script>
                        $( function() {
                            $( "#accordion" ).accordion();
                        } );
                    </script>

                        <div id="accordion">
  <h3>Passwort</h3>
  <div>
    <p>

        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Change]" Visible="false" ID="ChangePassword" runat="server" />
        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Create]" Visible="false" ID="CreatePassword" runat="server" />

    </p>
  </div>
  <h3>Fachgebiet/Kompotenz wählen</h3>
  <div>
    <p>
        &nbsp;</p>
      <p>
          <table style="width: 100%">
              <tr>
                  <td style="height: 76px">
                    <asp:ListBox ID="ListBox1" runat="server" Width="195px" ></asp:ListBox>

                  </td>
                  <td style="height: 76px"></td>
              </tr>
              <tr>
                  <td>
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>Experte</asp:ListItem>
        <asp:ListItem>Anfanger</asp:ListItem>
        <asp:ListItem>Mittel Stufe</asp:ListItem>
        <asp:ListItem>Muttersprache</asp:ListItem>
        <asp:ListItem>Fremdsprache</asp:ListItem>
    </asp:DropDownList>
                  </td>
                  <td>

                    <asp:Button ID="Button1" runat="server" Text="Speichern" OnClick="Button1_Click" CssClass="btn btn-primary"  />

                  </td>
              </tr>
          </table>
    </p>
  </div>
 
</div>
                        
                    </dd>
                </dl>
            </div>
        </div>
    </div>

</asp:Content>
