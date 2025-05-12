<%@ Page Title="物流记录" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="WuLiu.aspx.cs" Inherits="Admin_WuLiu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
    <%--<link href="css/Maste.css" rel="stylesheet" type="text/css" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      物流记录 快递单号：
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      <asp:Button ID="Button1"
          runat="server" Text="查询" onclick="Button1_Click" />
                      </h2></div>
      <center>
    <table class="myTab" cellpadding="4" cellspacing="1">
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="Idsnumber">
         <Columns>
             <asp:BoundField DataField="快递单号" HeaderText="快递单号" />
             <asp:BoundField DataField="收货人" HeaderText="收货人" />
             <asp:BoundField DataField="收货地址" HeaderText="收货地址" />
             <asp:BoundField DataField="寄件人" HeaderText="寄件人" />
             <asp:BoundField DataField="发货地址" HeaderText="发货地址" />
             <asp:BoundField DataField="物流信息" HeaderText="物流信息" />
         </Columns>
     </asp:GridView>

     <asp:LinqDataSource ID="Idsnumber" runat="server" ContextTypeName="MyShop1.DAL.MyShop1DataContext" EntityTypeName="" TableName="快递物流信息" 
         Select="new (快递单号, 收货人, 收货地址, 寄件人, 发货地址, 物流信息)">
        </asp:LinqDataSource>

    </table>
    </center>
     </div>
</div>
</asp:Content>

