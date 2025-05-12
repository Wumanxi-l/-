using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop1.DAL;
using MyShop.BLL;

namespace MyShop.BLL
{
    public class CabinetService
    {
        MyShop1DataContext db = new MyShop1DataContext();

        public string queryNoUse(string type)
        {
            //从数据查询没有存储的快递盒子
            var ids = from c in db.快递柜表
                     where c.智能柜类型 == type && c.Status == "未使用"
                     select c.智能柜ID;
            //判断集合是否为空
            if (ids.Count() > 0 || ids != null)
            {
                //不为空
                int length = 0;
                List<string> list = new List<string>();
                foreach (string id in ids)
                {
                    list.Add(id);
                    length++;
                }
                //在集合种获取随机数
                Random random = new Random();
                //获取随机数中的id
                int idNum = random.Next(length);
                //获取改箱子的id
                if (list == null || list.Count == 0)
                {
                    return null;
                }
                string cabinetId = list[idNum];
                //将cabinetId返回
                return cabinetId;
            }
            //为空就返回null
            return null;
        }

        //唯一的取件码
        //public string GenerateUniquePickupCode()
        //{
        //    Guid guid = Guid.NewGuid();
        //    string pickupCode = Convert.ToBase64String(guid.ToByteArray());
        //    pickupCode = pickupCode.Replace("=", "").Replace("+", "").Replace("/", "");
        //    return pickupCode.Substring(0, 6);
        //}

        public List<快递柜表> queryAllUser()
        {
            //遍历所有快递柜
            //查询所哟使用的快递柜并返回list集合
            List<快递柜表> cabinets = (from c in db.快递柜表
                                   where c.Status == "使用"
                                      select c).ToList();
            return cabinets;
        }

        //用户取快递
        public string queryqCode(string code)
        {
            //查询数据库里的code对应的id值
            var id = db.取件订单信息表
                     .Where(c => c.取件码 == code)
                     .Select(c => c.智能柜ID)
                     .FirstOrDefault();
            return id;
        }

        //快递员寄快递
        public string querytCode(string code)
        {
           //查询数据库里的code对应的id值
            var id = db.取件订单信息表
                     .Where(c => c.存放码 == code)
                    .Select(c => c.智能柜ID)
                    .FirstOrDefault();
            return id;
        }

        //用户寄快递
        public string queryCode(string code)
        {
            //查询数据库里的code对应的id值
            var id = db.寄件订单信息表
                     .Where(c => c.寄件码 == code)
                     .Select(c => c.智能柜ID)
                     .FirstOrDefault();
            return id;
        }

        //更改数据库快递柜状态
        public void UpdateStatus(string cabinetid)
        {
            快递柜表 cabinet = (from c in db.快递柜表
                            where c.智能柜ID == cabinetid
                               select c).First();
            cabinet.Status = "使用";
            db.SubmitChanges();
        }

        public void CUpdateStatus(string cabinetid)
        {
            快递柜表 cabinet = (from c in db.快递柜表
                            where c.智能柜ID == cabinetid
                               select c).First();
            cabinet.Status = "未使用";
            db.SubmitChanges();
        }
    }
}
