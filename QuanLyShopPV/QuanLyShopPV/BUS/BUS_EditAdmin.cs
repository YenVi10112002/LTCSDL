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
    class BUS_EditAdmin
    {
        DAO_EditProduct dEditAdmin;
        public BUS_EditAdmin()
        {
            dEditAdmin = new DAO_EditProduct();
        }
        public bool EditProduct(SanPham sp)
        {
            if(dEditAdmin.CheckEditProduct(sp))
            {
                try
                {
                    dEditAdmin.EditProduct(sp);
                    return true;

    }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }    
            
        }
        public bool EditAccount(Account a)
        {
            if (dEditAdmin.CheckEditAccount(a))
            {
                try
                {
                    dEditAdmin.EditAcount(a);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
                return false;
        }
    }
}
