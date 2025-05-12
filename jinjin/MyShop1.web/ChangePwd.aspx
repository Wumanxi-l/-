<%@ Page Title="修改密码" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePwd.aspx.cs" Inherits="ChangePwd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      修改密码 </h2></div>
      <center>
    <table class="myTab" cellpadding="4" cellspacing="1">
        <tr>
            <td>
                原密码：</td>
            <td>
               <asp:TextBox ID="txtOldPwd" runat="server"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator1" runat="server" ErrorMessage="不能为空" 
                    ControlToValidate="txtOldPwd"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                新密码：</td>
            <td>
                <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator2" runat="server" ErrorMessage="不能为空" 
                    ControlToValidate="txtPwd"></asp:RequiredFieldValidator></td>
        </tr>
         <tr>
            <td>
                确认新密码：</td>
            <td>
                <asp:TextBox ID="txtPwdAgain" runat="server" TextMode="Password"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator3" runat="server" ErrorMessage="不能为空" 
                    ControlToValidate="txtPwdAgain"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
      <td class="tdright" colspan="2">
        <asp:CompareValidator ControlToValidate="txtPwdAgain" ControlToCompare="txtPwd" Display="Dynamic" ForeColor="Red" ID="cvPwd" runat="server" ErrorMessage="2次新密码不一致"></asp:CompareValidator>
      </td>
    </tr>
        <tr>
            <td>
           </td>
            <td align="left">
                <asp:Button ID="btnChangePwd" runat="server" Text="确认修改" onClick="btnChangePwd_Click" CssClass="btn"/>
                    </td>
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

