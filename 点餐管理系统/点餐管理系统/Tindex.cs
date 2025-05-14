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
    public partial class Tindex : Form
    {
        public Tindex()
        {
            InitializeComponent();
        }

        private void 密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strat.ChangePassword ch1 = new strat.ChangePassword();
            ch1.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strat.Person p1 = new strat.Person();
            p1.ShowDialog();
        }

        private void 添加菜品信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tdishes.insert_dishes in1 = new Tdishes.insert_dishes();
            in1.ShowDialog();
        }

        private void 修改商品信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tdishes.Upate_dishes u1 = new Tdishes.Upate_dishes();
            u1.ShowDialog();
        }

        private void 删除商品信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tdishes.Delete_dishes d1 = new Tdishes.Delete_dishes();
            d1.ShowDialog();
        }

        private void 审核订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order.Check_Order c1 = new Order.Check_Order();
            c1.ShowDialog();
        }

        private void 查看日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Select_log s1 = new Log.Select_log();
            s1.ShowDialog();
        }

        private void 添加部门信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department.Insert_department i1 = new Department.Insert_department();
            i1.ShowDialog();
        }

        private void 修改部门信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department.Update_department u1 = new Department.Update_department();
            u1.ShowDialog();
        }

        private void 修改部门信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Department.Delect_department d1 = new Department.Delect_department();
            d1.ShowDialog();
        }

        private void 修改客户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer.UpDate_Customer c1 = new customer.UpDate_Customer();
            c1.ShowDialog();
        }

        private void 业绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order.Proform p1 = new Order.Proform();
            p1.ShowDialog();
        }
    }
}
