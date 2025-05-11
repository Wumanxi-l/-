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



namespace 点餐管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int flag = 1;
        public static bool Aflag = false;
        public static string Dishes_ID="";
        void showAllDishes()
        {
            DB.GetCn();
            string str = "select * from Dishes";
            SqlCommand cmd = new SqlCommand(str, DB.cn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int index = dgvDishes.Rows.Add();
                dgvDishes.Rows[index].Cells[0].Value = rdr[0];
                dgvDishes.Rows[index].Cells[1].Value = rdr[1];
                dgvDishes.Rows[index].Cells[2].Value = rdr[2];
                dgvDishes.Rows[index].Cells[3].Value = rdr[3];
                dgvDishes.Rows[index].Cells[4].Value = rdr[4];
                dgvDishes.Rows[index].Cells[5].Value = rdr[9];
                try
                {
                    Image imageColum = Image.FromFile(Application.StartupPath + rdr[7]);
                    dgvDishes.Rows[index].Cells["Column6"].Value = imageColum;
                }
                catch
                {
                    Image imageColum = Image.FromFile(Application.StartupPath + "//" + "暂无图片.gif");
                    dgvDishes.Rows[index].Cells["Column6"].Value = imageColum;
                }
            }
            rdr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.ShowDialog();
            if (flag == 1)
            {
                this.Visible = true;
                label5.Text = Login.username;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDishes.RowTemplate.Height = 90;
            showAllDishes();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvDishes.Rows.Clear();
            showAllDishes();
        }

        private void btnSearch1_Click(object sender, EventArgs e)//按菜品名称关键字查询
        {
            if (txtDName.Text == "")
            {
                MessageBox.Show("请输入查询关键字");
            }
            else
            {
                dgvDishes.Rows.Clear();
                DB.GetCn();
                string str = "select * from Dishes where Dishes_Name like '%" + txtDName.Text + "%'";
                SqlCommand cmd = new SqlCommand(str, DB.cn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int index = dgvDishes.Rows.Add();
                    dgvDishes.Rows[index].Cells[0].Value = rdr[0];
                    dgvDishes.Rows[index].Cells[1].Value = rdr[1];
                    dgvDishes.Rows[index].Cells[2].Value = rdr[2];
                    dgvDishes.Rows[index].Cells[3].Value = rdr[3];
                    dgvDishes.Rows[index].Cells[4].Value = rdr[4];
                    dgvDishes.Rows[index].Cells[5].Value = rdr[9];
                    try
                    {
                        Image imageColum = Image.FromFile(Application.StartupPath + rdr[7]);
                        dgvDishes.Rows[index].Cells["Column6"].Value=imageColum;
                    }
                    catch
                    {
                        Image imageColum = Image.FromFile(Application.StartupPath + "//" + "暂无图片.gif");
                        dgvDishes.Rows[index].Cells["Column6"].Value = imageColum;
                    }
                }
                rdr.Close();
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)//按菜品价格区间查询
        {
            dgvDishes.Rows.Clear();
            string str = "";
            DB.GetCn();
            int i = comboBox1.SelectedIndex;
            switch (i)
            {
                case 0:
                    str = "Unit_Price<=10";
                    break;
                case 1:
                    str = "Unit_Price>10 and Unit_Price<20";
                    break;
                case 2:
                    str = "Unit_Price>20 and Unit_Price<30";
                    break;
                case 3:
                    str = "Unit_Price>30 and Unit_Price<40";
                    break;
                case 4:
                    str = "Unit_Price>40 and Unit_Price<50";
                    break;
                default:
                    str = "Unit_Price>50";
                    break;
            }
            string sdr = "select * from Dishes where " + str + "";
            SqlCommand cmd =new SqlCommand(sdr, DB.cn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int index = dgvDishes.Rows.Add();
                dgvDishes.Rows[index].Cells[0].Value = rdr[0];
                dgvDishes.Rows[index].Cells[1].Value = rdr[1];
                dgvDishes.Rows[index].Cells[2].Value = rdr[2];
                dgvDishes.Rows[index].Cells[3].Value = rdr[3];
                dgvDishes.Rows[index].Cells[4].Value = rdr[4];
                dgvDishes.Rows[index].Cells[5].Value = rdr[9];
                try
                {
                    Image imageColum = Image.FromFile(Application.StartupPath + rdr[7]);
                    dgvDishes.Rows[index].Cells["Column6"].Value = imageColum;
                }
                catch
                {
                    Image imageColum = Image.FromFile(Application.StartupPath + "//" + "暂无图片.gif");
                    dgvDishes.Rows[index].Cells["Column6"].Value = imageColum;
                }
            }
            rdr.Close();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            Register r1 = new Register();
            r1.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvDishes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CIndex = e.ColumnIndex;
            //如果是第8列，查看详细信息
            if (CIndex == 7)
            {
                //确定是第几行
                int rowindex = e.RowIndex;
                Dishes_ID=dgvDishes.Rows[rowindex].Cells[0].Value.ToString();
                Tdishess t1 = new Tdishess();
                t1.ShowDialog();
            }
            //如果是第9列，加入购物车
            if (CIndex == 8)
            {
                if (Aflag == false)
                {
                    MessageBox.Show("请先登录");
                    Login l1 = new Login();
                    l1.ShowDialog();
                }
                else
                {
                    //确定是第几行
                    int rowindex = e.RowIndex;
                    Dishes_ID = dgvDishes.Rows[rowindex].Cells[0].Value.ToString();
                    if (Convert.ToInt32(dgvDishes.Rows[rowindex].Cells[5].Value ) < 1)
                    {
                        MessageBox.Show("该菜品暂时缺货");
                    }
                    else
                    {
                        ShopCart s1 = new ShopCart();
                        s1.ShowDialog();
                    }
                }
            }
            //如果是第10行，查看点评
            if (CIndex == 9)
            {
                int rowindex = e.RowIndex;
                Dishes_ID = dgvDishes.Rows[rowindex].Cells[0].Value.ToString();
                dianping d1 = new dianping();
                d1.ShowDialog();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (Aflag == false)
            {
                MessageBox.Show("请先登录");
                Login l1 = new Login();
                l1.ShowDialog();
            }
            else
            {
                myorders or1 = new myorders();
                or1.ShowDialog();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Aflag == false)
            {
                MessageBox.Show("请先登录");
                Login l1 = new Login();
                l1.ShowDialog();
            }
            else
            {
                ToEmail tm = new ToEmail();
                tm.ShowDialog();
            }
        }
    }
}
