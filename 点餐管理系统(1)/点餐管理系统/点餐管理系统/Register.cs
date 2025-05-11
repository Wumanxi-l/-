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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else
            {
                DB.GetCn();
                string str = "select * from Customers where Customers_Name='" 
                    + txtName.Text + "'";
                DataTable dt = DB.GetDataSet(str);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("此用户名已存在，请重新输入");
                }
                else
                {
                    string sdr = "insert into Customers(Customers_Name,Customers_Password,email)values('"
                        +txtName.Text + "','" + txtPassword.Text + "','" + txtEmail.Text + "')";
                    DB.sqlEx(sdr);
                    MessageBox.Show("注册成功");
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
