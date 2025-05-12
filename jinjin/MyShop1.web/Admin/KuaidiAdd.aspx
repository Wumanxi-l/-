<%@ Page Language="C#" AutoEventWireup="true" CodeFile="KuaidiAdd.aspx.cs" Inherits="Admin_KuaidiAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>添加快递信息</title>
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
<td  align="right">快递员姓名:</td>
    <td align="left" >
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
     <tr >
<td  align="right">快递员手机号码:</td>
    <td align="left" >
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
     <tr >
<td  align="right">用户手机号码:</td>
    <td align="left" >
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td></tr>
     <tr>
            <td align="right">
                智能柜类型：</td>
            <td>
               <asp:DropDownList ID="DropDownList1" runat="server" Height="28px" Width="155px">
                    <asp:ListItem>小柜</asp:ListItem>
                    <asp:ListItem>中柜</asp:ListItem>
                    <asp:ListItem>大柜</asp:ListItem>
                    <asp:ListItem>冷藏小柜</asp:ListItem>
                    <asp:ListItem>冷藏中柜</asp:ListItem>
                    <asp:ListItem>冷藏大柜</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
     <tr>
            <td align="right">
                存放时间：</td>
            <td>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></td>
        </tr>
<tr>
    <td align="right"></td>
    <td align="left">
                    <asp:Button ID="Button1" runat="server"    Text="确定"   onclick="Button1_Click" class="btn"/>
                    <asp:Button ID="Button2" runat="server"    Text="重填"   onclick="Button2_Click" class="btn"/>
 </td>
     </tr>

    </table>
</div>
    </form>
</body>
</html>
