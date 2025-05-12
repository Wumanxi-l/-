<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KDZhiLiu.aspx.cs" Inherits="Admin_KDZhiLiu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>编辑快递滞留信息</title>
    <link href="CSS/gzf.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="bodydiv">
 <table class="myTab" cellpadding="4" cellspacing="1">
<tr class="myTRHead">
  <td class="myTDHead"  colspan="2" >编辑快递滞留信息</td>
 </tr>
     <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="Idsexpress" 
            DataKeyNames="快递单号" PageSize="6" Height="310px" Width="453px">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        <asp:CheckBox ID="chkALL" runat="server" AutoPostBack="True" Text="全选" OncheckedChanged="chkALL_CheckedChanged" />
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkitem" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="快递单号"  InsertVisible="False" ReadOnly="True" DataField="快递单号" SortExpression="快递单号" />
                <asp:BoundField DataField="用户名" HeaderText="用户名" SortExpression="用户名" />
                <asp:BoundField DataField="用户手机号码" HeaderText="用户手机号码" SortExpression="用户手机号码" />
                <asp:BoundField DataField="滞留时长" HeaderText="滞留时长" SortExpression="滞留时长" />
                <asp:BoundField DataField="超时费用" HeaderText="超时费用" SortExpression="超时费用" />
                <asp:CommandField HeaderText="编辑" ShowEditButton="True" />
            </Columns>
        </asp:GridView>

        <asp:LinqDataSource ID="Idsexpress" runat="server" ContextTypeName="MyShop1.DAL.MyShop1DataContext" EnableUpdate="True" EntityTypeName="" TableName="快递滞留表">
        </asp:LinqDataSource>
     <asp:Button ID="btnSubit" runat="server" Text="确定" onclick="btnSubit_Click" CssClass="btn" />
        <asp:Label ID="lblID" runat="server"></asp:Label>
    </table>
</div>
    </form>
</body>
</html>
