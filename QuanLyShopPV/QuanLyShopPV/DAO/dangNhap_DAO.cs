using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopPV.DAO
{
    public class dangNhap_DAO
    {
        MyShopEntities db ;
        public dangNhap_DAO()
        {
            db  = new MyShopEntities();
        }
        public bool DangNhap(string name, string pass)
        {
            int? dn;
            dn = db.SP_GetAccountByUsername(name, pass).FirstOrDefault();
            if (dn == 1)
                return true;
            return false;
        }
    }
    
}
