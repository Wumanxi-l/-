<%@ Page Title="智能柜使用次数结算" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CishuSum.aspx.cs" Inherits="CishuSum" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      智能柜类型管理 </h2></div>
      <center>
    <table class="myTab" cellpadding="4" cellspacing="1">--%>
   
    <asp:Panel ID="pnlSum" runat="server">
        <asp:GridView ID="gvSum" runat="server" AutoGenerateColumns="False" Height="243px" Width="392px">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="智能柜类型" HeaderText="智能柜类型" />
                <%--<asp:BoundField DataField="使用次数" HeaderText="使用次数" />--%>
                <asp:TemplateField HeaderText="使用次数">
                    <ItemTemplate>
                        <%--<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>--%>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <%--<br />--%>
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label><%--<br />--%>
    <asp:Label ID="lblHint" runat="server" ForeColor="Green"></asp:Label><%--<br />--%>
    总次数：<asp:Label ID="lblSum" runat="server"></asp:Label>
    &nbsp;
    <asp:Button ID="btnSettle" runat="server" Text="结算" onclick="btnSettle_Click1" CssClass="btn" />
    </asp:Panel>
   
    <%--</table>
    </center>
     </div>
</div>--%>
</asp:Content>

