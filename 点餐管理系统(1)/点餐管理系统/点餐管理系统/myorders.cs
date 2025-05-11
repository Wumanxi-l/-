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
using QRCoder;

namespace 点餐管理系统
{
    public partial class myorders : Form
    {
        public myorders()
        {
            InitializeComponent();
        }
        public class Order
        {
            public int Order_ID { get; set; }
            public string username { get; set; }
            public string Order_Date { get; set; }
            public string remark { get; set; }
        }
        private string connectionString = "Data Source=localhost;Initial Catalog=seles;User ID=sa;Password=123456";  

        private List<Order> GetAllOrders()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = "select * from orders";  // 先获取所有订单数据
                var adapter = new SqlDataAdapter(command);
                var dataSet = new DataSet();
                adapter.Fill(dataSet);

                var orders = (from DataRow row in dataSet.Tables[0].Rows
                              select new Order
                              {
                                  Order_ID = Convert.ToInt32(row["Order_ID"]),
                                  username = row["username"].ToString(),
                                  Order_Date = row["Order_Date"].ToString(),
                                  remark = row["remark"].ToString() 
                              }).ToList();

                return orders.Where(o => o.username == Login.username).ToList();
            }
        }

        void showAll()
        {
            var orders = GetAllOrders();
            dgvOrder.Rows.Clear();
            foreach (var order in orders)
            {
                int index = dgvOrder.Rows.Add();
                dgvOrder.Rows[index].Cells[0].Value = order.Order_ID;
                dgvOrder.Rows[index].Cells[1].Value = order.Order_Date;
                dgvOrder.Rows[index].Cells[2].Value = order.remark;


                string sdr = order.Order_ID.ToString();

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrData = qrGenerator.CreateQrCode(sdr, QRCodeGenerator.ECCLevel.M);
                QRCode qrCode = new QRCode(qrData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                dgvOrder.Rows[index].Cells["Column4"].Value = qrCodeImage;
            }
        }


        private void myorders_Load(object sender, EventArgs e)
        {
            label2.Text = Login.username;
            dgvOrder.RowTemplate.Height = 90;
            showAll();
        }

        private void btndaochu_Click(object sender, EventArgs e)
        {
            ExcelService.ExportExcel("导出信息", dgvOrder);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
