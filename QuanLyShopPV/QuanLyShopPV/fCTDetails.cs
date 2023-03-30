using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopPV.BUS;

namespace QuanLyShopPV
{
    public partial class fCTDetails : Form
    {
        public string maHD;
        BUS_LoadAdmin bLAdmin;
        public fCTDetails()
        {
            InitializeComponent();
            bLAdmin = new BUS_LoadAdmin();
        }

        private void dgvCTBill_DoubleClick(object sender, EventArgs e)
        {

        }
        private void HienThiDSHoaDon(string maHD)
        {
            dgvCTBill.DataSource = null;
            bLAdmin.LoadCTBill(dgvCTBill, maHD);
        }
        private void fCTDetails_Load(object sender, EventArgs e)
        {
            HienThiDSHoaDon(maHD);
        }
    }
        
}
