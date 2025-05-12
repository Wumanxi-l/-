<%@ Page Title="智能柜类型" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="8-3.aspx.cs" Inherits="_8_3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      智能柜类型 </h2></div>
      <center>
    <table class="myTab" cellpadding="4" cellspacing="1">
        <asp:GridView ID="gvexpress" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="Idsexpress"
         DataKeyNames="智能柜ID" PageSize="6" OnRowDataBound="gvexpress_RowDataBound" Height ="302px" Width="344px">
        <Columns>
            <asp:BoundField DataField="智能柜ID" HeaderText="智能柜ID" InsertVisible="False" ReadOnly="True" SortExpression="智能柜ID" />
            <asp:BoundField DataField="智能柜类型" HeaderText="智能柜类型" SortExpression="智能柜类型" />
            <asp:BoundField DataField="智能柜规格" HeaderText="智能柜规格" SortExpression="智能柜规格" />
            <asp:BoundField DataField="可用空数量" HeaderText="可用空数量" SortExpression="可用空数量" />
        </Columns>
    </asp:GridView>

    <asp:LinqDataSource ID="Idsexpress" runat="server" ContextTypeName="MyShop1.DAL.MyShop1DataContext" EntityTypeName="" TableName="快递柜表">
    </asp:LinqDataSource>
        <tr><td class="tdcenter"><a id="">当前页为第一页，共一页</a></td></tr>
    </table>
    </center>
     </div>
</div>
</asp:Content>

