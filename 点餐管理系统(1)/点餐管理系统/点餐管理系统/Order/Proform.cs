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
using System.Windows.Forms.DataVisualization.Charting;

namespace 点餐管理系统.Order
{
    public partial class Proform : Form
    {
        public Proform()
        {
            InitializeComponent();
        }
        SqlDataAdapter daEmployee, daProform;
        DataSet ds = new DataSet();
        void init()
        {
            DB.GetCn();
            string str = "select employee_Name 员工姓名,count(Order_ID) 订单数,sum(profit) 总利润 from employee as e,Orders as o where e.employee_id=o.employee_id and Status='已审核' group by e.employee_Name";
            string sdr = "select * from employee";
            daProform = new SqlDataAdapter(str, DB.cn);
            daEmployee = new SqlDataAdapter(sdr, DB.cn);
            daProform.Fill(ds, "profrom_info");
            daEmployee.Fill(ds, "employee_info");
        }

        private void Proform_Load(object sender, EventArgs e)
        {
            init();
            showAll();
            string[] xname = new string[ds.Tables["profrom_info"].Rows.Count];
            double[] yprofit = new double[ds.Tables["employee_info"].Rows.Count];
            for(int i = 0; i < ds.Tables["profrom_info"].Rows.Count; i++)
            {
                xname[i] = ds.Tables["profrom_info"].Rows[i][0].ToString();
                yprofit[i] = double.Parse( ds.Tables["profrom_info"].Rows[i][2].ToString());
            }
            DisplayChart(xname, yprofit, "员工业绩图");
        }
        void DisplayChart(string[] xlabels, double[] yvalues,string serName)
        {
            chart1.Series.Clear();
            Series col = new Series(serName);
            for (int i = 0; i < xlabels.Length; i++)
            {
                DataPoint dp = new DataPoint(i, yvalues);
                dp.AxisLabel = xlabels[i];
                col.Points.Add(dp);
            }
            chart1.Series.Add(col);
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.Invalidate();
        }

        private void btncance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void showAll()
        {
            DataView dvProform = new DataView(ds.Tables["profrom_info"]);
            dgvprofrom.DataSource = dvProform;
            DataView dvEmployee = new DataView(ds.Tables["employee_info"]);
            dgvEmployee.DataSource = dvEmployee;
        }

    }
}
