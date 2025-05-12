using CabinetXt.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CabinetXt.BLL
{
    public class cabinetService
    {
        CabinetXtDataContext db = new CabinetXtDataContext();

        public string queryNoUse(string size)
        {

            //从数据查询没有存储的快递盒子
            var ids = from c in db.Cabinet
                                where c.cabinet_size == size && c.cabinet_status == "未使用"
                                select c.cabinet_id;
            //判断集合是否为空
            if (ids.Count() > 0 || ids != null)
            {
                //不为空
                int length = 0;
                List<string> list = new List<string>();
                foreach ( string id in ids )
                {
                    list.Add( id );
                    length++;
                }
                //在集合种获取随机数
                Random r = new Random();
                //获取随机数中的id
                int idNum = r.Next( length);
                //获取改箱子的id
                if (list ==  null || list.Count == 0 ) {
                    return null;
                }
                string cabinetId = list[idNum];
                //将cabinetId返回
                return cabinetId;
            }
            //为空就返回null
            return null;
        }
        public string GenerateUniquePickupCode()
        {
            Guid guid = Guid.NewGuid();
            string pickupCode = Convert.ToBase64String(guid.ToByteArray());
            pickupCode = pickupCode.Replace("=", "").Replace("+", "").Replace("/", "");
            return pickupCode.Substring(0, 6);
        }
        public  List<Cabinet>  queryAllUser()
        {
            //遍历所有快递柜
            //查询所哟使用的快递柜并返回list集合
            List<Cabinet> cabinets  = (from c in db.Cabinet
                     where c.cabinet_status == "使用"
                     select c).ToList();
            return cabinets;
        }
        public string queryCode(string code)
        {
            //查询数据库里的code对应的id值
            var id = db.Send
                     .Where(c => c.cabinet_jcode == code)
                     .Select(c => c.cabinet_id)
                     .FirstOrDefault();

          
            return id;
        }
        public string queryqCode(string code)
        {
            //查询数据库里的code对应的id值
            var id = db.Package
                     .Where(c => c.cabinet_qcode == code)
                     .Select(c => c.cabinet_id)
                     .FirstOrDefault();


            return id;
        }



        //更改数据库快递柜状态
        public void UpdateStatus(string cabinetid)
        {
            Cabinet cabinet = (from p in db.Cabinet
                                   where p.cabinet_id == cabinetid
                                   select p).First();
            cabinet.cabinet_status = "使用";
            db.SubmitChanges();
        }

        public void CUpdateStatus(string cabinetid)
        {
            Cabinet cabinet = (from p in db.Cabinet
                               where p.cabinet_id == cabinetid
                               select p).First();
            cabinet.cabinet_status = "未使用";
            db.SubmitChanges();
        }
    }


    }

