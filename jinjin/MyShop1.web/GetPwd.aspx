<%@ Page Title="找回密码" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GetPwd.aspx.cs" Inherits="GetPwd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      找回密码 </h2></div>
      <center>
    <table class="myTab" cellpadding="4" cellspacing="1">
        <tr>
            <td>
                用户名：</td>
            <td>
               <asp:TextBox ID="txtName" runat="server"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户不能为空" 
                    ControlToValidate="txtName"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                邮箱Email：</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Password"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator2" runat="server" ErrorMessage="邮箱不能为空" 
                    ControlToValidate="txtEmail"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
          <td class="tdright" colspan="2">
            <asp:RegularExpressionValidator ID="revEmail" runat="server"
              ErrorMessage="邮箱格式不正确！" ControlToValidate="txtEmail" Display="Dynamic" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
          </td>
        </tr>
        <tr>
            <td>
           </td>
            <td align="left">
                <asp:Button ID="btnResetPwd" runat="server" Text="找回密码" onClick="btnResetPwd_Click" />
                    </td>
        </tr>
        <tr>
          <td colspan="2">找回密码，需要验证邮箱！</td>
        </tr>
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

