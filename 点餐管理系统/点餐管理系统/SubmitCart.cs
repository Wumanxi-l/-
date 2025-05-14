using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 点餐管理系统
{
    public partial class SubmitCart : Form
    {
        public SubmitCart()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            DB.GetCn();
            string str = "insert into Orders values('" + Login.username + "','" + DateTime.Today + "','" 
                + txtremark.Text + "','" + txtphone.Text+ "','未审核',null,"+ShopCart.profit +")";
            ShopCart.profit = 0;
            DB.sqlEx(str);
            MessageBox.Show("已成功结算，谢谢光临");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitCart_Load(object sender, EventArgs e)
        {

        }
    }
}
