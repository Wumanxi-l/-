using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop1.DAL;

namespace MyShop.BLL
{
    public class ToufanService
    {
        MyShop1DataContext db = new MyShop1DataContext();

        // 判断快递信息表中是否存在输入的快递员手机号码和用户手机号码
        public bool IsEmailExist(string phone1, string phone2)
        {
            快递信息表 toufan = (from c in db.快递信息表
                            where c.快递员手机号码 == phone1 && c.用户手机号码 == phone2
                              select c).FirstOrDefault();
            if (toufan != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 向MyPetShop数据库中的快递信息表插入新用户记录
        public void Insert(string number,string name, string phone1,string phone2,string type, string time)
        {
            快递信息表 toufan = new 快递信息表
            {
                快递单号 = number,
                快递员姓名 = name,
                快递员手机号码 = phone1,
                用户手机号码 = phone2,
                智能柜类型 = type,
                存放时间 = time
            };
            db.快递信息表.InsertOnSubmit(toufan);
            db.SubmitChanges();
        }

        //判断输入的用户名是否重名
        public bool IsNameExist(string name)
        {
            //通过MyPetShop.DAL数据访问层中的Customer类查询输入的用户名是否重名，若重名则返回用户对象，否则返回null
            快递信息表 customer = (from c in db.快递信息表
                              where c.快递单号 == name
                              select c).FirstOrDefault();
            if (customer != null)
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
