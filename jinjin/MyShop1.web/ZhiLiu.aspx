<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ZhiLiu.aspx.cs" Inherits="ZhiLiu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      滞留单查询 快递单号：
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      <asp:Button ID="Button1"
          runat="server" Text="查询" onclick="Button1_Click" />
                      </h2></div>
      <center>
    <table class="myTab" cellpadding="4" cellspacing="1">
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="Idsnumber">
         <Columns>
             <asp:BoundField DataField="快递单号" HeaderText="快递单号" />
             <asp:BoundField DataField="用户名" HeaderText="用户名" />
             <asp:BoundField DataField="用户手机号码" HeaderText="用户手机号码" />
             <asp:BoundField DataField="滞留时长" HeaderText="滞留时长" />
             <asp:BoundField DataField="超时费用" HeaderText="超时费用" />
         </Columns>
     </asp:GridView>

     <asp:LinqDataSource ID="Idsnumber" runat="server" ContextTypeName="MyShop1.DAL.MyShop1DataContext" EntityTypeName="" TableName="快递滞留表" 
         Select="new (快递单号, 用户名, 用户手机号码, 滞留时长, 超时费用)">
        </asp:LinqDataSource>

        <tr>
            <td align="right">
                <asp:Button ID="Button2" runat="server" Text="支付" onclick="Button2_Click" CssClass="btn"/>
                    </td>
        </tr>

    </table>
    </center>
     </div>
</div>
</asp:Content>

