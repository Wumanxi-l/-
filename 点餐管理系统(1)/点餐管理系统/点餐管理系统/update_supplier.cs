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

namespace 点餐管理系统
{
    public partial class update_supplier : Form
    {
        public update_supplier()
        {
            InitializeComponent();
        }
        SqlDataAdapter dasupplier, daLog;
        DataSet ds = new DataSet();
        void init()//初始化
        {
            DB.GetCn();
            string str = "select *from supplier";
            dasupplier = new SqlDataAdapter(str, DB.cn);
            string sdr = "select * from log";
            daLog = new SqlDataAdapter(sdr, DB.cn);
            dasupplier.Fill(ds, "supplier_info");
            daLog.Fill(ds, "log_info");
        }
        void showAll()
        {
            DataView dvsupplier = new DataView(ds.Tables["supplier_info"]);
            dgvsupplier.DataSource = dvsupplier;
        }
      
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "")
            {
                MessageBox.Show("供应商编号或供应商名称不能为空");
            }
            else
            {
                DB.GetCn();
                DialogResult dr = MessageBox.Show("你确定要修改吗?", "提示", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    int a = dgvsupplier.CurrentRow.Index;
                    string srt = dgvsupplier.Rows[a].Cells["supplierID"].Value.ToString();
                    DataRow[] DepRows = ds.Tables["supplier_info"].Select("supplierID='" + srt + "'");
                    DepRows[0]["supplierName"] = txtname.Text.Trim();
                    DepRows[0]["employname"] = txtemname.Text.Trim();
                    DepRows[0]["phone"] = txtphone.Text.Trim();
                    DepRows[0]["address"] = txtadd.Text.Trim();
                    DepRows[0]["youzheng"] = txtyou.Text.Trim();
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
                cmd.Parameters["action_table"].Value = "supplier表";
                try
                {
                    SqlCommandBuilder dbsupplier = new SqlCommandBuilder(dasupplier);
                    dasupplier.Update(ds, "supplier_info");
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
                dasupplier.Update(ds, "supplier_info");
                daLog.Update(ds, "log_info");
                st.Commit();
                DB.cn.Close();
            }
            catch (Exception ex)
            {
                st.Rollback();
                DB.cn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private SqlTransaction tansactionInit()
        {
            DB.GetCn();
            SqlCommandBuilder dbSupplier = new SqlCommandBuilder(dasupplier);
            SqlCommandBuilder dbLog = new SqlCommandBuilder(daLog);

            dasupplier.UpdateCommand = dbSupplier.GetUpdateCommand();
            daLog.UpdateCommand = dbLog.GetUpdateCommand();

            SqlTransaction st = DB.cn.BeginTransaction();
            dasupplier.UpdateCommand.Transaction = st;
            daLog.UpdateCommand.Transaction = st;

            dasupplier.UpdateCommand.Connection = DB.cn;
            daLog.UpdateCommand.Connection = DB.cn;

            return st;
        }
        private void dgvsupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvsupplier.CurrentRow.Cells["supplierID"].Value.ToString();
            txtname.Text = dgvsupplier.CurrentRow.Cells["supplierName"].Value.ToString();
            txtemname.Text = dgvsupplier.CurrentRow.Cells["employname"].Value.ToString();
            txtphone.Text = dgvsupplier.CurrentRow.Cells["phone"].Value.ToString();
            txtadd.Text = dgvsupplier.CurrentRow.Cells["address"].Value.ToString();
            txtyou.Text = dgvsupplier.CurrentRow.Cells["youzheng"].Value.ToString();
        }

        private void btncance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_supplier_Load(object sender, EventArgs e)
        {
            init();
            showAll();
        }
    }

}

