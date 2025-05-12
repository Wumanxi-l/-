<%@ Page Title="发送寄件码" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Jijianma.aspx.cs" Inherits="Jijianma" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      发送寄件码 </h2></div>
      <center>
    <table class="myTab" cellpadding="4" cellspacing="1">
        <tr>
            <td>
                智能柜ID：</td>
            <td>
                <%--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>
               <asp:TextBox ID="TextBox1" runat="server"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator1" runat="server" ErrorMessage="智能柜ID不能为空" 
                    ControlToValidate="TextBox1"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                寄件码：</td>
            <td>
                <%--<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>--%>
                <asp:TextBox ID="txtqcode" runat="server"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator2" runat="server" ErrorMessage="寄件码不能为空" 
                    ControlToValidate="txtqcode"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
           </td>
            <td align="left">
                <asp:Button ID="btnLogin" runat="server" Text="确定" onclick="btnLogin_Click" CssClass="btn"/>
                    </td>
        </tr>
    </table>
    </center>
     </div>
</div>
</asp:Content>

