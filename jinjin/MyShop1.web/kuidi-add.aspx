<%@ Page Title="寄件下单" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="kuidi-add.aspx.cs" Inherits="kuidi_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      寄件下单 </h2></div>
      <center>
    <table class="myTab" cellpadding="4" cellspacing="1">
        <tr>
            <td>
                用户名：</td>
            <td>
               <asp:TextBox ID="TextBox1" runat="server"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名不能为空" 
                    ControlToValidate="TextBox1"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                手机号码：</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator2" runat="server" ErrorMessage="手机号码不能为空" 
                    ControlToValidate="TextBox2"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                寄件地址：</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator3" runat="server" ErrorMessage="地址不能为空" 
                    ControlToValidate="TextBox3"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                智能柜类型：</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="28px" Width="155px">
                    <asp:ListItem>小柜</asp:ListItem>
                    <asp:ListItem>中柜</asp:ListItem>
                    <asp:ListItem>大柜</asp:ListItem>
                    <asp:ListItem>冷藏小柜</asp:ListItem>
                    <%--<asp:ListItem>冷藏中柜</asp:ListItem>
                    <asp:ListItem>冷藏大柜</asp:ListItem>--%>
                </asp:DropDownList>
                <%--<asp:LinqDataSource ID="LinqDataSource1" runat="server"></asp:LinqDataSource>--%>
                <%--<asp:TextBox ID="TextBox4" runat="server"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator4" runat="server" ErrorMessage="智能柜ID不能为空" 
                    ControlToValidate="TextBox2"></asp:RequiredFieldValidator>--%></td>
        </tr>
        <tr>
            <td>
                物品类型：</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"  CssClass="txtcss"></asp:TextBox><asp:RequiredFieldValidator
                   ID="RequiredFieldValidator4" runat="server" ErrorMessage="物品类型不能为空" 
                    ControlToValidate="TextBox4"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                预约日期：</td>
            <td>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </td>
        </tr>
        <tr>
            <td>
           </td>
            <td align="left">
                <asp:Button ID="Button1" runat="server" Text="下一步" onclick="Button1_Click" CssClass="btn"/>
                 <asp:Button ID="Button2" runat="server" Text="重置" onclick="Button2_Click"  CssClass="btn"/>
                    </td>
        </tr>
    </table>
    </center>
     </div>
</div>
</asp:Content>

