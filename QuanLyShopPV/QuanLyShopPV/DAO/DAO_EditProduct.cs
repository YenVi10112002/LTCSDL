using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopPV.DAO
{
    class DAO_EditProduct
    {
        MyShopEntities db;
        public DAO_EditProduct()
        {
            db = new MyShopEntities();
        }
        public bool CheckEditProduct(SanPham sp)
        {
            SanPham s = db.SanPhams.Find(sp.IDSP);
            if (sp != null)
            {
                return true;
            }
            else
                return false;
        }
        public void EditProduct(SanPham sp)
        {
            SanPham s = db.SanPhams.Find(sp.IDSP);
            s.IDSP = sp.IDSP;
            s.TenSP = sp.TenSP;
            s.SLKho = sp.SLKho;
            s.MauSac = sp.MauSac;
            s.XuatXu = sp.XuatXu;
            s.GiaBan = sp.GiaBan;
            db.SaveChanges();

        }
        public bool CheckEditAccount(Account a)
        {
            Account tk = db.Accounts.Find(a.IDAcc);
            if (a != null)
                return true;
            else
                return false;
        }
        public void EditAcount(Account a)
        {
            Account tk = db.Accounts.Find(a.IDAcc);
            tk.IDAcc = a.IDAcc;
            tk.TenTK = a.TenTK;
            tk.PassTK = a.PassTK;
            db.SaveChanges();
        }
    }
}
