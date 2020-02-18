<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BookWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [書籍] WHERE [編號] = @編號" InsertCommand="INSERT INTO [書籍] ([編號], [書名], [單價], [圖示]) VALUES (@編號, @書名, @單價, @圖示)" SelectCommand="SELECT * FROM [書籍]" UpdateCommand="UPDATE [書籍] SET [書名] = @書名, [單價] = @單價, [圖示] = @圖示 WHERE [編號] = @編號">
                <DeleteParameters>
                    <asp:Parameter Name="編號" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="編號" Type="String" />
                    <asp:Parameter Name="書名" Type="String" />
                    <asp:Parameter Name="單價" Type="Int32" />
                    <asp:Parameter Name="圖示" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="書名" Type="String" />
                    <asp:Parameter Name="單價" Type="Int32" />
                    <asp:Parameter Name="圖示" Type="String" />
                    <asp:Parameter Name="編號" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>

            編號：<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <br />
            <br />
            書名：<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            單價：<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />
            <br />
            圖示：<asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="新增" OnClick="btnAdd_Click" />
            <asp:Label ID="lblShow" runat="server" ></asp:Label>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="編號" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" PageSize="3">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="編號" HeaderText="編號" ReadOnly="True" SortExpression="編號" />
                    <asp:BoundField DataField="書名" HeaderText="書名" SortExpression="書名" />
                    <asp:BoundField DataField="單價" HeaderText="單價" SortExpression="單價" />
                    <asp:TemplateField HeaderText="圖示" SortExpression="圖示">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("圖示") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("圖示", "Images/{0}") %>' Width="160px" />
                        </ItemTemplate>
                    </asp:TemplateField>
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

        </div>
    </form>
</body>
</html>
