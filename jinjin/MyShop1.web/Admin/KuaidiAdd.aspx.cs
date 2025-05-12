using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyShop.BLL;

public partial class Admin_KuaidiAdd : System.Web.UI.Page
{
    ToufanService toufanSrv = new ToufanService();
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //调用ToufanService类中的Insert()方法插入新用户记录
        toufanSrv.Insert(TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox3.Text.Trim(),
            TextBox4.Text.Trim(), DropDownList1.Text.Trim(), Calendar1.SelectedDate.ToShortDateString());
        Response.Write("<script>javascript:alert('添加成功！');</script>");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }
}