using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopPV.DAO;

namespace QuanLyShopPV.BUS
{
    class BUS_AddAdmin
    {
        DAO_AddAdmin dAddAdmin;
        public BUS_AddAdmin()
        {
            dAddAdmin = new DAO_AddAdmin();
        }
        public bool ThemSanPham(SanPham sp)
        {
            try
            {
                dAddAdmin.ThemSanPham(sp);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ThemTaikhoan(Account a)
        {
            try
            {
                dAddAdmin.ThemTaiKhoan(a);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
