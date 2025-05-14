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
        void showAll()
        {
            DB.GetCn();
            string str = "select * from orders where username='" + Login.username+"'";
            SqlCommand cmd = new SqlCommand(str,DB.cn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                int index = dgvOrder.Rows.Add();
                dgvOrder.Rows[index].Cells[0].Value = rdr[0];
                dgvOrder.Rows[index].Cells[1].Value = rdr[2];
                dgvOrder.Rows[index].Cells[2].Value = rdr[3];

                string sdr = rdr[0].ToString();

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrData = qrGenerator.CreateQrCode(sdr, QRCodeGenerator.ECCLevel.M);
                QRCode qrCode = new QRCode(qrData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                dgvOrder.Rows[index].Cells["Column4"].Value = qrCodeImage;
            }
            rdr.Close();
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
