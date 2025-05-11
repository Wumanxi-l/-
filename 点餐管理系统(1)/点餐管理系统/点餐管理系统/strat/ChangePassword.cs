using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 点餐管理系统.strat
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtOldPwd.Text == "")
            {
                MessageBox.Show("请输入原密码");
            }
            else
            {
                DB.GetCn();
                string str = "select * from employee where employee_Name='"+txtName.Text
                    +"'and employee_Password='"+ txtOldPwd.Text+"'";
                DataTable dt = DB.GetDataSet(str);
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("原密码错误，请重新输入");
                }
                else
                {
                    if (txtNewPwd.Text != txtNewPwd2.Text)
                    {
                        MessageBox.Show("两次新密码不一致，请重新输入");
                    }
                    else
                    {
                        string sdr = "update employee set employee_Password='" + txtNewPwd.Text
                            + "'where employee_Name'" + txtName.Text + "'";
                        DB.sqlEx(sdr);
                        MessageBox.Show("修改成功！！");
                        this.Close();
                    }
                }
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtName.Text = Login.username;
        }
    }
}
