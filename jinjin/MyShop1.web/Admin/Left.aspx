<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Left.aspx.cs" Inherits="Admin_Left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link type="text/css" rel="stylesheet" href="css/style.css" />
<script type="text/javascript" src="js/jquery-1.8.3.min.js"></script>
 <script type="text/javascript" src="js/menu.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="left_menu">
				<ul id="nav_dot">
                     
         <li>
          <h4 class="M1"><span></span>快递信息审核管理</h4>
           <div class="list-item none">
            <a href='KuaidiAdd.aspx' target='right'>添加快递信息</a>
            <a href='ShenHeTou.aspx' target='right'>投放快递信息审核</a>
               <a href='ShenHeJi.aspx' target='right'>寄件信息审核</a>
               <a href='KDZhiLiu.aspx' target='right'>编辑快递滞留信息</a>
          </div>
        </li> 
                       
         <li>
          <h4 class="M1"><span></span>智能柜类型管理</h4>
           <div class="list-item none">
            <a href='Bianjigui.aspx' target='right'>编辑智能柜类型</a>
          </div>
        </li> 

         <li>
          <h4 class="M1"><span></span>物流记录管理</h4>
           <div class="list-item none">
            <a href='WuLiuAdd.aspx' target='right'>添加快递物流记录</a>
          </div>
        </li> 

         <li>
          <h4 class="M1"><span></span>会员信息管理</h4>
           <div class="list-item none">
            <a href='HuiYuanGL.aspx' target='right'>会员信息管理</a>
          </div>
        </li> 

         <%--<li>
          <h4 class="M1"><span></span>联系我们</h4>
           <div class="list-item none">
            <a href='LianXI.aspx' target='right'>联系我们</a>
          </div>
        </li>--%> 
              </ul>
		</div>
        <script type="text/javascript">navList(12);</script>
    </form>
</body>
</html>
