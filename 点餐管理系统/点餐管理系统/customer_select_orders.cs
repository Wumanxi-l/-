using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Data.SqlClient;

namespace 点餐管理系统
{
    public partial class customer_select_orders : Form
    {
        public customer_select_orders()
        {
            InitializeComponent();
        }
        SqlDataAdapter daOrders, daLog;
        DataSet ds = new DataSet();
        void init()
        {
            DB.GetCn();
            string str = "select * from Orders";
            string sdr = "select * from log";
            daOrders = new SqlDataAdapter(str, DB.cn);
            daLog = new SqlDataAdapter(sdr, DB.cn);
            daOrders.Fill(ds, "Orders_info");
            daLog.Fill(ds, "log_info");
        }
        void showAll()
        {
            DataView dvOrders = new DataView(ds.Tables["Orders_info"]);
            dgvDishes.DataSource = dvOrders;
        }
        void showXz()
        {
            DataGridViewCheckBoxColumn acCode = new DataGridViewCheckBoxColumn();
            acCode.Name = "acCode";
            acCode.HeaderText = "选择";
            dgvDishes.Columns.Add(acCode);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvDishes.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDishes.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell ck = dgvDishes.Rows[i].Cells["acCode"] as DataGridViewCheckBoxCell;
                    if (i != e.RowIndex)
                    {
                        ck.Value = false;
                    }
                    else
                    {
                        ck.Value = true;
                    }
                }
            }
        }
        void UpdateDB()
        {
            try
            {
                SqlCommandBuilder dbDishes = new SqlCommandBuilder(daOrders);
                daOrders.Update(ds, "Orders_info");
                SqlCommandBuilder dbLog = new SqlCommandBuilder(daLog);
                daLog.Update(ds, "log_info");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void customer_select_orders_Load(object sender, EventArgs e)
        {
            showXz();
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
            this.dgvDishes.Columns[1].HeaderText = "订单编号";
            this.dgvDishes.Columns[2].HeaderText = "用户名";
            this.dgvDishes.Columns[3].HeaderText = "订单日期";
            this.dgvDishes.Columns[4].HeaderText = "买家备注";
            this.dgvDishes.Columns[5].HeaderText = "电话号码";
            this.dgvDishes.Columns[6].HeaderText = "审核状态";
            this.dgvDishes.Columns[7].HeaderText = "员工编号";
            this.dgvDishes.Columns[8].HeaderText = "盈利利润";
            this.dgvDishes.Columns[9].HeaderText = "菜品编号";
            this.dgvDishes.Columns[10].HeaderText = "菜品名称";
        }
    }
}
