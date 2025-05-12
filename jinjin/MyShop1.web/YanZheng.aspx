<%@ Page Language="C#" AutoEventWireup="true" CodeFile="YanZheng.aspx.cs" Inherits="YanZheng" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>控件验证</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="用户名：" Width="80px"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入用户名！" ControlToValidate="TextBox1" Display="Dynamic"  SetFocusOnError="true" >*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label3" runat="server" Text="密码：" Width="80px"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入密码！" Display="Dynamic" ControlToValidate="TextBox2" SetFocusOnError="true" >*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label5" runat="server" Text="确认密码：" Width="80px"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请输入确认密码！" ControlToValidate="TextBox3" Display="Dynamic" SetFocusOnError="true">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="密码与确认密码不一致！" ControlToCompare="TextBox2" ControlToValidate="TextBox3" Display="Dynamic" SetFocusOnError="true" ></asp:CompareValidator>
            <br />
            <asp:Label ID="Label7" runat="server" Text="生日：" Width="80px"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="请输入生日！" ControlToValidate="TextBox4" Display="Dynamic" SetFocusOnError="true">*</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="日期应在1900-1-1到2023-10-1之间" ControlToValidate="TextBox4" Display="Dynamic"  MaximumValue="2020-1-1" MinimumValue="1900-1-1" SetFocusOnError="true" Type="Date"></asp:RangeValidator>
            <br />
            <asp:Label ID="Label9" runat="server" Text="电话号码：" Width="80px"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="请输入电话号码！" ControlToValidate="TextBox5" Display="Dynamic" SetFocusOnError="true" >*</asp:RequiredFieldValidator>   
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="电话号码格式应为010-12345678！" ControlToValidate="TextBox5" Display="Dynamic" ValidationExpression="\d{3}-\d{8}" SetFocusOnError="true"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="Label11" runat="server" Text="身份证号：" Width ="80px"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="请输入身份证号！" ControlToValidate="TextBox6" Display="Dynamic" SetFocusOnError="true">*</asp:RequiredFieldValidator>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="身份证号错误！" ControlToValidate="TextBox6" Display="Dynamic"  SetFocusOnError="true" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>

        </div>
        <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" Width="50px" />
        <br />
        <asp:Label ID="Label12" runat="server" Width="80px"></asp:Label>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server"   ShowMessageBox="true" ShowSummary="false"/>
    </form>
</body>
</html>
