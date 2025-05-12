using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyShop.BLL;

public partial class Jijianma : System.Web.UI.Page
{
    //KuaidiService kuaidiSrv = new KuaidiService();
    JijianService JijianSrv = new JijianService();
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        TextBox1.Text = Request.QueryString["cabinetId"];
        Random random = new Random();
        int code = random.Next(100000,999999);
        txtqcode.Text = code.ToString();

        //调用JijianService类中的Insert()方法插入新用户记录
        JijianSrv.Insert(TextBox1.Text.Trim(), txtqcode.Text.Trim());
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //kuaidiSrv.Insert(txtqcode.Text.Trim());
        Response.Write("<script>javascript:alert('已获取寄件码，请尽快寄件');</script>");
        Response.Redirect("~/Default.aspx");

        //调用JijianService类中的Insert()方法插入新用户记录
        //JijianSrv.Insert(TextBox1.Text.Trim(), txtqcode.Text.Trim());
    }
}