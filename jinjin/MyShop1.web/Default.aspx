<%@ Page Title="网站首页" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/main.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        body {
          font-family: Arial, sans-serif;
          text-align: center;
        }
        /*h1 {
          margin-top: 60px;
        }*/
        .cok{
            margin-top:45px;
            margin-left:-600px;
        }
        .cokl{
            margin-top:-50px;
            margin-left:600px;
        }
        .locker-container {
          display: flex;
          flex-wrap: wrap;
          justify-content: center;
          margin-top: 20px;
        }
        .locker {
          width: 70px;
          height: 70px;
          border: 1px solid #000;
          margin: 5px;
          display: flex;
          justify-content: center;
          align-items: center;
          font-size: 20px;
          cursor: pointer;
        }
        .lockerl {
          width: 95px;
          height: 70px;
          border: 1px solid #000;
          margin: 5px;
          display: flex;
          justify-content: center;
          align-items: center;
          font-size: 20px;
          cursor: pointer;
        }
        .lockerll {
          width: 110px;
          height: 116px;
          border: 1px solid #000;
          margin: 5px;
          display: flex;
          justify-content: center;
          align-items: center;
          font-size: 20px;
          cursor: pointer;
        }
        .lockerlll {
          width: 120px;
          height: 197px;
          border: 1px solid #000;
          margin: 5px;
          display: flex;
          justify-content: center;
          align-items: center;
          font-size: 20px;
          cursor: pointer;
        }
    </style>
    <div class="newcontain">
  <div class="listr  ">
  <div class="BiaoTi"><h2> 
      智能快递柜 </h2></div>
    <%--<h1>智能快递柜</h1>--%>
    <div class="locker-container">
        <div class="row" style="text-align: center">
              <div class="locker" id="locker1">
                  <asp:Label ID="Label1" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="A101"></asp:Label>
              </div>
              <div class="locker" id="locker2">
                  <asp:Label ID="Label2" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="A102"></asp:Label>
              </div>
              <div class="locker" id="locker3">
                  <asp:Label ID="Label3" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="A103"></asp:Label>
              </div>
              <div class="locker" id="locker4">
                  <asp:Label ID="Label4" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="A104"></asp:Label>
              </div>
              <div class="locker" id="locker5">
                  <asp:Label ID="Label5" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="A105"></asp:Label>
              </div>
              <div class="locker" id="locker6">
                  <asp:Label ID="Label6" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="A106"></asp:Label>
              </div>
              <div class="locker" id="locker7">
                  <asp:Label ID="Label7" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="A107"></asp:Label>
              </div>
              <div class="locker" id="locker8">
                  <asp:Label ID="Label8" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="A108"></asp:Label>
              </div>
          </div>

          <div class="row">
              <div class="lockerl" id="locker9">
                  <asp:Label ID="Label9" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="B101"></asp:Label>
              </div>
              <div class="lockerl" id="locker10">
                  <asp:Label ID="Label10" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="B102"></asp:Label>
              </div>
              <div class="lockerl" id="locker11">
                  <asp:Label ID="Label11" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="B103"></asp:Label>
              </div>
              <div class="lockerl" id="locker12">
                  <asp:Label ID="Label12" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="B104"></asp:Label>
              </div>
              <div class="lockerl" id="locker13">
                  <asp:Label ID="Label13" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="B105"></asp:Label>
              </div>
              <div class="lockerl" id="locker14">
                  <asp:Label ID="Label14" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="B106"></asp:Label>
              </div>
              <div class="lockerl" id="locker15">
                  <asp:Label ID="Label15" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="B107"></asp:Label>
              </div>
              <div class="lockerl" id="locker16">
                  <asp:Label ID="Label16" Width="100px" Height="100%" runat="server" ForeColor="Black" Text="B108"></asp:Label>
              </div>
          </div>

        <div class="row">
            <div class="lockerll" id="locker17">
                <asp:Label ID="Label17" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="C101"></asp:Label>
            </div>
            <div class="lockerll" id="locker18">
                <asp:Label ID="Label18" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="C102"></asp:Label>
            </div>
            <div class="lockerll" id="locker19">
                <asp:Label ID="Label19" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="C103"></asp:Label>
            </div>
            <div class="lockerll" id="locker20">
                <asp:Label ID="Label20" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="C104"></asp:Label>
            </div>
            <div class="lockerll" id="locker21">
                <asp:Label ID="Label21" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="C105"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="lockerlll" id="locker22">
                <asp:Label ID="Label22" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="D101"></asp:Label>
            </div>
            <div class="lockerlll" id="locker23">
                <asp:Label ID="Label23" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="D102"></asp:Label>
            </div>
            <div class="lockerlll" id="locker24">
                <asp:Label ID="Label24" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="D103"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="lockerlll" id="locker25">
                <asp:Label ID="Label25" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="D104"></asp:Label>
            </div>
            <div class="lockerlll" id="locker26">
                <asp:Label ID="Label26" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="D105"></asp:Label>
            </div>
            <div class="lockerlll" id="locker27">
                <asp:Label ID="Label27" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="D106"></asp:Label>
            </div>
        </div>

      <%--<div class="row">
            <div class="lockerlll" id="locker28">
                <asp:Label ID="Label28" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="D107"></asp:Label>
            </div>
            <div class="lockerlll" id="locker29">
                <asp:Label ID="Label29" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d108"></asp:Label>
            </div>
            <div class="lockerlll" id="locker30">
                <asp:Label ID="Label30" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d109"></asp:Label>
            </div>
        </div>--%>

          <%--<div class="row">
            <div class="lockerlll" id="locker31">
                <asp:Label ID="Label31" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="D110"></asp:Label>
            </div>
            <div class="lockerlll" id="locker32">
                <asp:Label ID="Label32" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="D111"></asp:Label>
            </div>
            <div class="lockerlll" id="locker33">
                <asp:Label ID="Label33" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="D112"></asp:Label>
            </div>
        </div>--%>

      <div class="row">
            <div class="lockerll" id="locker34">
                <asp:Label ID="Label34" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="C106"></asp:Label>
            </div>
            <div class="lockerll" id="locker35">
                <asp:Label ID="Label35" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="C107"></asp:Label>
            </div>
            <div class="lockerll" id="locker36">
                <asp:Label ID="Label36" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="C108"></asp:Label>
            </div>
            <div class="lockerll" id="locker37">
                <asp:Label ID="Label37" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="C109"></asp:Label>
            </div>
            <div class="lockerll" id="locker38">
                <asp:Label ID="Label38" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="C110"></asp:Label>
            </div>
        </div>

          <div class="row">
            <div class="lockerl" id="locker39">
                <asp:Label ID="Label39" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="B109"></asp:Label>
            </div>
            <div class="lockerl" id="locker40">
                <asp:Label ID="Label40" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="B110"></asp:Label>
            </div>
            <div class="lockerl" id="locker41">
                <asp:Label ID="Label41" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="B111"></asp:Label>
            </div>
            <div class="lockerl" id="locker42">
                <asp:Label ID="Label42" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="B112"></asp:Label>
            </div>
            <div class="lockerl" id="locker43">
                <asp:Label ID="Label43" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="B113"></asp:Label>
            </div>
            <div class="lockerl" id="locker44">
                <asp:Label ID="Label44" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="B114"></asp:Label>
            </div>
            <div class="lockerl" id="locker45">
                <asp:Label ID="Label45" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="B115"></asp:Label>
            </div>
            <div class="lockerl" id="locker46">
                <asp:Label ID="Label46" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="B116"></asp:Label>
            </div>
        </div>

          <div class="row">
            <div class="locker" id="locker47">
                <asp:Label ID="Label47" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="A109"></asp:Label>
            </div>
            <div class="locker" id="locker48">
                <asp:Label ID="Label48" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="A110"></asp:Label>
            </div>
            <div class="locker" id="locker49">
                <asp:Label ID="Label49" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="A111"></asp:Label>
            </div>
            <div class="locker" id="locker50">
                <asp:Label ID="Label50" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="A112"></asp:Label>
            </div>
            <div class="locker" id="locker51">
                <asp:Label ID="Label51" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="A113"></asp:Label>
            </div>
            <div class="locker" id="locker52">
                <asp:Label ID="Label52" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="A114"></asp:Label>
            </div>
            <div class="locker" id="locker53">
                <asp:Label ID="Label53" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="A115"></asp:Label>
            </div>
            <div class="locker" id="locker54">
                <asp:Label ID="Label54" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="A116"></asp:Label>
            </div>
        </div>
    
    </div>

      <div class="cok">
        <asp:TextBox ID="txtqcode" runat="server" placeholder="请输入取件码" Width="230px" Height="45px"></asp:TextBox>
        <asp:Button runat="server" Text="确定"  Width="117px" onclick="Unnamed_Click" Height="50px" CssClass="btn"/>
    </div>
        <div class="cokl">
        <asp:TextBox ID="txtjcode" runat="server" placeholder="请输入寄件码" Width="230px" Height="45px"></asp:TextBox>
        <asp:Button runat="server" Text="确定"  Width="117px" onclick="Unnamed_Click1" Height="50px" CssClass="btn"/>
    </div>

     </div>
</div>
</asp:Content>
