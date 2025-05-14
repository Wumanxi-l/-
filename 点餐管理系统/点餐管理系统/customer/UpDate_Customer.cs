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
            DataView dvCustomers = new DataView(ds.Tables["customers_info"]);
            dgvCustomer.DataSource = dvCustomers;
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
            if (txtname.Text == "" || txtpwd.Text == "")
            {
                MessageBox.Show("客户姓名和密码不能为空");
            }
            else
            {
                DialogResult dr = MessageBox.Show("你确定要修改吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    int a = dgvCustomer.CurrentRow.Index;
                    string str = dgvCustomer.Rows[a].Cells["Customers_id"].Value.ToString();
                    DataRow[] CustRows = ds.Tables["customers_info"].Select("Customers_id='" + str + "'");
                    CustRows[0]["Customers_Name"] = txtname.Text.Trim();
                    CustRows[0]["Customers_Password"] = txtpwd.Text.Trim();
                    CustRows[0]["email"] = txtemail.Text.Trim();
                    MessageBox.Show("修改成功");

                    DataRow drLog = ds.Tables["log_info"].NewRow();
                    drLog["username"] = Login.username;
                    drLog["type"] = "修改";
                    drLog["action_date"] = DateTime.Now;
                    drLog["action_table"] = "Customers表";
                    ds.Tables["log_info"].Rows.Add(drLog);

                    UpdateDB();
                }
                else
                {
                    return;
                }
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
            string str = "select *from Customers";
            daCustomers = new SqlDataAdapter(str, DB.cn);
            string sdr = "select * from log";
            daLog = new SqlDataAdapter(sdr, DB.cn);
            daCustomers.Fill(ds, "customers_info");
            daLog.Fill(ds, "log_info");
        }
    }
}
