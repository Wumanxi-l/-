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
    public partial class Delect_department : Form
    {
        public Delect_department()
        {
            InitializeComponent();
        }
        SqlDataAdapter daDepartment, daLog;
        DataSet ds = new DataSet();
        void init()
        {
            DB.GetCn();
            string str = "select * from department";
            string sdr = "select * from log";
            daDepartment = new SqlDataAdapter(str, DB.cn);
            daLog = new SqlDataAdapter(sdr, DB.cn);
            daDepartment.Fill(ds, "department_info");
            daLog.Fill(ds, "log_info");
        }
        void showAll()
        {
            DataView dvDepartment = new DataView(ds.Tables["department_info"]);
            dgvDepartment.DataSource = dvDepartment;
        }

        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepartment.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDepartment.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell ck = dgvDepartment.Rows[i].Cells["acCode"] as DataGridViewCheckBoxCell;
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

        private void btnok_Click(object sender, EventArgs e)
        {
            int s = dgvDepartment.Rows.Count;
            for (int i = 0; i < dgvDepartment.Rows.Count; i++)
            {
                if (dgvDepartment.Rows[i].Cells["acCode"].EditedFormattedValue.ToString() == "True")
                {
                    DialogResult dr = MessageBox.Show("您确定要删除此选项吗？", "提示",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        dgvDepartment.Rows.RemoveAt(i);
                        //添加日志
                        DataRow drLog = ds.Tables["log_info"].NewRow();
                        drLog["username"] = Login.username;
                        drLog["type"] = "删除";
                        drLog["action_date"] = DateTime.Now;
                        drLog["action_table"] = "department表";
                        ds.Tables["log_info"].Rows.Add(drLog);

                        UpdateDB();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    s = s - 1;
                }
            }
            if (s == 0)
            {
                MessageBox.Show("请选择您要删除的项");
            }
        }
        void UpdateDB()
        {
            try
            {
                SqlCommandBuilder dbDepartment = new SqlCommandBuilder(daDepartment);
                daDepartment.Update(ds, "department_info");
                SqlCommandBuilder dbLog = new SqlCommandBuilder(daLog);
                daLog.Update(ds, "log_info");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btncance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delect_department_Load(object sender, EventArgs e)
        {
            showXz();
            init();
            showAll();
        }

        void showXz()
        {
            DataGridViewCheckBoxColumn acCode = new DataGridViewCheckBoxColumn();
            acCode.Name = "acCode";
            acCode.HeaderText = "选择";
            dgvDepartment.Columns.Add(acCode);
        }
       
    }
}
