using CabinetXt.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetXt.BLL
{
    public class PackageService
    {
        CabinetXtDataContext db = new CabinetXtDataContext();

        public void Insert(string pkgOnumber, string Consigneename, string Consigneephone, string Consigneeaddress, string Couriername, string Courierphone,
          string cabinetid, string qujm)
        {
            Package pkg = new Package();
            pkg.package_OrderNumber = pkgOnumber;    
            pkg.Consignee_name = Consigneename;
            pkg.Consignee_phone = Consigneephone;
            pkg.Consignee_address = Consigneeaddress;
            pkg.Courier_name = Couriername;
            pkg.Courier_phone = Courierphone;
            pkg.cabinet_id = cabinetid;
            pkg.package_status = "未取出";
            pkg.cabinet_qcode = qujm;
            pkg.DeliveryTime = DateTime.Now;
            db.Package.InsertOnSubmit(pkg);
            db.SubmitChanges();

        }
        public string GenerateOrderNumber(DateTime date)
        {
            string year = date.Year.ToString();
            string month = date.Month.ToString("D2");
            string day = date.Day.ToString("D2");
            string hour = date.Hour.ToString("D2");
            string minute = date.Minute.ToString("D2");
            string second = date.Second.ToString("D2");

            return $"{year}{month}{day}{hour}{minute}{second}";
        }
        public void PkgUpdateStatus(string cabinetid)
        {
            Package pkg = (from p in db.Package
                               where p.cabinet_id == cabinetid
                               select p).First();
            pkg.package_status = "已取出";
            db.SubmitChanges();
        }

    }

}
