<%@ Page Title="登录" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      用户登录 </h2></div>
      <center>
    <table class="myTab" cellpadding="4" cellspacing="1">
        <tr>
            <td>
                用户名：</td>
            <td>
               <asp:TextBox ID="TextBox1" runat="server"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户不能为空" 
                    ControlToValidate="TextBox1"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                密码：</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空" 
                    ControlToValidate="TextBox2"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
           </td>
            <td align="left">
                <asp:Button ID="btnLogin" runat="server" Text="立即登录" onClick="btnLogin_Click" CssClass="btn"/>
                 <%--<asp:Button ID="Button1" runat="server"   Text="确定"  onclick="Button1_Click"  CssClass="btn"/>
                    <asp:Button ID="Button2" runat="server"   Text="重置" 
                     onclick="Button2_Click" CausesValidation="False" CssClass="btn"/>--%>
                    </td>
        </tr>
        <tr><td class="tdcenter"><a href="GetPwd.aspx">忘记密码？</a></td></tr>
        <tr>
      <td colspan="2" class="tdright">
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
      </td>
    </tr>
    </table>
    </center>
     </div>
</div>
</asp:Content>

