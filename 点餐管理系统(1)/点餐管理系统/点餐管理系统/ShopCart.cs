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

namespace 点餐管理系统
{
    public partial class ShopCart : Form
    {
        public ShopCart()
        {
            InitializeComponent();
        }
        public static decimal profit = 0;//利润
        
        SqlDataAdapter daCartItem, daDishes;
        DataSet ds = new DataSet();

        CartItemsv cartSrv = new CartItemsv();
        void init()
        {
            DB.GetCn();
            string str = "select CartItemID,Customers_id,Dishes_ID,Dishes_Name,Unit_Price,Qty from CartItem where Customers_id="
                + Convert.ToInt32(Login.Customers_id)+"";
            daCartItem = new SqlDataAdapter(str, DB.cn);
            daCartItem.Fill(ds, "CartItem_info");
            string sdr = "select * from Dishes";
            daDishes = new SqlDataAdapter(sdr, DB.cn);
            daDishes.Fill(ds, "dishes_info");
        }
        void showXz()//选择列
        {
            DataGridViewCheckBoxColumn acCode = new DataGridViewCheckBoxColumn();
            acCode.Name = "acCode";
            acCode.HeaderText = "选择";
            dgvCart.Columns.Add(acCode);
        }
        void dgvHead()
        {
            dgvCart.Columns[0].HeaderText = "购物车编号";
            dgvCart.Columns[1].HeaderText = "用户编号";
            dgvCart.Columns[2].HeaderText = "菜品编号";
            dgvCart.Columns[3].HeaderText = "菜品名称";
            dgvCart.Columns[4].HeaderText = "价格";
            dgvCart.Columns[5].HeaderText = "购买数量";        
        }
        protected void Bind()
        {
            init();
            lblTotalPrice.Text = cartSrv.GetTotalPriceByCustomersId(Convert.ToInt32(Login.Customers_id)).Item1.ToString();
            profit = cartSrv.GetTotalPriceByCustomersId(Convert.ToInt32(Login.Customers_id)).Item2;//计算利润
            DataView dvCartItem = new DataView(ds.Tables["CartItem_info"]);
            dgvCart.DataSource = dvCartItem;
            dgvHead();
            showXz();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)//多选转单选
        {
            if (dgvCart.Rows.Count > 0)
            {
                for(int i = 0; i < dgvCart.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell ck = dgvCart.Rows[i].Cells["acCode"] as DataGridViewCheckBoxCell;
                    if (i != e.RowIndex)
                    {
                        ck.Value = false;
                    }
                    else
                    {  
                        ck.Value = true;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = dgvCart.Rows.Count;
            for(int i = 0; i < dgvCart.Rows.Count; i++)
            {
                if (dgvCart.Rows[i].Cells["acCode"].EditedFormattedValue.ToString() == "True")
                {
                    dgvCart.Rows.RemoveAt(i);
                    UpdateDB();//更新数据源
                }
                else
                {
                    s = s - 1;
                }
            }
            if (s == 0)
            {
                MessageBox.Show("请先选择要删除的项");
            }
        }
        void UpdateDB()
        {
            try
            {
                SqlCommandBuilder dbCartItem = new SqlCommandBuilder(daCartItem);
                daCartItem.Update(ds, "CartItem_info");
                SqlCommandBuilder dbDishes = new SqlCommandBuilder(daDishes);
                daDishes.Update(ds, "dishes_info");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)//重新计算总价
        {
            lblTotalPrice.Text = cartSrv.GetTotalPriceByCustomersId(Convert.ToInt32(Login.Customers_id)).Item1.ToString();
            profit = cartSrv.GetTotalPriceByCustomersId(Convert.ToInt32(Login.Customers_id)).Item2;
        }

        private void ShopCart_Load(object sender, EventArgs e)
        {
            DB.GetCn();
            cartSrv.Add(Convert.ToInt32(Login.Customers_id), Convert.ToInt32(Form1.Dishes_ID), 1);
            Bind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear_cartItem();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("请先添加菜品到购物车");
            }
            else
            {
                List<int> List_index = new List<int>();
                for(int i = 0; i < dgvCart.Rows.Count - 1; i++)
                {
                    List_index.Add(i);
                }
                foreach(int n in List_index)
                {
                    string str = dgvCart.Rows[n].Cells["Dishes_ID"].Value.ToString();
                    DataRow[] CustRow = ds.Tables["dishes_info"].Select("Dishes_ID='" + str + "'");
                    CustRow[0]["Qty"] = (Convert.ToInt32(CustRow[0]["Qty"]) - Convert.ToInt32(dgvCart.Rows[n].Cells["Qty"].Value)).ToString();
                }
                UpdateDB();
                Clear_cartItem();
                this.Close();
                SubmitCart s1 = new SubmitCart();
                s1.ShowDialog();
            }
        }

        void Clear_cartItem()
        {
            List<int> List_index = new List<int>();
            if (dgvCart.Rows.Count > 0)
            {
                for(int i = 0; i < dgvCart.Rows.Count - 1; i++)
                {
                    List_index.Add(i);
                }
                int z = 0;
                foreach(int n in List_index)
                {
                    dgvCart.Rows.RemoveAt(n-z);
                    z++;
                }
                UpdateDB();
            }
        }
    }
}
