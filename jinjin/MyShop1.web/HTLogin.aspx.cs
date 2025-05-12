using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyShop.BLL;

public partial class HTLogin : System.Web.UI.Page
{
    CustomerService customerSrv = new CustomerService();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Login.aspx页面传递过来的查询字符串变量name值非空
            if (Request.QueryString["Name"] != null)
            {
                TextBox1.Text = Request.QueryString["Name"];
                lblMsg.Text = "注册成功，请登录!";
            }
        }
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            //调用CustomerService类中的CheckLogin()方法检查输入的用户名和密码是否正确
            int customerId = customerSrv.CheckLogin(TextBox1.Text.Trim(), TextBox2.Text.Trim());
            if (customerId > 0)   //用户名和密码正确
            {
                Session.Clear();   //清理Session中保存的内容        
                Session["CustomerId"] = customerId;
                Session["Name"] = TextBox1.Text;
                Response.Redirect("~/Admin/Index.aspx");

            }
            else  //用户名或密码错误
            {
                lblMsg.Text = "用户名或密码错误！";
            }
        }
    }
}