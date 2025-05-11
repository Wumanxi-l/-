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

namespace 点餐管理系统.Tdishes
{
    public partial class insert_dishes : Form
    {
        public insert_dishes()
        {
            InitializeComponent();
        }
        public static string path_source="";
        SqlDataAdapter daDishes, dalog;
        DataSet ds = new DataSet();
        void init()//初始化
        {
            DB.GetCn();
            string str = "select *from Dishes";
            string sdr = "select * from log";
            daDishes = new SqlDataAdapter(str, DB.cn);
            dalog = new SqlDataAdapter(sdr, DB.cn);
            daDishes.Fill(ds, "dishes_info");
            dalog.Fill(ds, "log_info");
        }
        void showAll()
        {
            DataView dvDishes = new DataView(ds.Tables["dishes_info"]);
            dgvDishes.DataSource = dvDishes;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtDishesid.Text == "" || txtName.Text == "" || txtSales.Text == "")
            {
                MessageBox.Show("必填项不能为空");
            }
            else
            {
                DB.GetCn();
                string str = "select * from Dishes where Dishes_ID='" + txtDishesid.Text + "'";
                DataTable dt = DB.GetDataSet(str);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("此菜品已存在，请重新输入菜品编号");
                }
                else
                {
                    string filename;
                    string fileFolder;
                    string dateTime = "";
                    filename = Path.GetFileName(path_source);
                    dateTime += DateTime.Now.Year.ToString();
                    dateTime += DateTime.Now.Month.ToString();
                    dateTime += DateTime.Now.Day.ToString();
                    dateTime += DateTime.Now.Hour.ToString();
                    dateTime += DateTime.Now.Minute.ToString();
                    dateTime += DateTime.Now.Second.ToString();
                    filename = dateTime + filename;
                    fileFolder = Directory.GetCurrentDirectory() + "\\" + "Prod_images\\"
                        + cboCategory.Text + "\\";
                    fileFolder += filename;

                    DataRow drPro = ds.Tables["dishes_info"].NewRow();
                    drPro["Dishes_Id"] = Convert.ToInt32(txtDishesid.Text);
                    //drPro["Dishes_Id"] = int.Parse(txtDishesid.Text);
                    drPro["classification_ID"] = cboCategory.SelectedValue;
                    drPro["Unit_Price"] = decimal.Parse(txtPrice.Text);
                    drPro["tasteName"] = cboTastes.SelectedValue;
                    drPro["Dishes_Name"] = txtName.Text;
                    drPro["Sales"] = txtSales.Text;
                    drPro["Descn"] = txtDescn.Text;
                    drPro["Qty"] = txtQty.Text;
                    drPro["List_Price"] = decimal.Parse(txtListPrice.Text);
                    if (path_source != "")
                    {
                        File.Copy(path_source, fileFolder, true);
                        drPro["image"] = "\\Prod_images\\" + cboCategory.Text
                            + "\\"+ filename;
                    }
                    else
                    {
                        drPro["image"] = "暂无图片.gif";
                    }
                    ds.Tables["dishes_info"].Rows.Add(drPro);

                    DataRow drLog = ds.Tables["log_info"].NewRow();
                    drLog["username"] = Login.username;
                    drLog["type"] = "添加";
                    drLog["action_date"] = DateTime.Now;
                    drLog["action_table"] = "dishes表";
                    ds.Tables["log_info"].Rows.Add(drLog);
                    try
                    {
                        SqlCommandBuilder dbemployee = new SqlCommandBuilder(daDishes);
                        SqlCommandBuilder dbLog = new SqlCommandBuilder(dalog);
                        daDishes.Update(ds, "dishes_info");
                        
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path_source = ofd.FileName;
                pictureBox1.Image = Image.FromFile(path_source);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insert_dishes_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“selesDataSet11.taste”中。您可以根据需要移动或移除它。
            this.tasteTableAdapter.Fill(this.selesDataSet11.taste);
            // TODO: 这行代码将数据加载到表“selesDataSet10.Classification”中。您可以根据需要移动或移除它。
            this.classificationTableAdapter4.Fill(this.selesDataSet10.Classification);
            init();
            showAll();
        }
    }
}
