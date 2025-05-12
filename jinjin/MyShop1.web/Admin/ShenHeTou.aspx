<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShenHeTou.aspx.cs" Inherits="Admin_ShenHe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>投递信息审核</title>
    <link href="CSS/gzf.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="bodydiv">
 <table class="myTab" cellpadding="4" cellspacing="1">
<tr class="myTRHead">
  <td class="myTDHead" >投递信息审核</td>
 </tr>
     <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="Idsexpress">
         <Columns>
             <asp:BoundField DataField="快递单号" HeaderText="快递单号" />
             <asp:BoundField DataField="快递员姓名" HeaderText="快递员姓名" />
             <asp:BoundField DataField="快递员手机号码" HeaderText="快递员手机号码" />
             <asp:BoundField DataField="用户手机号码" HeaderText="用户手机号码" />
             <asp:BoundField DataField="智能柜类型" HeaderText="智能柜类型" />
             <asp:BoundField DataField="存放时间" HeaderText="存放时间" />
             <asp:ButtonField HeaderText="审核" DataTextField="Status" ButtonType="Button" />
         </Columns>
     </asp:GridView>

     <asp:LinqDataSource ID="Idsexpress" runat="server" ContextTypeName="MyShop1.DAL.MyShop1DataContext" EntityTypeName="" TableName="投放快递审核表" Select="new (快递单号, 快递员姓名, 快递员手机号码, 用户手机号码, 智能柜类型, 存放时间, Status)">
        </asp:LinqDataSource>
     <asp:Button ID="btnSubit" runat="server" Text="确定" onclick="btnSubit_Click" CssClass="btn" />

    </table>
</div>
    </form>
</body>
</html>
