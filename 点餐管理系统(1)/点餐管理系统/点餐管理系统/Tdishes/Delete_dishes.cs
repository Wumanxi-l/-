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

namespace 点餐管理系统.Tdishes
{
    public partial class Delete_dishes : Form
    {
        public Delete_dishes()
        {
            InitializeComponent();
        }
        SqlDataAdapter daDishes, daLog;
        DataSet ds = new DataSet();
        void init()
        {
            DB.GetCn();
            string str = "select * from Dishes";
            string sdr = "select * from log";
            daDishes = new SqlDataAdapter(str, DB.cn);
            daLog = new SqlDataAdapter(sdr, DB.cn);
            daDishes.Fill(ds, "Dishes_info");
            daLog.Fill(ds, "log_info");
        }
        void showAll()
        {
            DataView dvDishes = new DataView(ds.Tables["Dishes_info"]);
            dgvDishes.DataSource = dvDishes;
        }
        void showXz()
        {
            DataGridViewCheckBoxColumn acCode = new DataGridViewCheckBoxColumn();
            acCode.Name = "acCode";
            acCode.HeaderText = "选择";
            dgvDishes.Columns.Add(acCode);
        }

        private void dgvDishes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDishes.Rows.Count > 0)
            {
                for(int i = 0; i< dgvDishes.Rows.Count; i++)
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            int s = dgvDishes.Rows.Count;
            for(int i = 0; i < dgvDishes.Rows.Count; i++)
            {
                if (dgvDishes.Rows[i].Cells["acCode"].EditedFormattedValue.ToString() == "True")
                {
                    DialogResult dr = MessageBox.Show("您确定要删除此选项吗？", "提示",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if(dr== DialogResult.OK)
                    {
                        dgvDishes.Rows.RemoveAt(i);
                        //添加日志
                        DataRow drLog = ds.Tables["log_info"].NewRow();
                        drLog["username"] = Login.username;
                        drLog["type"] = "删除";
                        drLog["action_date"] = DateTime.Now;
                        drLog["action_table"] = "dishes表";
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
                SqlCommandBuilder dbDishes = new SqlCommandBuilder(daDishes);
                daDishes.Update(ds, "Dishes_info");
                SqlCommandBuilder dbLog = new SqlCommandBuilder(daLog);
                daLog.Update(ds, "log_info");
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

        private void Delete_dishes_Load(object sender, EventArgs e)
        {
            showXz();
            init();
            showAll();
        }
    }
}
