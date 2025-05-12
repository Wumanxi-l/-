using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop1.DAL;
using System.Data.Linq.SqlClient;

namespace MyShop.BLL
{
    public class WuLiuService
    {
        MyShop1DataContext db = new MyShop1DataContext();

        // 判断快递物流信息中是否存在输入的快递单号
        public bool IsEmailExist(string number)
        {
            快递物流信息 wuliu = (from c in db.快递物流信息
                             where c.快递单号 == number/* && c.用户手机号码 == phone2*/
                             select c).FirstOrDefault();
            if (wuliu != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 向MyPetShop数据库中的快递物流信息插入新快递物记录
        public void Insert(string number, string name1, string address1, string name2, string address2, string information)
        {
            快递物流信息 wuliu = new 快递物流信息
            {
                快递单号 = number,
                收货人 = name1,
                收货地址 = address1,
                寄件人 = name2,
                发货地址 = address2,
                物流信息 = information
            };
            db.快递物流信息.InsertOnSubmit(wuliu);
            db.SubmitChanges();
        }

        public List<快递物流信息> GetAllProduct()
        {
            return (from c in db.快递物流信息
                    select c).ToList();
        }

        public 快递物流信息 GetProductByProductId(string number)
        {
            return (from c in db.快递物流信息
                    where c.快递单号 == number
                    select c).First();
        }

        // 模糊查找快递单号，再返回满足条件的快递单号列表
        public List<快递物流信息> GetProductBySearchText(string searchText)
        {
            return (from c in db.快递物流信息
                    where SqlMethods.Like(c.快递单号, "%" + searchText + "%")
                    select c).ToList();
        }

        // IsExitProduct()判断是否存在指定的商品
        public bool IsExitProduct(string number)
        {
            var numbers = from c in db.快递物流信息
                           where c.快递单号 == number
                           select c;
            if (numbers.Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
