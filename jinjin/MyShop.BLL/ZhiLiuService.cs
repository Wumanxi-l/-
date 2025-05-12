using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop1.DAL;
using System.Data.Linq.SqlClient;

namespace MyShop.BLL
{
    public class ZhiLiuService
    {
        MyShop1DataContext db = new MyShop1DataContext();

        // 判断快递滞留表中是否存在输入的快递单号
        public bool IsEmailExist(string number)
        {
            快递滞留表 zhiliu = (from c in db.快递滞留表
                           where c.快递单号 == number/* && c.用户手机号码 == phone2*/
                            select c).FirstOrDefault();
            if (zhiliu != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<快递滞留表> GetAllProduct()
        {
            return (from c in db.快递滞留表
                    select c).ToList();
        }

        public 快递滞留表 GetProductByProductId(string number)
        {
            return (from c in db.快递滞留表
                    where c.快递单号 == number
                    select c).First();
        }

        // 模糊查找快递单号，再返回满足条件的快递单号列表
        public List<快递滞留表> GetProductBySearchText(string searchText)
        {
            return (from c in db.快递滞留表
                    where SqlMethods.Like(c.快递单号, "%" + searchText + "%")
                    select c).ToList();
        }

        // IsExitProduct()判断是否存在指定的商品
        public bool IsExitProduct(string number)
        {
            var numbers = from c in db.快递滞留表
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
