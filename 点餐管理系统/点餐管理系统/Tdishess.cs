using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 点餐管理系统
{
    public partial class Tdishess : Form
    {
        public Tdishess()
        {
            InitializeComponent();
        }

        private void Tdishess_Load(object sender, EventArgs e)
        {
            DB.GetCn();
            string str = "select * from Dishes where Dishes_ID=" + Form1.Dishes_ID + "";
            DataTable dt = DB.GetDataSet(str);

            lblDishesId.Text = Form1.Dishes_ID;
            lblCatagoryId.Text = dt.Rows[0][2].ToString();
            lblPrice.Text = dt.Rows[0][3].ToString();
            lblName.Text= dt.Rows[0][1].ToString();
            lblDescn.Text= dt.Rows[0][6].ToString();
            lblTaste.Text= dt.Rows[0][4].ToString();
            lblSales.Text= dt.Rows[0][5].ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + dt.Rows[0][7].ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\" + "暂无图片.gif");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
