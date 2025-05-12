using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyShop.BLL;

public partial class ZhiLiu : System.Web.UI.Page
{
    ZhiLiuService zhiliuSrv = new ZhiLiuService();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerId"] == null)  //用户未登录
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!IsPostBack)
        {
            Bind();  //调用自定义方法Bind()
        }
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    // 根据从MasterPage.master传递过来的SearchText值，模糊查询与SearchText值匹配的所有商品信息并显示
    protected void Bind()
    {
        GridView1.DataSourceID = null; // 移除DataSourceID的定义
        if (Request.QueryString["SearchText"] != null)
        {
            string strSearchText = Request.QueryString["SearchText"].ToString();
            GridView1.DataSource = zhiliuSrv.GetProductBySearchText(strSearchText);
            GridView1.DataBind();
            //GridView1.DataSource = null; // 移除DataSource的定义
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //如果搜索框不为空，以查询字符串形式传递搜索文本到WuLiu.aspx
        string strQuery = "";
        if (TextBox1.Text.Trim() == "")
        {
            strQuery = "";
        }
        else
        {
            strQuery = "?SearchText=" + TextBox1.Text.Trim();
        }
        Response.Redirect("~/ZhiLiu.aspx" + strQuery);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<script>javascript:alert('支付成功');</script>");
    }
}
