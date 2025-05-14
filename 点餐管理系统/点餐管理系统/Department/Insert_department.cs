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
    public partial class Insert_department : Form
    {
        public Insert_department()
        {
            InitializeComponent();
        }
        SqlDataAdapter daDepartment;
        DataSet ds = new DataSet();
        void init()
        {
            DB.GetCn();
            string str = "select * from department";
            daDepartment = new SqlDataAdapter(str, DB.cn);
            daDepartment.Fill(ds, "department_info");
            DB.cn.Close();
        }
        void showAll()
        {
            DataView dvDepartment = new DataView(ds.Tables["department_info"]);
            dgvDepartment.DataSource = dvDepartment;
            dgvDepartment.Columns[3].Width = 500;
        }
        void dgvHead()
        {
            this.dgvDepartment.Columns[0].HeaderText = "部门编号";
            this.dgvDepartment.Columns[1].HeaderText = "部门名称";
            this.dgvDepartment.Columns[2].HeaderText = "部门经理";
            this.dgvDepartment.Columns[3].HeaderText = "部门描述";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Insert_department_Load(object sender, EventArgs e)
        {
            init();
            showAll();
            dgvHead();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "")
            {
                MessageBox.Show("部门编号或部门名称不能为空");
            }
            else
            {
                DB.GetCn();
                DialogResult dr = MessageBox.Show("你确定要添加吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    string s_id = "select * from department where department_id='" + txtid.Text + "'";
                    DataTable dt1 = DB.GetDataSet(s_id);
                    if (dt1.Rows.Count > 0)
                    {
                        MessageBox.Show("此部门编号已存在，请重新输入");
                    }
                    else
                    {
                        string s_name = "select * from department where department_name='" + txtname.Text + "'";
                        DataTable dt2 = DB.GetDataSet(s_name);
                        if (dt2.Rows.Count > 0)
                        {
                            MessageBox.Show("此部门名称已存在，请重新输入");
                        }
                        else
                        {
                            DataRow DepRow = ds.Tables["department_info"].NewRow();
                            DepRow["department_id"] = txtid.Text.Trim();
                            DepRow["department_name"] = txtname.Text.Trim();
                            DepRow["Manager_id"] = txtmanager.Text.Trim();
                            DepRow["department_description"] = txtdescr.Text.Trim();
                            ds.Tables["department_info"].Rows.Add(DepRow);
                        }
                    }
                }
                else
                {
                    return;
                }
                //使用存储过程添加日志
                SqlCommand cmd = new SqlCommand("add_log", DB.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("username", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("type", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("action_date", SqlDbType.DateTime));
                cmd.Parameters.Add(new SqlParameter("action_table", SqlDbType.NVarChar));

                cmd.Parameters["username"].Value = Login.username;
                cmd.Parameters["type"].Value = "添加";
                cmd.Parameters["action_date"].Value = DateTime.Now;
                cmd.Parameters["action_table"].Value = "department表";

                try
                {
                    SqlCommandBuilder dbDepartment = new SqlCommandBuilder(daDepartment);
                    daDepartment.Update(ds, "department_info");
                    cmd.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btncance_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
