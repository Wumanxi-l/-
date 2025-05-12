using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_KDZhiLiu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void chkALL_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox chkAll = (CheckBox)sender;
        foreach (GridViewRow gvRow in GridView1.Rows)
        {
            //获取GridView数据行中chkItem对象
            CheckBox chkItem = (CheckBox)gvRow.FindControl("chkItem");
            chkItem.Checked = chkAll.Checked;
        }
    }

    protected void btnSubit_Click(object sender, EventArgs e)
    {
        lblID.Text = "您选择的快递单号为：";
        foreach (GridViewRow gvRow in GridView1.Rows)
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