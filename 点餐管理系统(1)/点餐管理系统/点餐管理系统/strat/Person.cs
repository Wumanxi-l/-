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
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Person_Load(object sender, EventArgs e)
        {
            DB.GetCn();
            string str = "select * from employee where employee_Name='" + Login.username + "'";
            DataTable dt = DB.GetDataSet(str);
            txtId.Text = dt.Rows[0][0].ToString();
            txtName.Text = dt.Rows[0][1].ToString();
            txtSex.Text = dt.Rows[0][4].ToString();
            dtpBirth.Value = Convert.ToDateTime(dt.Rows[0][5]);
            dtpHire.Value = Convert.ToDateTime(dt.Rows[0][6]);
            txtPhone.Text = dt.Rows[0][7].ToString();
            txtAddess.Text = dt.Rows[0][10].ToString();
            txtWages.Text = dt.Rows[0][8].ToString();
            txtDepartment.Text = dt.Rows[0][11].ToString();
            txtResumes.Text = dt.Rows[0][9].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DB.GetCn();
            string str = "update employee set employee_Name='" + txtName.Text
                + "',sex='" + txtSex.Text
                + "',Birth_Date='" + dtpBirth.Value
                + "',Hire_Date='" + dtpHire.Value
                + "',Addess='" + txtAddess.Text
                + "',Telephone='" + txtPhone.Text
                + "',wages=" + Convert.ToInt32(txtWages.Text)
                + ",Department='" + txtDepartment.Text
                + "',resume='" + txtResumes.Text + "'where employee_id="
                + Convert.ToInt32(txtId.Text) + "";
            DB.sqlEx(str);
            MessageBox.Show("修改成功");
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtWages_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
