using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop1.DAL;

namespace MyShop.BLL
{
    public class JijianService
    {
        MyShop1DataContext db = new MyShop1DataContext();

        // 判断寄件信息表中是否存在输入的用户名和寄件码
        public bool IsEmailExist(string number1, string number2)
        {
            寄件订单信息表 kuaidi = (from c in db.寄件订单信息表
                              where c.智能柜ID == number1 && c.寄件码 == number2
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
        public void Insert(string number1, string number2)
        {
            寄件订单信息表 kuaidi = new 寄件订单信息表
            {
                智能柜ID = number1,
                寄件码 = number2
            };
            //kuaidi.智能柜ID = cabinetid;
            db.寄件订单信息表.InsertOnSubmit(kuaidi);
            db.SubmitChanges();
        }

        public void PkgUpdateStatus(string cabinetid)
        {
            寄件订单信息表 kuaidi = (from c in db.寄件订单信息表
                              where c.智能柜ID == cabinetid
                              select c).First();
            kuaidi.Status = "已寄出";
            db.SubmitChanges();
        }
    }
}
