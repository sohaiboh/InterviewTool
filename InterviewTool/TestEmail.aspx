﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestEmail.aspx.cs" Inherits="InterviewTool.TestEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send Email" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Test Label" />
    
    </div>
    </form>
</body>
</html>
