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
using System.Security.Cryptography;

namespace 点餐管理系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string username = "";
        public static string Customers_id = "";
        public static string employee_id = "";

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // 将密码字符串转换为字节数组
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // 将字节数组转换为十六进制字符串形式的哈希值
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            userserive us = new userserive();
            if (txtName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("请输入用户名或密码");
            }
            else
            {
                string hashedPassword = HashPassword(txtPassword.Text);  // 对输入的密码进行哈希处理
                DB.GetCn();
                if (radioButton1.Checked)
                {
                    if (us.CheckCustomer(txtName.Text, txtPassword.Text) == true)
                    {
                        MessageBox.Show("登录成功");
                        username = txtName.Text;
                        Form1.Aflag = true;
                        Form1.flag = 1;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                 }
            
                else if (radioButton2.Checked)
                {
                    if (us.checkEmployee(txtName.Text, txtPassword.Text) == true)
                    {
                        MessageBox.Show("登录成功");
                        username = txtName.Text;
                        Form1.flag = 2;
                        this.Close();
                        Tindex t1 = new Tindex();
                        t1.Show();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                }
                else
                {
                    if (us.checkUser(txtName.Text, txtPassword.Text, 1) == true)
                    {
                        MessageBox.Show("登录成功");
                        username = txtName.Text;
                        Form1.flag = 2;
                        this.Close();
                        Tindex t1 = new Tindex();
                        t1.Show();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误");
                    }
                }
            }
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
