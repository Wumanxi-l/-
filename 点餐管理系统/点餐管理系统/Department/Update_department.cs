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

namespace 点餐管理系统.Department
{
    public partial class Update_department : Form
    {
        public Update_department()
        {
            InitializeComponent();
        }
        SqlDataAdapter daDepartment;
        SqlDataAdapter daLog;
        DataSet ds = new DataSet();
        void init()//初始化
        {
            DB.GetCn();
            string str = "select * from department";
            string std = "select * from log";
            daDepartment = new SqlDataAdapter(str, DB.cn);
            daLog = new SqlDataAdapter(std, DB.cn);
            daDepartment.Fill(ds, "department_info");
            daLog.Fill(ds, "log _info");
            DB.cn.Close();
        }
        void showALLdepartment()//显示全部
        {
            DataView dvDepartment = new DataView(ds.Tables["department_info"]);
            dgvDepartment.DataSource = dvDepartment;
            dgvDepartment.Columns[3].Width = 500;
        }
        void dgvHead()//重绘表头
        {
            this.dgvDepartment.Columns[0].HeaderText = "部门编号";
            this.dgvDepartment.Columns[1].HeaderText = "部门名称";
            this.dgvDepartment.Columns[2].HeaderText = "部门经理";
            this.dgvDepartment.Columns[3].HeaderText = "部门描述";
        }
        private void Update_department_Load(object sender, EventArgs e)
        {
            init();
            showALLdepartment();
            dgvHead();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtid. Text == "" || txtname.Text == "")
            {
                MessageBox.Show("部门编号或部门名称不能为空");
            }
            else
            {
                DB.GetCn();
                DialogResult dr = MessageBox.Show("你确定要修改吗?", "提示",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
                if(dr == DialogResult.OK)
                {
                    int a = dgvDepartment.CurrentRow.Index;
                    string srt = dgvDepartment.Rows[a].Cells["department_id"].Value.ToString();
                    DataRow[] DepRows = ds.Tables["department_info"].Select("department_id='" + srt + "'");
                    DepRows[0]["department_name"] = txtname.Text.Trim();
                    DepRows[0]["Manager_id"] = txtmanager.Text.Trim();
                    DepRows[0]["department_description"] = txtdescr.Text.Trim();
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
                cmd.Parameters["action_table"].Value = "department表";
                try
                {
                    SqlCommandBuilder dbemployee = new SqlCommandBuilder(daDepartment);
                    daDepartment.Update(ds, "department_info");
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DB.cn.Close();
            }
        }

        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvDepartment.CurrentRow.Cells["department_id"].Value.ToString();
            txtname.Text = dgvDepartment.CurrentRow.Cells["department_name"].Value.ToString();
            txtmanager.Text= dgvDepartment.CurrentRow.Cells["Manager_id"].Value.ToString();
            txtdescr.Text= dgvDepartment.CurrentRow.Cells["department_description"].Value.ToString();
        }

        private void btncance_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
