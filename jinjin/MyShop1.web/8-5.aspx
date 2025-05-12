<%@ Page Title="智能柜类型管理" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="8-5.aspx.cs" Inherits="_8_5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      智能柜类型管理 </h2></div>
      <center>
    <table class="myTab" cellpadding="4" cellspacing="1">

        <asp:GridView ID="gvexpress" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="Idsexpress" 
            DataKeyNames="智能柜ID" PageSize="6" Height="310px" Width="453px">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        <asp:CheckBox ID="chkALL" runat="server" AutoPostBack="True" Text="全选" OnCheckedChanged="chkALL_CheckedChanged" />
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkitem" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField HeaderText="智能柜ID"  InsertVisible="False" ReadOnly="True" DataField="智能柜ID" SortExpression="智能柜ID" />
                <asp:BoundField DataField="智能柜类型" HeaderText="智能柜类型" SortExpression="智能柜类型" />
                <asp:BoundField DataField="智能柜规格" HeaderText="智能柜规格" SortExpression="智能柜规格" />
                <asp:BoundField DataField="可用空数量" HeaderText="可用空数量" SortExpression="可用空数量" />
                <asp:CommandField HeaderText="编辑" ShowEditButton="True" />
            </Columns>
        </asp:GridView>

        <asp:LinqDataSource ID="Idsexpress" runat="server" ContextTypeName="MyShop1.DAL.MyShop1DataContext" EnableUpdate="True" EntityTypeName="" TableName="快递柜表">
        </asp:LinqDataSource>

        <asp:Button ID="btnSubit" runat="server" Text="确定" OnClick="btnSubit_Click" CssClass="btn" />
        <asp:Label ID="lblID" runat="server"></asp:Label>
        
    </table>
    </center>
     </div>
</div>
</asp:Content>

