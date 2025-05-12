using CabinetXt.BLL;
using CabinetXt.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CDefault : System.Web.UI.Page
{
    SendService se = new SendService();
    cabinetService cab = new cabinetService();
    protected void Page_Load(object sender, EventArgs e)
    {
        //获取所有的使用的快递柜
        List<Cabinet> cabinets = cab.queryAllUser();

        foreach (Cabinet c in cabinets)
        {
            switch (c.cabinet_id)
            {
                case "a101":
                    Label1.BackColor = System.Drawing.Color.Red;
                    break;
                case "a102":
                    Label2.BackColor = System.Drawing.Color.Red;
                    break;
                case "a103":
                    Label3.BackColor = System.Drawing.Color.Red;
                    break;
                case "a104":
                    Label4.BackColor = System.Drawing.Color.Red;
                    break;
                case "a105":
                    Label5.BackColor = System.Drawing.Color.Red;
                    break;
                case "a106":
                    Label6.BackColor = System.Drawing.Color.Red;
                    break;
                case "a107":
                    Label7.BackColor = System.Drawing.Color.Red;
                    break;
                case "a108":
                    Label8.BackColor = System.Drawing.Color.Red;
                    break;
                case "b101":
                    Label9.BackColor = System.Drawing.Color.Red;
                    break;
                case "b102":
                    Label10.BackColor = System.Drawing.Color.Red;
                    break;

                case "b103":
                    Label11.BackColor = System.Drawing.Color.Red;
                    break;

                case "b104":
                    Label12.BackColor = System.Drawing.Color.Red;
                    break;
                case "b105":
                    Label13.BackColor = System.Drawing.Color.Red;
                    break;
                case "b106":
                    Label14.BackColor = System.Drawing.Color.Red;
                    break;
                case "b107":
                    Label15.BackColor = System.Drawing.Color.Red;
                    break;
                case "b108":
                    Label16.BackColor = System.Drawing.Color.Red;
                    break;
                case "c101":
                    Label17.BackColor = System.Drawing.Color.Red;
                    break;
                case "c102":
                    Label18.BackColor = System.Drawing.Color.Red;
                    break;
                case "c103":
                    Label19.BackColor = System.Drawing.Color.Red;
                    break;
                case "c104":
                    Label20.BackColor = System.Drawing.Color.Red;
                    break;
                case "c105":
                    Label21.BackColor = System.Drawing.Color.Red;
                    break;
                case "d101":
                    Label22.BackColor = System.Drawing.Color.Red;
                    break;
                case "d102":
                    Label23.BackColor = System.Drawing.Color.Red;
                    break;
                case "d103":
                    Label24.BackColor = System.Drawing.Color.Red;
                    break;
                case "d104":
                    Label25.BackColor = System.Drawing.Color.Red;
                    break;
                case "d105":
                    Label26.BackColor = System.Drawing.Color.Red;
                    break;
                case "d106":
                    Label27.BackColor = System.Drawing.Color.Red;
                    break;
                case "d107":
                    Label28.BackColor = System.Drawing.Color.Red;
                    break;
                case "d108":
                    Label29.BackColor = System.Drawing.Color.Red;
                    break;
                case "d109":
                    Label30.BackColor = System.Drawing.Color.Red;
                    break;
                case "d110":
                    Label31.BackColor = System.Drawing.Color.Red;
                    break;
                case "d111":
                    Label32.BackColor = System.Drawing.Color.Red;
                    break;
                case "d112":
                    Label33.BackColor = System.Drawing.Color.Red;
                    break;
                case "c106":
                    Label34.BackColor = System.Drawing.Color.Red;
                    break;
                case "c107":
                    Label35.BackColor = System.Drawing.Color.Red;
                    break;
                case "c108":
                    Label36.BackColor = System.Drawing.Color.Red;
                    break;
                case "c109":
                    Label37.BackColor = System.Drawing.Color.Red;
                    break;
                case "c110":
                    Label38.BackColor = System.Drawing.Color.Red;
                    break;
                case "b109":
                    Label39.BackColor = System.Drawing.Color.Red;
                    break;
                case "b110":
                    Label40.BackColor = System.Drawing.Color.Red;
                    break;
                case "b111":
                    Label41.BackColor = System.Drawing.Color.Red;
                    break;
                case "b112":
                    Label42.BackColor = System.Drawing.Color.Red;
                    break;
                case "b113":
                    Label43.BackColor = System.Drawing.Color.Red;
                    break;
                case "b114":
                    Label44.BackColor = System.Drawing.Color.Red;
                    break;
                case "b115":
                    Label45.BackColor = System.Drawing.Color.Red;
                    break;
                case "b116":
                    Label46.BackColor = System.Drawing.Color.Red;
                    break;
                case "a109":
                    Label47.BackColor = System.Drawing.Color.Red;
                    break;
                case "a110":
                    Label48.BackColor = System.Drawing.Color.Red;
                    break;
                case "a111":
                    Label49.BackColor = System.Drawing.Color.Red;
                    break;
                case "a112":
                    Label50.BackColor = System.Drawing.Color.Red;
                    break;
                case "a113":
                    Label51.BackColor = System.Drawing.Color.Red;
                    break;
                case "a114":
                    Label52.BackColor = System.Drawing.Color.Red;
                    break;
                case "a115":
                    Label53.BackColor = System.Drawing.Color.Red;
                    break;
                case "a116":
                    Label54.BackColor = System.Drawing.Color.Red;
                    break;
            }
            //获取所有的label
        }
    }

       

    protected void Unnamed1_Click1(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtqcode.Text))
        {
            HttpContext.Current.Response.Write("<script>alert('请输入取件码')</script>");
        }
        else
        {
            string qucode = txtqcode.Text;
            // 查询数据库以找到对应的快递柜ID
            string cabinetids = cab.queryCode(qucode);
            // 根据检索到的ID更新柜子的状态
            cab.CUpdateStatus(cabinetids.ToLower());
            // 刷新页面
            Response.AddHeader("Refresh", "0");
        }

    }

    protected void Unnamed2_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtjcode.Text))
        {
            HttpContext.Current.Response.Write("<script>alert('请输入存放码')</script>");

        }
        else
        {
            string jicode = txtjcode.Text;
            //查找数据库里对应的快递柜id
            string cabinetids = cab.queryqCode(jicode);
            //输入寄件码改变箱子颜色
            cab.UpdateStatus(cabinetids.ToLower());
            Response.AddHeader("Refresh", "0");
        }
    }
}