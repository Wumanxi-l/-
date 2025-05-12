<%@ Page Title="联系我们" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="lianxi.aspx.cs" Inherits="lianxi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="newcontain">
 
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      联系我们 </h2></div>
      <center>
    <table class="myTab" cellpadding="4" cellspacing="1">
        
        <tr>
                    <td align="right" class="style1">
                        【客服电话】：</td>
                    <td style="text-align: left">
                        95333 12536452896
                        <%--<asp:TextBox ID="TextBox1" runat="server" CssClass="txtcss"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="TextBox1" ErrorMessage="用户名不能为空">用户名不能为空</asp:RequiredFieldValidator>--%>
                    </td>
                </tr>
        <tr>
                    <td align="right" class="style1">
                        【工作时间】：</td>
                    <td style="text-align: left">
                        8：00—21：00
                    </td>
                </tr>
        <%--<tr>
                    <td align="right" class="style1">
                        公司简介：</td>
                    <td style="text-align: left">
                        该智能快递柜致力于以智能设备为切入点构建24h无人自助的物联网解决方案，
                        形成智能软硬件服务、末端服务、增值服务、广告服务、电商服务的生态平台，链接不同群体共同互动创新，实现共赢。
                        以技术为驱动，挖掘和满足多场景定制化需求，覆盖快递柜、智能微仓、存包柜、政务柜等多种智能末端产品，以行业独角兽势能不断延伸，深耕最后一公里的多元化服务。
                    </td>
                </tr>--%>

    </table>
    </center>
     </div>
</div>
</asp:Content>

