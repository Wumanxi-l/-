<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        body {
          font-family: Arial, sans-serif;
          text-align: center;
        }

        h1 {
          margin-top: 60px;
        }
        .cok{
            margin-top:45px;
            margin-left:-745px;
        }
        .cokl{
            margin-top:-50px;
            margin-left:745px;
        }

        .locker-container {
          display: flex;
          flex-wrap: wrap;
          justify-content: center;
          margin-top: 20px;
        }

        .locker {
          width: 80px;
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
          width: 105px;
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
          width: 120px;
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
          width: 130px;
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
    <h1>智能快递柜</h1>
    <div class="locker-container">
        <div class="row" style="text-align: center">
            <div class="locker" id="locker1">
                <asp:Label ID="Label1" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a101"></asp:Label>
            </div>
            <div class="locker" id="locker2">
                <asp:Label ID="Label2" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a102"></asp:Label>
            </div>
            <div class="locker" id="locker3">
                <asp:Label ID="Label3" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a103"></asp:Label>
            </div>
            <div class="locker" id="locker4">
                <asp:Label ID="Label4" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a104"></asp:Label>
            </div>
            <div class="locker" id="locker5">
                <asp:Label ID="Label5" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a105"></asp:Label>
            </div>
            <div class="locker" id="locker6">
                <asp:Label ID="Label6" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a106"></asp:Label>
            </div>
            <div class="locker" id="locker7">
                <asp:Label ID="Label7" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a107"></asp:Label>
            </div>
            <div class="locker" id="locker8">
                <asp:Label ID="Label8" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a108"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="lockerl" id="locker9">
                <asp:Label ID="Label9" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b101"></asp:Label>
            </div>
            <div class="lockerl" id="locker10">
                <asp:Label ID="Label10" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b102"></asp:Label>
            </div>
            <div class="lockerl" id="locker11">
                <asp:Label ID="Label11" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b103"></asp:Label>
            </div>
            <div class="lockerl" id="locker12">
                <asp:Label ID="Label12" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b104"></asp:Label>
            </div>
            <div class="lockerl" id="locker13">
                <asp:Label ID="Label13" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b105"></asp:Label>
            </div>
            <div class="lockerl" id="locker14">
                <asp:Label ID="Label14" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b106"></asp:Label>
            </div>
            <div class="lockerl" id="locker15">
                <asp:Label ID="Label15" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b107"></asp:Label>
            </div>
            <div class="lockerl" id="locker16">
                <asp:Label ID="Label16" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b108"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="lockerll" id="locker17">
                <asp:Label ID="Label17" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="c101"></asp:Label>
            </div>
            <div class="lockerll" id="locker18">
                <asp:Label ID="Label18" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="c102"></asp:Label>
            </div>
            <div class="lockerll" id="locker19">
                <asp:Label ID="Label19" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="c103"></asp:Label>
            </div>
            <div class="lockerll" id="locker20">
                <asp:Label ID="Label20" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="c104"></asp:Label>
            </div>
            <div class="lockerll" id="locker21">
                <asp:Label ID="Label21" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="c105"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="lockerlll" id="locker22">
                <asp:Label ID="Label22" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d101"></asp:Label>
            </div>
            <div class="lockerlll" id="locker23">
                <asp:Label ID="Label23" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d102"></asp:Label>
            </div>
            <div class="lockerlll" id="locker24">
                <asp:Label ID="Label24" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d103"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="lockerlll" id="locker25">
                <asp:Label ID="Label25" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d104"></asp:Label>
            </div>
            <div class="lockerlll" id="locker26">
                <asp:Label ID="Label26" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d105"></asp:Label>
            </div>
            <div class="lockerlll" id="locker27">
                <asp:Label ID="Label27" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d106"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="lockerlll" id="locker28">
                <asp:Label ID="Label28" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d107"></asp:Label>
            </div>
            <div class="lockerlll" id="locker29">
                <asp:Label ID="Label29" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d108"></asp:Label>
            </div>
            <div class="lockerlll" id="locker30">
                <asp:Label ID="Label30" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d109"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="lockerlll" id="locker31">
                <asp:Label ID="Label31" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d110"></asp:Label>
            </div>
            <div class="lockerlll" id="locker32">
                <asp:Label ID="Label32" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d111"></asp:Label>
            </div>
            <div class="lockerlll" id="locker33">
                <asp:Label ID="Label33" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="d112"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="lockerll" id="locker34">
                <asp:Label ID="Label34" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="c106"></asp:Label>
            </div>
            <div class="lockerll" id="locker35">
                <asp:Label ID="Label35" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="c107"></asp:Label>
            </div>
            <div class="lockerll" id="locker36">
                <asp:Label ID="Label36" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="c108"></asp:Label>
            </div>
            <div class="lockerll" id="locker37">
                <asp:Label ID="Label37" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="c109"></asp:Label>
            </div>
            <div class="lockerll" id="locker38">
                <asp:Label ID="Label38" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="c110"></asp:Label>
            </div>
        </div>


        <div class="row">
            <div class="lockerl" id="locker39">
                <asp:Label ID="Label39" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b109"></asp:Label>
            </div>
            <div class="lockerl" id="locker40">
                <asp:Label ID="Label40" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b110"></asp:Label>
            </div>
            <div class="lockerl" id="locker41">
                <asp:Label ID="Label41" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b111"></asp:Label>
            </div>
            <div class="lockerl" id="locker42">
                <asp:Label ID="Label42" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b112"></asp:Label>
            </div>
            <div class="lockerl" id="locker43">
                <asp:Label ID="Label43" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b113"></asp:Label>
            </div>
            <div class="lockerl" id="locker44">
                <asp:Label ID="Label44" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b114"></asp:Label>
            </div>
            <div class="lockerl" id="locker45">
                <asp:Label ID="Label45" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b115"></asp:Label>
            </div>
            <div class="lockerl" id="locker46">
                <asp:Label ID="Label46" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="b116"></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="locker" id="locker47">
                <asp:Label ID="Label47" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a109"></asp:Label>
            </div>
            <div class="locker" id="locker48">
                <asp:Label ID="Label48" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a110"></asp:Label>
            </div>
            <div class="locker" id="locker49">
                <asp:Label ID="Label49" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a111"></asp:Label>
            </div>
            <div class="locker" id="locker50">
                <asp:Label ID="Label50" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a112"></asp:Label>
            </div>
            <div class="locker" id="locker51">
                <asp:Label ID="Label51" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a113"></asp:Label>
            </div>
            <div class="locker" id="locker52">
                <asp:Label ID="Label52" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a114"></asp:Label>
            </div>
            <div class="locker" id="locker53">
                <asp:Label ID="Label53" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a115"></asp:Label>
            </div>
            <div class="locker" id="locker54">
                <asp:Label ID="Label54" Width="100px" Height="100%"  runat="server" ForeColor="Black" Text="a116"></asp:Label>
            </div>
        </div>
        </div>


    <div class="cok">
        <asp:TextBox ID="txtqcode" runat="server" placeholder="请输入取件码" Width="230px" Height="45px"></asp:TextBox>
        <asp:Button runat="server" Text="确定"  Width="117px" OnClick="Unnamed1_Click" Height="50px" />
    </div>
        <div class="cokl">
        <asp:TextBox ID="txtjcode" runat="server" placeholder="请输入存放码" Width="230px" Height="45px"></asp:TextBox>
        <asp:Button runat="server" Text="确定"  Width="117px" OnClick="Unnamed2_Click" Height="50px" />
    </div>
</asp:Content>

