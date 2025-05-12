using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop1.DAL;

namespace MyShop.BLL
{
    public class CustomerService
    {
        MyShop1DataContext db = new MyShop1DataContext();

        public int CheckLogin(string name, string password)
        {
            //通过MyPetShop.DAL数据访问层中用户类查询输入的用户名和密码是否输入正确
            用户表 customer = (from c in db.用户表
                            where c.Name == name && c.Password == password
                            select c).FirstOrDefault();
            if (customer != null)//用户名和密码正确
            {
                return customer.CustomerId;
            }
            else//用户名和密码错误
            {
                return 0;
            }
        }

        // 修改用户Id对应用户的密码
        public void ChangePassword(int customerId, string password)
        {
            用户表 customer = (from c in db.用户表
                            where c.CustomerId == customerId
                            select c).First();
            customer.Password = password;

            db.SubmitChanges();
        }

        // 将用户密码重置为相应的用户名
        public void ResetPassword(string name, string email)
        {
            用户表 customer = (from c in db.用户表
                            where c.Name == name && c.Email == email
                            select c).First();
            customer.Password = name;
            db.SubmitChanges();
        }

        // 判断输入的用户名是否重名
        public bool IsNameExist(string name)
        {
            //通过MyPetShop.DAL数据访问层中的Customer类查询输入的用户名是否重名，若重名则返回用户对象，否则返回null
            用户表 customer = (from c in db.用户表
                            where c.Name == name
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

        // 判断Customer表中是否存在输入的用户名和邮箱
        public bool IsEmailExist(string name, string email)
        {
            用户表 customer = (from c in db.用户表
                            where c.Name == name && c.Email == email
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

        // 向MyPetShop数据库中的用户表插入新用户记录
        public void Insert(string name, string password, string email, string phone, string address)
        {
            用户表 customer = new 用户表
            {
                Name = name,
                Password = password,
                Email = email,
                手机号码=phone,
                地址=address
            };
            db.用户表.InsertOnSubmit(customer);
            db.SubmitChanges();
        }
    }
}
