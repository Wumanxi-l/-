using CabinetXt.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetXt.BLL
{
    public class TimePayService
    {
        CabinetXtDataContext db = new CabinetXtDataContext();
        public void querytime(int pkgid, string pkgordnum, string Consigneename, string cabinetid)
        {
            TimePay tp = new TimePay();
            tp.package_id = pkgid;
            tp.package_OrderNumber = pkgordnum;
            tp.Consignee_name = Consigneename;
            tp.DeliveryTime = DateTime.Now;
            tp.cabinet_id = cabinetid;

            db.TimePay.InsertOnSubmit(tp);
            db.SubmitChanges();
        }

        public int cation(string name)
        {
            List<Package> orderl = (from c in db.Package
                                 where c.Consignee_name == name
                                 select c).ToList();

            if (orderl != null)
            {
                return orderl[orderl.Count - 1].package_id;
            }
            else
            {
                return 0;
            }

        }
        public int returns(int ID)
        {
            TimePay orderl = (from o in db.TimePay
                             where o.Pay_ID == ID
                             select o).FirstOrDefault();

            if (orderl != null)
            {
                return (int)orderl.package_id;
            }
            else
            {
                return 0;
            }

        }
        public List<TimePay> GetAllOrder()
        {
            return db.TimePay.ToList();
        }

        //根据取件码搜索数据库，return pkgid
        public int querytpCode(string code)
        {
            //查询数据库里的code对应的id值
            var id = db.Package
                     .Where(c => c.cabinet_qcode == code)
                     .Select(c => c.package_id)
                     .FirstOrDefault();
            return id;
        }

        //获取取件的时间和时间个数，还有金额
        public void UpdateTime(int id)
        {
            TimePay order = (from o in db.TimePay
                            where o.package_id ==id
                            select o).First();
            order.pickupTime = DateTime.Now;
            db.SubmitChanges();
        }

        //获取时间
        public void UpdateTimeNumber(int id)
        {
            var query = (from o in db.TimePay
                         where o.package_id == id
                         select new { o.DeliveryTime, o.pickupTime }).FirstOrDefault(); // 使用FirstOrDefault来获取单个结果

            if (query != null)
            {
                DateTime startTime = (DateTime)query.DeliveryTime;
                DateTime endTime = (DateTime)query.pickupTime;
                TimeSpan timeDifference = endTime - startTime;
                double hoursDifference = Math.Ceiling(timeDifference.TotalHours); // 使用 Math.Celling 进行向上取整
                if (hoursDifference < 1)
                {
                    hoursDifference = 1; // 如果时间差小于1小时，则按1小时计算
                }

                TimePay order = db.TimePay.FirstOrDefault(o => o.package_id == id);
                if (order != null)
                {
                    order.time = (int?)hoursDifference; // 将时间差保存到数据库中
                    db.SubmitChanges();
                }
            }
        }
        //获取cabinetid，计算价格
        public string queryCabinet(string code)
        {
            //查询数据库里的code对应的id值
            var id = db.Package
                     .Where(c => c.cabinet_qcode == code)
                     .Select(c => c.cabinet_id)
                     .FirstOrDefault();
            return id;
        }
        public int queryPrice(string id)
        {

            //查询数据库里的cabinet对应的price值
            var price = db.Cabinet
                     .Where(c => c.cabinet_id ==id)
                     .Select(c => c.cabinet_price)
                     .FirstOrDefault();
            return (int)price;
        }
        public int queryhour(int id)
        {
            var hour = db.TimePay
                .Where(c => c.package_id == id)
                     .Select(c => c.time)
                     .FirstOrDefault();
            return (int)hour;
        }
        //插入金额
        public void UpdateTimePay(int pkgid, float tpay,int latetime,float lateprice)
        {
            var existingTimePay = db.TimePay.SingleOrDefault(tp => tp.package_id == pkgid);
            if (existingTimePay != null)
            {
                existingTimePay.timeprice = tpay;
                existingTimePay.latetime = latetime;
                existingTimePay.Latefees = lateprice;
                db.SubmitChanges();
            }
        }
        //查询时间
        public string queryDeliveryTime(int id)
        {
            var query = (from o in db.TimePay
                         where o.package_id == id
                         select o.DeliveryTime.ToString()).FirstOrDefault(); // 将DateTime类型转换为字符串
            return query;
        }
        public string queryPickupTime(int id)
        {
            var query = (from o in db.TimePay
                         where o.package_id == id
                         select o.pickupTime.ToString()).FirstOrDefault(); // 将DateTime类型转换为字符串
            return query;
        }
        //查询订单编号
        public string queryOrderNum(int id)
        {
            var query = (from o in db.TimePay
                         where o.package_id == id
                         select o.package_OrderNumber).FirstOrDefault(); // 将DateTime类型转换为字符串
            return query;
        }


    }
}
