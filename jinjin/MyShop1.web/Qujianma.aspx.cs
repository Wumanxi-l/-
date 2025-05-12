using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyShop.BLL;
using MyShop1.DAL;

public partial class Qujianma : System.Web.UI.Page
{
    //ToufanService toufanSrv = new ToufanService();
    QujianService qujianSrv = new QujianService();
    CabinetService cabinetService = new CabinetService();
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        TextBox1.Text = Request.QueryString["cabinetId"];
        Random random = new Random();
        int code1 = random.Next(100000, 999999);
        int code2 = random.Next(100000, 999999);
        TextBox2.Text = code1.ToString();
        TextBox3.Text = code2.ToString();

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Response.Write("<script>javascript:alert('取件码已通过短信方式发送到用户手机上了');</script>");

        //调用QujianService类中的Insert()方法插入新用户记录
        qujianSrv.Insert(TextBox1.Text.Trim(), TextBox2.Text.Trim(),TextBox3.Text.Trim());

        Response.Redirect("~/TfanDefault.aspx");
    }
}