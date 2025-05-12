<%@ Page Title="注册" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NewUser.aspx.cs" Inherits="NewUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      用户注册 </h2></div>
      <center>
     <table  class="myTab" cellpadding="4" cellspacing="1">
    
    <tr>
        <td >
            <table align="center">
                <tr>
                    <td align="right" class="style1">
                        用户名：</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="txtcss"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="TextBox1" ErrorMessage="用户名不能为空">用户名不能为空</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style1">
                        密码：</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"  CssClass="txtcss"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="TextBox2" ErrorMessage="密码不能为空">密码不能为空</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style1">
                        重复密码：</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"  CssClass="txtcss"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                            ControlToCompare="TextBox2" ControlToValidate="TextBox3" 
                            ErrorMessage="两次密码必须一致">两次密码必须一致</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style1">
                        地址：</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="TextBox4" runat="server"  CssClass="txtcss"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="TextBox1" ErrorMessage="地址不能为空">地址不能为空</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style1">
                        手机号码：</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="TextBox7" runat="server"  CssClass="txtcss"></asp:TextBox>
                         <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                   ControlToValidate="TextBox7" ErrorMessage="手机号码格式有误" 
                   ValidationExpression="^1[3|4|5|8][0-9]\d{4,8}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="style1">
                        邮箱Email：</td>
                    <td style="text-align: left">
                        <asp:TextBox ID="TextBox8" runat="server"  CssClass="txtcss"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                            ControlToValidate="TextBox8" ErrorMessage="格式不正确" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="注册" onClick="Button1_Click" CssClass="btn"/>
                    </td>
                </tr>
                <tr>
                    <td><a href="Login.aspx">我要登录</a></td>
                    <td>
                        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label></td>
    </tr>
            </table>
        </td>
    </tr>
</table>
</center>
</div>
</div>
</asp:Content>

