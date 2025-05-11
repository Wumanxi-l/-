using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace 点餐管理系统
{
    public partial class dianping : Form
    {
        public dianping()
        {
            InitializeComponent();
        }
        SqlDataAdapter dadianping;
        DataSet ds = new DataSet();
        void init()//初始化
        {
            DB.GetCn();
            string str = "select *from dianping";
            dadianping = new SqlDataAdapter(str, DB.cn);
            dadianping.Fill(ds, "dianp_info");
        }
        void showAll()
        {
            DataView dvdianping = new DataView(ds.Tables["dianp_info"]);
            dgvdianping.DataSource = dvdianping;
        }

        private void dianping_Load(object sender, EventArgs e)
        {
            init();
            showAll();
            dgvHead();
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void dgvHead()//重绘表头
        {
            this.dgvdianping.Columns[0].HeaderText = "点评编号";
            this.dgvdianping.Columns[1].HeaderText = "用户编号";
            this.dgvdianping.Columns[2].HeaderText = "用户名";
            this.dgvdianping.Columns[3].HeaderText = "菜品名称";
            this.dgvdianping.Columns[4].HeaderText = "评价";
            this.dgvdianping.Columns[5].HeaderText = "评分";

        }
    }
}
