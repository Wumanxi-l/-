using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyShop.BLL;
using MyShop1.DAL;

public partial class kuidi_add : System.Web.UI.Page
{
    KuaidiService kuaidiSrv = new KuaidiService();
    
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
        //调用KuaidiService类中的Insert()方法插入新用户记录
        kuaidiSrv.Insert(TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox3.Text.Trim(),
            DropDownList1.Text.Trim(), TextBox4.Text.Trim(), Calendar1.SelectedDate.ToShortDateString());

        //获取cabinetId
        CabinetService cabinetService = new CabinetService();
        string cabinetId = cabinetService.queryNoUse(DropDownList1.Text.Trim());
        if (cabinetId != null)
        {
            Response.Redirect("~/Jijianma.aspx?cabinetId=" + cabinetId);
        }
        

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }
}