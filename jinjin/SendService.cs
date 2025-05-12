using CabinetXt.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetXt.BLL
{
    public class SendService
    {
        CabinetXtDataContext db = new CabinetXtDataContext();
      
        public void Insert( string Consigneename, string Consigneephone, string Consigneeaddress,string recipentname,string recipentphone,
       string recipentaddress, string companys,string goodsname,string imageFile,string goodweight, string paym, string goodsize ,string sendRemark 
            ,string cabinetid,string qjcode)
        {
            Send se= new Send();
            
            se.Consignee_name = Consigneename;
            se.Consignee_phone= Consigneephone;
            se.Consignee_adree = Consigneeaddress;
            se.recipient_name = recipentname;
            se.recipient_phone = recipentphone;
            se.recipient_address = recipentaddress;
            se.Conmpany = companys;
            se.goods_name = goodsname;
            se.goods_img = imageFile;
            se.good_weight = goodweight;
            se.paymentMethod = paym;
            se.goods_size = goodsize;
            se.send_Remark=sendRemark;
            se.cabinet_id = cabinetid;
            se.cabinet_jcode = qjcode;
            se.package_satus = "已存入";
            se.send_satus = "未接受";
            db.Send.InsertOnSubmit(se);
            db.SubmitChanges();
        }
       
        public void shenhedata(int orderlpid, string name, string Consigneename, string Consigneephone)
        {
            Orderl ord = new  Orderl();
            {
                ord.ParcelID = orderlpid;
                ord.goods_name= name;
                ord.Consignee_name = Consigneename;
                ord.Consignee_phone = Consigneephone;
                ord.orderl_status = "未接受";
                ord.orderl_time = DateTime.Now;

            }
            db.Orderl.InsertOnSubmit(ord);
            db.SubmitChanges();
        }

        public int cation(string name)
        {
            List<Send> orderl = (from c in db.Send
                            where c.Consignee_name== name
                            select c).ToList();

            if (orderl != null)
            {
                return orderl[orderl.Count - 1].ParcelID;
            }
            else
            {
                return 0;
            }

        }


    }
}
