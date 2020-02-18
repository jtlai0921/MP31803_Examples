<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mobile.aspx.cs" Inherits="BookMobile.Mobile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>博碩書籍</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="jquery-1.11.3.min.js"></script>
    <link href="jquery.mobile-1.4.5.min.css" rel="stylesheet" />
    <script src="jquery.mobile-1.4.5.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [書籍]"></asp:SqlDataSource>
        </div>
        <div data-role="page">
            <div data-role="header"><h3>優質電腦圖書</h3></div>
            <div data-role="content">
                <asp:ListView ID="ListView1" runat="server"
                    DataKeyNames="編號" DataSourceID="SqlDataSource1">
                    <ItemTemplate>
                        <li>
                            <img src="images/<%# Eval("圖示") %>" />
                            <h3><%# Eval("書名") %></h3>
                            <p>單價：<%# Eval("單價") %></p>
                        </li>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <ul id="itemPlaceholderContainer" runat="server"
                            data-role="listview" data-inset="true"
                            data-filter="true">
                            <li data-role="list-divider">博碩系列</li>
                            <li runat="server" id="itemPlaceholder" />
                        </ul>
                    </LayoutTemplate>
                </asp:ListView>
            </div>
            <div data-role="footer" data-position="fixed">
                <h3>資訊教育研究室版權所有</h3>
            </div>
        </div>
    </form>
</body>
</html>
