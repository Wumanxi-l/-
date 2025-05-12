<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bianjigui.aspx.cs" Inherits="Admin_Bianjigui" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>智能快递柜管理界面</title>
    <link href="CSS/gzf.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="bodydiv">
 <table class="myTab" cellpadding="4" cellspacing="1">
<tr class="myTRHead">
  <td class="myTDHead"  colspan="2" >编辑智能柜类型</td>
 </tr>
     <asp:GridView ID="gvexpress" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="Idsexpress" 
            DataKeyNames="智能柜ID" PageSize="6" Height="310px" Width="453px">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        <asp:CheckBox ID="chkALL" runat="server" AutoPostBack="True" Text="全选" OnCheckedChanged="chkALL_CheckedChanged" />
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkitem" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="智能柜ID"  InsertVisible="False" ReadOnly="True" DataField="智能柜ID" SortExpression="智能柜ID" />
                <asp:BoundField DataField="智能柜类型" HeaderText="智能柜类型" SortExpression="智能柜类型" />
                <asp:BoundField DataField="智能柜规格" HeaderText="智能柜规格" SortExpression="智能柜规格" />
                <%--<asp:BoundField DataField="Status" HeaderText="是否使用" SortExpression="Status" />--%>
                <asp:CommandField HeaderText="编辑" ShowEditButton="True" />
            </Columns>
        </asp:GridView>

        <asp:LinqDataSource ID="Idsexpress" runat="server" ContextTypeName="MyShop1.DAL.MyShop1DataContext" EnableUpdate="True" EntityTypeName="" TableName="快递柜表">
        </asp:LinqDataSource>
     <asp:Button ID="btnSubit" runat="server" Text="确定" onclick="btnSubit_Click1" CssClass="btn" />
        <asp:Label ID="lblID" runat="server"></asp:Label>
    </table>
</div>
    </form>
</body>
</html>
