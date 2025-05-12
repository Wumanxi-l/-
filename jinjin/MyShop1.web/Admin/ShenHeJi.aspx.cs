using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin_ShenHeJi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    protected void btnSubit_Click(object sender, EventArgs e)
    {
        //int n = GridView1.CurrentRow.Index;//当前行索引
        //GridView1.Rows[n].Cells["Column7"].Value = "已审核";

        Response.Write("<script>javascript:alert('审核成功');</script>");
    }
}