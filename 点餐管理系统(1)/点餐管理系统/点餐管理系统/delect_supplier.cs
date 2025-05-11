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
    public partial class delect_supplier : Form
    {
        public delect_supplier()
        {
            InitializeComponent();
        }
        SqlDataAdapter dasupplier, daLog;
        DataSet ds = new DataSet();
        void init()//初始化
        {
            DB.GetCn();
            string str = "select * from supplier";
            string sdr = "select * from log";
            dasupplier = new SqlDataAdapter(str, DB.cn);
            daLog = new SqlDataAdapter(sdr, DB.cn);
            dasupplier.Fill(ds, "supplier_info");
            daLog.Fill(ds, "log_info");
        }
        void showAll()//显示全部
        {
            DataView dvsupplier = new DataView(ds.Tables["supplier_info"]);
            dgvsupplier.DataSource = dvsupplier;
        }
        

        private void delect_supplier_Load(object sender, EventArgs e)
        {
            showXz();
            init();
            showAll();
        }

        private void dgvsupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvsupplier.Rows.Count > 0)
            {
                for (int i = 0; i < dgvsupplier.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell ck = dgvsupplier.Rows[i].Cells["acCode"] as DataGridViewCheckBoxCell;
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
            int s = dgvsupplier.Rows.Count;
            for (int i = 0; i < dgvsupplier.Rows.Count; i++)
            {
                if (dgvsupplier.Rows[i].Cells["acCode"].EditedFormattedValue.ToString() == "True")
                {
                    DialogResult dr = MessageBox.Show("您确定要删除此选项吗？", "提示",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        dgvsupplier.Rows.RemoveAt(i);
                        //添加日志
                        DataRow drLog = ds.Tables["log_info"].NewRow();
                        drLog["username"] = Login.username;
                        drLog["type"] = "删除";
                        drLog["action_date"] = DateTime.Now;
                        drLog["action_table"] = "supplier表";
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
                SqlCommandBuilder dbsupplier = new SqlCommandBuilder(dasupplier);
                dasupplier.Update(ds, "supplier_info");
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

        void showXz()
        {
            DataGridViewCheckBoxColumn acCode = new DataGridViewCheckBoxColumn();
            acCode.Name = "acCode";
            acCode.HeaderText = "选择";
            dgvsupplier.Columns.Add(acCode);
        }
    }

}
