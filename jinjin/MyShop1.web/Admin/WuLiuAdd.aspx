<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WuLiuAdd.aspx.cs" Inherits="Admin_WuLiuAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>添加快递物流信息</title>
    <link href="CSS/gzf.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="bodydiv">
 <table class="myTab" cellpadding="4" cellspacing="1">
<tr class="myTRHead">
 <td class="myTDHead"  colspan="2" >添加快递信息 </td>
 </tr>

<tr >
<td  align="right">快递单号:</td>
    <td align="left" >
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
     <tr >
<td  align="right">收货人:</td>
    <td align="left" >
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
     <tr >
<td  align="right">收货地址:</td>
    <td align="left" >
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
     <tr >
<td  align="right">寄件人:</td>
    <td align="left" >
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td></tr>
     <tr >
<td  align="right">发货地址:</td>
    <td align="left" >
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td></tr>
     <tr >
<td  align="right">物流信息:</td>
    <td align="left" >
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td></tr>
     
<tr>
    <td align="right"></td>
    <td align="left">
                    <asp:Button ID="Button1" runat="server"  Text="确定"  onclick="Button1_Click" CssClass="btn"/>
                    <asp:Button ID="Button2" runat="server"  Text="重填"  onclick="Button2_Click" CssClass="btn"/>
 </td>
     </tr>
    </table>
</div>
    </form>
</body>
</html>
