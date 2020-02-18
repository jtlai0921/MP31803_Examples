<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="BookWeb.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [員工] WHERE [員工編號] = @員工編號" InsertCommand="INSERT INTO [員工] ([員工編號], [姓名], [信箱], [薪資], [雇用日期], [是否已婚]) VALUES (@員工編號, @姓名, @信箱, @薪資, @雇用日期, @是否已婚)" SelectCommand="SELECT * FROM [員工]" UpdateCommand="UPDATE [員工] SET [姓名] = @姓名, [信箱] = @信箱, [薪資] = @薪資, [雇用日期] = @雇用日期, [是否已婚] = @是否已婚 WHERE [員工編號] = @員工編號">
                <DeleteParameters>
                    <asp:Parameter Name="員工編號" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="員工編號" Type="String" />
                    <asp:Parameter Name="姓名" Type="String" />
                    <asp:Parameter Name="信箱" Type="String" />
                    <asp:Parameter Name="薪資" Type="Int32" />
                    <asp:Parameter DbType="Date" Name="雇用日期" />
                    <asp:Parameter Name="是否已婚" Type="Boolean" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="姓名" Type="String" />
                    <asp:Parameter Name="信箱" Type="String" />
                    <asp:Parameter Name="薪資" Type="Int32" />
                    <asp:Parameter DbType="Date" Name="雇用日期" />
                    <asp:Parameter Name="是否已婚" Type="Boolean" />
                    <asp:Parameter Name="員工編號" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" CellPadding="4" DataKeyNames="員工編號" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="50px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
                <EditRowStyle BackColor="#999999" />
                <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
                <Fields>
                    <asp:BoundField DataField="員工編號" HeaderText="員工編號" ReadOnly="True" SortExpression="員工編號" />
                    <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                    <asp:BoundField DataField="信箱" HeaderText="信箱" SortExpression="信箱" />
                    <asp:BoundField DataField="薪資" HeaderText="薪資" SortExpression="薪資" />
                    <asp:TemplateField HeaderText="雇用日期" SortExpression="雇用日期">
                        <EditItemTemplate>
                            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" SelectedDate='<%# Bind("雇用日期") %>' ShowGridLines="True" Width="220px">
                                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                <OtherMonthDayStyle ForeColor="#CC9966" />
                                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                <SelectorStyle BackColor="#FFCC66" />
                                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                            </asp:Calendar>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" SelectedDate='<%# Bind("雇用日期") %>' Width="220px">
                                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                                <WeekendDayStyle BackColor="#CCCCFF" />
                            </asp:Calendar>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("雇用日期", "{0:d}") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CheckBoxField DataField="是否已婚" HeaderText="是否已婚" SortExpression="是否已婚" />
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            </asp:DetailsView>
        </div>
    </form>
</body>
</html>
