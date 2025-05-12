using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop1.DAL;

namespace MyShop.BLL
{
    public class QujianService
    {
        MyShop1DataContext db = new MyShop1DataContext();

        // 判断寄件信息表中是否存在输入的用户名和寄件地址
        public bool IsEmailExist(string name, string number)
        {
            取件订单信息表 kuaidi = (from c in db.取件订单信息表
                               where c.用户名 == name && c.取件码 == number
                               select c).FirstOrDefault();
            if (kuaidi != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 向MyPetShop数据库中的用户表插入新用户记录
        public void Insert(string number1, string number, string number2)
        {
            取件订单信息表 kuaidi = new 取件订单信息表
            {
                智能柜ID = number1,
                取件码 = number,
                存放码 = number2
            };
            //kuaidi.智能柜ID = cabinetid;
            db.取件订单信息表.InsertOnSubmit(kuaidi);
            db.SubmitChanges();
        }

        public void PkgUpdateStatus(string cabinetid)
        {
            取件订单信息表 kuaidi = (from c in db.取件订单信息表
                              where c.智能柜ID == cabinetid
                           select c).First();
            kuaidi.Status= "已取出";
            db.SubmitChanges();
        }
    }
}
