using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop1.DAL;

namespace MyShop.BLL
{
    public class KuaidiService
    {
        MyShop1DataContext db = new MyShop1DataContext();

        // 判断寄件信息表中是否存在输入的用户名和寄件地址
        public bool IsEmailExist(string name, string address)
        {
            寄件信息表 express = (from c in db.寄件信息表
                             where c.用户名 == name && c.寄件地址 == address
                             select c).FirstOrDefault();
            if (express != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 向MyPetShop数据库中的寄件信息表插入新用户记录
        public void Insert(string name,  string phone, string address, string type, string remark,string time)
        {
            寄件信息表 express = new 寄件信息表
            {
                用户名 = name,
                手机号码 = phone,
                寄件地址 = address,
                智能柜类型 = type,
                物品类型 = remark,
                预约日期 = time
                
            };
            db.寄件信息表.InsertOnSubmit(express);
            db.SubmitChanges();
        }

    }
}
