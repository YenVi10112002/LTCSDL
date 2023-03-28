using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopPV.DAO;

namespace QuanLyShopPV.BUS
{
   
    class BUS_DangNhap
    {
        dangNhap_DAO dDangNhap;
        public BUS_DangNhap()
        {
            dDangNhap = new dangNhap_DAO();
        }
        public bool GetDangNhap(string name, string pass)
        {
            if (dDangNhap.DangNhap(name, pass))
                return true;
            return false;

        }

    }
}
