using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopPV.DAO;

namespace QuanLyShopPV.BUS
{
    class BUS_DeleteAdmin
    {
        DAO_DeleteAdmin dDeleteAdmin;
        public BUS_DeleteAdmin()
        {
            dDeleteAdmin = new DAO_DeleteAdmin();
        }
        public bool DeleteProducts(SanPham sp)
        {
            if (dDeleteAdmin.CheckDeleteProducts(sp))
            {
                try
                {
                    dDeleteAdmin.DeleteProducts(sp);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }
        public bool DeleteAccount(Account tk)
        {
            if (dDeleteAdmin.CheckDeleteAccount(tk))
            {
                try
                {
                    dDeleteAdmin.DeleteAccount(tk);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }  
            }
            else
                return false;
        }
        public bool DeleteBill(HoaDon h)
        {
            if (dDeleteAdmin.CheckDeleteBill(h))
            {
                try
                {
                    dDeleteAdmin.DeleteBill(h);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }
            
    }
}
