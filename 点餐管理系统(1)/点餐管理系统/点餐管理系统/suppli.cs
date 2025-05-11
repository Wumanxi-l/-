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
using System.IO;
using System.Diagnostics;

namespace 点餐管理系统
{
    public partial class suppli : Form
    {
        public suppli()
        {
            InitializeComponent();
        }
        public static string path_source = "";
        SqlDataAdapter dasupplier, dalog;
        DataSet ds = new DataSet();
        private object classificationTableAdapter4;

        void init()//初始化
        {
            DB.GetCn();
            string str = "select *from supplier";
            string sdr = "select * from log";
            dasupplier = new SqlDataAdapter(str, DB.cn);
            dalog = new SqlDataAdapter(sdr, DB.cn);
            dasupplier.Fill(ds, "supplier_info");
            dalog.Fill(ds, "log_info");
        }
        void showAll()
        {
            DataView dvsupplier = new DataView(ds.Tables["supplier_info"]);
            dgvsupplier.DataSource = dvsupplier;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" || txtphone.Text == ""||txtadd.Text=="")
            {
                MessageBox.Show("必填项不能为空");
            }
            else
            {
                DB.GetCn();
                string str = "select * from supplier where supplierid='" + txtid.Text + "'";
                DataTable dt = DB.GetDataSet(str);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("此供应商已存在，请重新输入供应商编号");
                }
                else
                {
                 

                    DataRow drPro = ds.Tables["supplier_info"].NewRow();
                    drPro["supplierID"] = Convert.ToInt32(txtid.Text);
                    //drPro["Dishes_Id"] = int.Parse(txtDishesid.Text);
                    
                    drPro["supplierName"] = txtname.Text;
                    drPro["employname"] = txtemname.Text;
                    drPro["phone"] = txtphone.Text;
                    drPro["address"] = txtadd.Text;
                    drPro["youzheng"] = txtYOU.Text;
                    
                    ds.Tables["supplier_info"].Rows.Add(drPro);

                    DataRow drLog = ds.Tables["log_info"].NewRow();
                    drLog["username"] = Login.username;
                    drLog["type"] = "添加";
                    drLog["action_date"] = DateTime.Now;
                    drLog["action_table"] = "supplier表";
                    ds.Tables["log_info"].Rows.Add(drLog);
                    try
                    {
                        SqlCommandBuilder dbemployee = new SqlCommandBuilder(dasupplier);
                        SqlCommandBuilder dbLog = new SqlCommandBuilder(dalog);
                        dasupplier.Update(ds, "supplier_info");

                        dalog.Update(ds, "log_info");
                        MessageBox.Show("添加成功");
                        path_source = "";
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    DB.cn.Close();
                }
            }
        }

        private void suppli_Load(object sender, EventArgs e)
        {
            init();
            showAll();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
