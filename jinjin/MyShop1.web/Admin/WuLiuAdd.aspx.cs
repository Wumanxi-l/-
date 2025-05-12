using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyShop.BLL;

public partial class Admin_WuLiuAdd : System.Web.UI.Page
{
    WuLiuService wuliuSrv = new WuLiuService();
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        //调用WuLiuService类中的Insert()方法插入新快递物记录
        wuliuSrv.Insert(TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox3.Text.Trim(),
            TextBox4.Text.Trim(),TextBox5.Text.Trim(),TextBox6.Text.Trim());
        Response.Write("<script>javascript:alert('添加成功！');</script>");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
    }
}