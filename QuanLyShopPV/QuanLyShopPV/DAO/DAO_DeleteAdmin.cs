using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopPV.DAO
{
   
    class DAO_DeleteAdmin
    {
        MyShopEntities db;
        public DAO_DeleteAdmin()
        {
            db = new MyShopEntities();
        }
        public bool CheckDeleteProducts(SanPham sp)
        {
            SanPham s = db.SanPhams.Find(sp.IDSP);
            if (sp != null)
            {
                return true;
            }
            else
                return false;
        }
        public void DeleteProducts(SanPham sp)
        {
            SanPham s = db.SanPhams.Find(sp.IDSP);
            db.SanPhams.Remove(s);
            db.SaveChanges();
        }
        public bool CheckDeleteAccount(Account a)
        {
            Account tk = db.Accounts.Find(a.IDAcc);
            if (a != null)
                return true;
            else
                return false;
        }
        public void DeleteAccount(Account a)
        {
            Account tk = db.Accounts.Find(a.IDAcc);
            db.Accounts.Remove(tk);
            db.SaveChanges();
        }
        public bool CheckDeleteBill(HoaDon h)
        {
            HoaDon hd = db.HoaDons.Find(h.IDHD);
            if(h != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeleteBill(HoaDon h)
        {
            HoaDon hd = db.HoaDons.Find(h);
            db.HoaDons.Remove(hd);
            db.SaveChanges();
        }
    }
}
