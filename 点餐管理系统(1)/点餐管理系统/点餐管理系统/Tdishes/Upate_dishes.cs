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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace 点餐管理系统.Tdishes
{
    public partial class Upate_dishes : Form
    {
        public Upate_dishes()
        {
            InitializeComponent();
        }
        SqlDataAdapter daDishes, daLog;
        DataSet ds = new DataSet();
        public static string path_source = "";//保存图片路径
        void init()
        {
            DB.GetCn();
            string str = "select * from Dishes";
            string sdr = "select * from log";
            daDishes = new SqlDataAdapter(str, DB.cn);
            daLog = new SqlDataAdapter(sdr, DB.cn);
            daDishes.Fill(ds, "dishes_info");
            daLog.Fill(ds, "log_info");
        }
        void showAll()
        {
            DataView dvDishes = new DataView(ds.Tables["dishes_info"]);
            dgvDishes.DataSource = dvDishes;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvDishes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvDishes.CurrentRow.Cells["Dishes_ID"].Value.ToString();
            cboCatagoryId.Text= dgvDishes.CurrentRow.Cells["Classification_ID"].Value.ToString();
            txtPrice.Text= dgvDishes.CurrentRow.Cells["Unit_Price"].Value.ToString();
            txtName.Text= dgvDishes.CurrentRow.Cells["Dishes_Name"].Value.ToString();
            cboTastes.Text= dgvDishes.CurrentRow.Cells["tasteName"].Value.ToString();
            txtSales.Text= dgvDishes.CurrentRow.Cells["Sales"].Value.ToString();
            txtDescn.Text= dgvDishes.CurrentRow.Cells["Descn"].Value.ToString();
            txtQty.Text = dgvDishes.CurrentRow.Cells["Qty"].Value.ToString();
            try
            {
                pic_Dishes.Image = Image.FromFile(Application.StartupPath
                    + dgvDishes.CurrentRow.Cells["Image"].Value.ToString());
                pic_Dishes.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                pic_Dishes.Image = Image.FromFile(Application.StartupPath + "\\" + "暂无图片.gif");
            }
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path_source = ofd.FileName;
                pic_Dishes.Image = Image.FromFile(path_source);
                pic_Dishes.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" ||txtSales.Text == "")
            {
                MessageBox.Show("商品名称、销量不能为空");
            }
            else
            {
                DialogResult dr = MessageBox.Show("您确定要更改吗？", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
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
                        + cboCatagoryId.SelectedText + "\\";
                    fileFolder += filename;

                    int a = dgvDishes.CurrentRow.Index;
                    string str = dgvDishes.Rows[a].Cells["Dishes_ID"].Value.ToString();
                    DataRow[] ProRows = ds.Tables["dishes_info"].Select("Dishes_ID='" + str + "'");
                    ProRows[0]["Classification_ID"] = cboCatagoryId.SelectedValue;
                    ProRows[0]["Unit_Price"] = decimal.Parse(txtPrice.Text.Trim());
                    ProRows[0]["Dishes_Name"] = txtName.Text.Trim();
                    ProRows[0]["tasteName"] = cboTastes.SelectedValue;
                    ProRows[0]["Sales"] = int.Parse(txtSales.Text.Trim());
                    ProRows[0]["Descn"] = txtDescn.Text.Trim();
                    ProRows[0]["list_Price"] = decimal.Parse(txtListPrice.Text.Trim());
                    ProRows[0]["Qty"] = int.Parse(txtQty.Text.Trim());
                    if (path_source != "")
                    {
                        File.Copy(path_source, fileFolder, true);
                        ProRows[0]["image"] = "\\Prod_images\\" + cboCatagoryId.SelectedText
                            + "\\" + filename;
                    }
                    DataRow drLog = ds.Tables["log_info"].NewRow();
                    drLog["username"] = Login.username;
                    drLog["type"] = "修改";
                    drLog["action_date"] = DateTime.Now;
                    drLog["action_table"] = "dishes表";
                    ds.Tables["log_info"].Rows.Add(drLog);
                    try
                    {
                        SqlCommandBuilder dbDishes = new SqlCommandBuilder(daDishes);
                        daDishes.Update(ds, "dishes_info");
                        SqlCommandBuilder dbLog = new SqlCommandBuilder(daLog);
                        
                        daLog.Update(ds, "log_info");
                        MessageBox.Show("修改成功");
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

        private void pic_Dishes_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Upate_dishes_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“selesDataSet13.taste”中。您可以根据需要移动或移除它。
            this.tasteTableAdapter.Fill(this.selesDataSet13.taste);
            // TODO: 这行代码将数据加载到表“selesDataSet12.Classification”中。您可以根据需要移动或移除它。
            this.classificationTableAdapter.Fill(this.selesDataSet12.Classification);
            init();
            showAll();
        }
    }
}
