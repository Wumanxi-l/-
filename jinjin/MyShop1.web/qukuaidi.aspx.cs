using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyShop.BLL;

public partial class qukuaidi : System.Web.UI.Page
{
    QujianService quSrv = new QujianService();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerId"] == null)  //用户未登录
        {
            Response.Redirect("~/Login.aspx");
        }
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //调用 QujianService类中的Insert()方法插入新订单记录
        quSrv.Insert(TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox3.Text.Trim());
        Response.Redirect("~/Default.aspx");
        Response.Write("<script>javascript:alert('验证成功，请取件');</script>");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}