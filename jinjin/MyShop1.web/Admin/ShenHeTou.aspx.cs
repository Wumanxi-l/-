using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ShenHe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    protected void btnSubit_Click(object sender, EventArgs e)
    {
        //foreach (GridViewRow gvRow in GridView1.Rows)
        //{
        //    string  = "update 快递信息审核表 set status='已审核' where 快递单号='";
        //}

        Response.Write("<script>javascript:alert('审核成功');</script>");
    }
}