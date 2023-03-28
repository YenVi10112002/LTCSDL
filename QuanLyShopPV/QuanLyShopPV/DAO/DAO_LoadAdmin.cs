using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopPV.DAO
{
    class DAO_LoadAdmin
    {
        MyShopEntities db;
        public DAO_LoadAdmin()
        {
            db = new MyShopEntities();
        }
        public dynamic GetLoadAccount()
        {
            var ds = db.Accounts.Select(s => new
            {
                s.IDAcc,
                s.TenTK,
                s.PassTK
            }).ToList();
            return ds;

        }
        public dynamic GetLoadProduct()
        {
            var dsp = db.SanPhams.Select(s => new
            {
                s.IDSP,
                s.TenSP,
                s.SLKho,
                s.MauSac,
                s.XuatXu,
                s.GiaBan
            }).ToList();
            return dsp;
        }

        public dynamic LoadBill()
        {
            var dsb = db.HoaDons.Select(s => new
            {
                s.IDHD,
                s.TongTien,
                s.NgayLap,
                s.KhachHang.TenKH,
            }
            ).ToList();
            return dsb;
        }

        public dynamic LoadKH()
        {
            var dskh = db.KhachHangs.Select(s => new
            {
                s.IDKH,
                s.TenKH,
                s.SDT
            }).ToList();
            return dskh;
        }
        public dynamic LoadEmployee()
        {
            var dse = db.NhanViens.Select(s => new
            {
                s.IDNV,
                s.TenNV,
                s.SDT,
                s.Luong,
            }).ToList();
            return dse;
        }
        
    }
}
