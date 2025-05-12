using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyShop.BLL;
using MyShop1.DAL;

public partial class TfanDefault : System.Web.UI.Page
{
    CabinetService cabinetService = new CabinetService();
    QujianService quSrv = new QujianService();
    ToufanService toufanSrv = new ToufanService();
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        //获取所有的使用的快递柜
        List<快递柜表> cabinets = cabinetService.queryAllUser();
        foreach (快递柜表 c in cabinets)
        {
            switch (c.智能柜ID)
            {
                case "A101":
                    Label1.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A102":
                    Label2.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A103":
                    Label3.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A104":
                    Label4.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A105":
                    Label5.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A106":
                    Label6.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A107":
                    Label7.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A108":
                    Label8.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B101":
                    Label9.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B102":
                    Label10.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B103":
                    Label11.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B104":
                    Label12.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B105":
                    Label13.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B106":
                    Label14.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B107":
                    Label15.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B108":
                    Label16.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "C101":
                    Label17.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "C102":
                    Label18.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "C103":
                    Label19.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "C104":
                    Label20.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "C105":
                    Label21.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "D101":
                    Label22.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "D102":
                    Label23.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "D103":
                    Label24.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "D104":
                    Label25.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "D105":
                    Label26.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "D106":
                    Label27.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "C106":
                    Label34.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "C107":
                    Label35.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "C108":
                    Label36.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "C109":
                    Label37.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "C110":
                    Label38.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B109":
                    Label39.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B110":
                    Label40.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B111":
                    Label41.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B112":
                    Label42.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B113":
                    Label43.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B114":
                    Label44.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B115":
                    Label45.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "B116":
                    Label46.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A109":
                    Label47.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A110":
                    Label48.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A111":
                    Label49.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A112":
                    Label50.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A113":
                    Label51.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A114":
                    Label52.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A115":
                    Label53.BackColor = System.Drawing.Color.LightPink;
                    break;
                case "A116":
                    Label54.BackColor = System.Drawing.Color.LightPink;
                    break;
            }
        }
    }

    protected void Unnamed_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtqcode.Text))
        {
            HttpContext.Current.Response.Write("<script>alert('请输入取件码')</script>");
        }
        else
        {
            string qucode = txtqcode.Text;
            // 查询数据库以找到对应的快递柜ID
            string cabinetids = cabinetService.queryCode(qucode);
            //// 根据检索到的ID更新柜子的状态
            cabinetService.CUpdateStatus(cabinetids.ToLower());
            // 刷新页面
            Response.AddHeader("Refresh", "0");
        }
    }

    //快递员投递
    protected void Unnamed_Click1(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtjcode.Text))
        {
            HttpContext.Current.Response.Write("<script>alert('请输入存放码')</script>");

        }
        else
        {
            string toucode = txtjcode.Text;
            //查找数据库里对应的快递柜id
            string cabinetids = cabinetService.querytCode(toucode);
            //输入寄件码改变箱子颜色
            //cabinetService = new CabinetService();
            cabinetService.UpdateStatus(cabinetids.ToLower());
            Response.AddHeader("Refresh", "0");
            //更新快递状态
            quSrv.PkgUpdateStatus(cabinetids);
        }
    }
}