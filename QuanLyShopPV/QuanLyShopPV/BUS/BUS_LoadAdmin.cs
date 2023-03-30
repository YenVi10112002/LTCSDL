using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopPV.DAO;

namespace QuanLyShopPV.BUS
{
    class BUS_LoadAdmin
    {
        DAO_LoadAdmin dLoadAdmin;
        public BUS_LoadAdmin()
        {
            dLoadAdmin = new DAO_LoadAdmin();
        }
        public void GetLoadAccount(DataGridView dgv, ComboBox cbb)
        {
            dgv.DataSource = dLoadAdmin.GetLoadAccount();
            cbb.DataSource = dLoadAdmin.GetLoadAccount();
            cbb.DisplayMember = "TenTK";
            cbb.ValueMember = "IDAcc";
        }
        public void GetLoadProduct(DataGridView dgv, ComboBox cbb)
        {
            dgv.DataSource = dLoadAdmin.GetLoadProduct();
            cbb.DataSource = dLoadAdmin.GetLoadProduct();
            cbb.DisplayMember = "TenSP";
            cbb.ValueMember = "IDSP";
        }
        public void LoadBill(DataGridView dgv, ComboBox cbb)
        {
            dgv.DataSource = dLoadAdmin.LoadBill();
            cbb.DataSource = dLoadAdmin.LoadBill();
            cbb.DisplayMember = "TenKH";
            cbb.ValueMember = "IDHD";


        }
        public void LoadKhachHang(DataGridView dgv, ComboBox cbb)
        {
            dgv.DataSource = dLoadAdmin.LoadKH();
            cbb.DataSource = dLoadAdmin.LoadKH();
            cbb.DisplayMember = "TenKH";
            cbb.ValueMember = "IDKH";
        }
        public void LoadEmployee(DataGridView dgv, ComboBox cbb)
        {
            dgv.DataSource = dLoadAdmin.LoadEmployee();
            cbb.DataSource = dLoadAdmin.LoadEmployee();
            cbb.DisplayMember = "TenNV";
            cbb.ValueMember = "IDNV";
        }

        public void LoadCTBill(DataGridView dgv, string maHD)
        {
            dgv.DataSource = null;
            dgv.DataSource = dLoadAdmin.LoadCTBill(maHD);
        }
    }
}
