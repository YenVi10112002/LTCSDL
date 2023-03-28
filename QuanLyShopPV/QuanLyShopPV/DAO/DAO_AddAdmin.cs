using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopPV.DAO
{
    class DAO_AddAdmin
    {
        MyShopEntities db;
        public DAO_AddAdmin() {
            db = new MyShopEntities();
        }
        public void ThemSanPham(SanPham sp)
        {
            db.SanPhams.Add(sp);
            db.SaveChanges();
        }
        public void ThemTaiKhoan(Account a)
        {
            db.Accounts.Add(a);
            db.SaveChanges();
        }
    }
}
