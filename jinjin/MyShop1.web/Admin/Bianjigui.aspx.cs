using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Bianjigui : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubit_Click(object sender, EventArgs e)
    {
        
    }

    protected void chkALL_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox chkAll = (CheckBox)sender;
        foreach (GridViewRow gvRow in gvexpress.Rows)
        {
            //获取GridView数据行中chkItem对象
            CheckBox chkItem = (CheckBox)gvRow.FindControl("chkItem");
            chkItem.Checked = chkAll.Checked;
        }
    }

    protected void btnSubit_Click1(object sender, EventArgs e)
    {
        lblID.Text = "您选择的智能柜类型为：";
        foreach (GridViewRow gvRow in gvexpress.Rows)
        {
            CheckBox chkItem = (CheckBox)gvRow.FindControl("chkItem");
            if (chkItem.Checked)
            {
                lblID.Text += gvRow.Cells[1].Text + "、";
            }
        }
        Response.Write("<script>javascript:alert('编辑成功');</script>");
    }
}