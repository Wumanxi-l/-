using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 点餐管理系统.supplier
{
    public partial class increase_suppliers : Form
    {
        public increase_suppliers()
        {
            InitializeComponent();
        }
        public static string path_source = "";
        SqlDataAdapter daDishes, dalog;
        DataSet ds = new DataSet();
        private void label3_Click(object sender, EventArgs e)
        {
            DB.GetCn();
            string str = "select *from Dishes";
            string sdr = "select * from log";
            daDishes = new SqlDataAdapter(str, DB.cn);
            dalog = new SqlDataAdapter(sdr, DB.cn);
            daDishes.Fill(ds, "dishes_info");
            dalog.Fill(ds, "log_info");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
