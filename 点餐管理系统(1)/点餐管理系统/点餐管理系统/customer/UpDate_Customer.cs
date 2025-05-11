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

namespace 点餐管理系统.customer
{
    public partial class UpDate_Customer : Form
    {
        public UpDate_Customer()
        {
            InitializeComponent();
        }
        SqlDataAdapter daCustomers, daLog;
        DataSet ds = new DataSet();

        private void UpDate_Customer_Load(object sender, EventArgs e)
        {
            init();
            showAll();
        }
        void showAll()
        {
            DataView dvCustomer = new DataView(ds.Tables["customers_info"]);
            dgvCustomer.DataSource = dvCustomer;
            dgvCustomer.Columns[3].Width = 500;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvCustomer.CurrentRow.Cells["Customers_id"].Value.ToString();
            txtname.Text = dgvCustomer.CurrentRow.Cells["Customers_Name"].Value.ToString();
            txtpwd.Text = dgvCustomer.CurrentRow.Cells["Customers_Password"].Value.ToString();
            txtemail.Text = dgvCustomer.CurrentRow.Cells["email"].Value.ToString();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "")
            {
                MessageBox.Show("用户编号或用户名称不能为空");
            }
            else
            {
                DB.GetCn();
                DialogResult dr = MessageBox.Show("你确定要修改吗?", "提示", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    int a = dgvCustomer.CurrentRow.Index;
                    string srt = dgvCustomer.Rows[a].Cells["Customers_id"].Value.ToString();
                    DataRow[] DepRows = ds.Tables["customers_info"].Select("Customers_id='" + srt + "'");
                    DepRows[0]["Customers_Name"] = txtname.Text.Trim();
                    DepRows[0]["Customers_Password"] = txtpwd.Text.Trim();
                    DepRows[0]["email"] = txtemail.Text.Trim();
                    MessageBox.Show("修改成功");
                }
                else
                {
                    return;
                }

                //使用存储过程添加日志信息
                SqlCommand cmd = new SqlCommand("add_log", DB.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("username", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("type", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("action_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("action_table", SqlDbType.NVarChar));

                cmd.Parameters["username"].Value = Login.username;
                cmd.Parameters["type"].Value = "修改";
                cmd.Parameters["action_date"].Value = DateTime.Now;
                cmd.Parameters["action_table"].Value = "Customers表";
                try
                {
                    SqlCommandBuilder dbCustomer = new SqlCommandBuilder(daCustomers);
                    daCustomers.Update(ds, "customers_info");
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DB.cn.Close();
            }
        }
        void UpdateDB()
        {
            SqlTransaction st = tansactionInit();
            try
            {
                daCustomers.Update(ds, "customers_info");
                daLog.Update(ds, "log_info");
                st.Commit();
                DB.cn.Close();
            }
            catch(Exception ex)
            {
                st.Rollback();
                DB.cn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private SqlTransaction tansactionInit()
        {
            DB.GetCn();
            SqlCommandBuilder dbCustomers = new SqlCommandBuilder(daCustomers);
            SqlCommandBuilder dbLog = new SqlCommandBuilder(daLog);

            daCustomers.UpdateCommand = dbCustomers.GetUpdateCommand();
            daLog.UpdateCommand = dbLog.GetUpdateCommand();

            SqlTransaction st = DB.cn.BeginTransaction();
            daCustomers.UpdateCommand.Transaction = st;
            daLog.UpdateCommand.Transaction = st;

            daCustomers.UpdateCommand.Connection = DB.cn;
            daLog.UpdateCommand.Connection = DB.cn;

            return st;
        }

        private void btncance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void init()
        {
            DB.GetCn();
            string str = "select * from Customers";
            string std = "select * from log";
            daCustomers = new SqlDataAdapter(str, DB.cn);
            daLog = new SqlDataAdapter(std, DB.cn);
            daCustomers.Fill(ds, "customers_info");
            daLog.Fill(ds, "log_info");
            DB.cn.Close();
        }
    }
}
