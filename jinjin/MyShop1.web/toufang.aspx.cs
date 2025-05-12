using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyShop.BLL;

public partial class toufang : System.Web.UI.Page
{
    ToufanService toufanSrv = new ToufanService();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustomerId"] == null)  //用户未登录
        {
            Response.Redirect("~/Login.aspx");
        }
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        //if (Page.IsValid)
        //{
            //调用CustomerService类中的IsNameExist()方法判断用户名是否重名
            if (toufanSrv.IsNameExist(TextBox1.Text.Trim()))
            {
                lblMsg.Text = "快递单号已存在！";
            }
        //}

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //调用ToufanService类中的Insert()方法插入新用户记录
        toufanSrv.Insert(TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox3.Text.Trim(),
            TextBox4.Text.Trim(),DropDownList1.Text.Trim(), Calendar1.SelectedDate.ToShortDateString());

        //获取cabinetId
        CabinetService cabinetService = new CabinetService();
        string cabinetId = cabinetService.queryNoUse(DropDownList1.Text.Trim());
        if (cabinetId != null)
        {
            Response.Redirect("~/Qujianma.aspx?cabinetId=" + cabinetId);
        }
        //Response.Redirect("~/Qujianma.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }
}