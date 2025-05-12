<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HuiYuanGL.aspx.cs" Inherits="Admin_HuiYuanGL" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>会员信息管理界面</title>
    <link href="CSS/gzf.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="bodydiv">
 <table class="myTab" cellpadding="4" cellspacing="1">
<tr class="myTRHead">
  <td class="myTDHead"  colspan="2" >编辑会员信息</td>
 </tr>
     <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="Idsexpress" 
            DataKeyNames="CustomerId" PageSize="6" Height="310px" Width="453px">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        <asp:CheckBox ID="chkALL" runat="server" AutoPostBack="True" Text="全选" OncheckedChanged="chkALL_CheckedChanged" />
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkitem" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="CustomerId"  InsertVisible="False" ReadOnly="True" DataField="CustomerId" SortExpression="CustomerId" />
                <asp:BoundField DataField="Name" HeaderText="用户名" SortExpression="Name" />
                <asp:BoundField DataField="Password" HeaderText="密码" SortExpression="Password" />
                <asp:BoundField DataField="手机号码" HeaderText="手机号码" SortExpression="手机号码" />
                <asp:BoundField DataField="地址" HeaderText="地址" SortExpression="地址" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:CommandField HeaderText="编辑" ShowEditButton="True" />
            </Columns>
        </asp:GridView>

        <asp:LinqDataSource ID="Idsexpress" runat="server" ContextTypeName="MyShop1.DAL.MyShop1DataContext" EnableUpdate="True" EntityTypeName="" TableName="用户表">
        </asp:LinqDataSource>
     <asp:Button ID="btnSubit" runat="server" Text="确定" onclick="btnSubit_Click" CssClass="btn" />
        <asp:Label ID="lblID" runat="server"></asp:Label>
    </table>
</div>
    </form>
</body>
</html>
