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
using Microsoft.IdentityModel.Tokens;

namespace 点餐管理系统.Order
{
    public partial class Check_Order : Form
    {
        public Check_Order()
        {
            InitializeComponent();
        }
        SqlDataAdapter daOrder;
        DataSet ds = new DataSet();
        void init()
        {
            DB.GetCn();
            string str = "select * from Orders";
            daOrder = new SqlDataAdapter(str, DB.cn);
            daOrder.Fill(ds, "order_info");
        }
        void showAll()
        {
            init();
            showXz();
        }
        void showXz()
        {
            DataGridViewCheckBoxColumn acCode = new DataGridViewCheckBoxColumn();
            acCode.Name = "acCode";
            acCode.HeaderText = "选择";
            dgvOrders.Columns.Add(acCode);
        }

        private void Check_Order_Load(object sender, EventArgs e)
        {
            showAll();
            DataView dvOrder = new DataView(ds.Tables["order_info"]);
            dgvOrders.DataSource = dvOrder;
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrders.Rows.Count > 0)
            {
                for (int i = 0; i < dgvOrders.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell ck = dgvOrders.Rows[i].Cells["acCode"] as DataGridViewCheckBoxCell;
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            int s = dgvOrders.Rows.Count;
            for(int i = 0; i < dgvOrders.Rows.Count; i++)
            {
                if (dgvOrders.Rows[i].Cells["acCode"].EditedFormattedValue.ToString() == "True")
                {
                    dgvOrders.Rows[i].Cells["status"].Value = "已审核";
                    if (string.IsNullOrEmpty(dgvOrders.Rows[i].Cells["employee_id"].Value?.ToString()))
                    {
                        dgvOrders.Rows[i].Cells["employee_id"].Value = Login.employee_id;
                    }
                    updateDB();
                }
                else
                {
                    s = s - 1;
                }
            }
            if (s == 0)
            {
                MessageBox.Show("请选择要审核的项");
            }
        }
        void updateDB()//更新数据源
        {
            try
            {
                SqlCommandBuilder dbOrder = new SqlCommandBuilder(daOrder);
                daOrder.Update(ds, "order_info");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
