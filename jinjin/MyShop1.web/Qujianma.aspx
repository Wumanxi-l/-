<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Qujianma.aspx.cs" Inherits="Qujianma" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      发送取件码 </h2></div>
      <center>
    <table class="myTab" cellpadding="4" cellspacing="1">
        <tr>
            <td>
                智能柜ID：</td>
            <td>
               <asp:TextBox ID="TextBox1" runat="server"  CssClass="txtcss"></asp:TextBox><%--<asp:RequiredFieldValidator
                   ID="RequiredFieldValidator1" runat="server" ErrorMessage="智能柜ID不能为空" 
                    ControlToValidate="TextBox1"></asp:RequiredFieldValidator>--%></td>
        </tr>
        <tr>
            <td>
                取件码：</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"  CssClass="txtcss"></asp:TextBox><%--<asp:RequiredFieldValidator
                   ID="RequiredFieldValidator2" runat="server" ErrorMessage="取件码不能为空" 
                    ControlToValidate="TextBox2"></asp:RequiredFieldValidator>--%></td>
        </tr>
        <tr>
            <td>
                存放码：</td>
            <td>
                <%--<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>--%>
                <asp:TextBox ID="TextBox3" runat="server"  CssClass="txtcss"></asp:TextBox><%--<asp:RequiredFieldValidator
                   ID="RequiredFieldValidator3" runat="server" ErrorMessage="存放码不能为空" 
                    ControlToValidate="txtqcode"></asp:RequiredFieldValidator>--%></td>
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

