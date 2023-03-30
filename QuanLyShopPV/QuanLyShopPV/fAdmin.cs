using QuanLyShopPV.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopPV
{
    public partial class fAdmin : Form
    {
        BUS_LoadAdmin bLoadAdmin;
        BUS_AddAdmin bAddAdmin;
        BUS_EditAdmin bEditAdmin;
        BUS_DeleteAdmin bDeleteAdmin;
        public fAdmin()
        {
            InitializeComponent();
            bLoadAdmin = new BUS_LoadAdmin();
            bAddAdmin = new BUS_AddAdmin();
            bEditAdmin = new BUS_EditAdmin();
            bDeleteAdmin = new BUS_DeleteAdmin();
        }
        //Dữ liệu xuất ra datagridview và combobox
        void HienThiDSTaiKhoan()
        {
            dgvAccount.DataSource = null;
            bLoadAdmin.GetLoadAccount(dgvAccount, cbbSearchNameAccount);
            dgvAccount.Columns[0].Width = (int)(dgvAccount.Width * 0.33);
            dgvAccount.Columns[1].Width = (int)(dgvAccount.Width * 0.33);
            dgvAccount.Columns[2].Width = (int)(dgvAccount.Width * 0.33);
        }
        void HienThiDSSanPham()
        {
            dgvProducts.DataSource = null;
            bLoadAdmin.GetLoadProduct(dgvProducts, cbbSearchNameProduct);
            dgvProducts.Columns[0].Width = (int)(dgvProducts.Width * 0.25);
            dgvProducts.Columns[1].Width = (int)(dgvProducts.Width * 0.25);
            dgvProducts.Columns[2].Width = (int)(dgvProducts.Width * 0.25);
            dgvProducts.Columns[3].Width = (int)(dgvProducts.Width * 0.25);
        }

        void HienThiDSHoaDon()
        {
            dgvBill.DataSource = null;
            bLoadAdmin.LoadBill(dgvBill, cbbSearchNameBill);
            dgvBill.Columns[0].Width = (int)(dgvBill.Width * 0.25);
            dgvBill.Columns[1].Width = (int)(dgvBill.Width * 0.25);
            dgvBill.Columns[2].Width = (int)(dgvBill.Width * 0.25);
            dgvBill.Columns[3].Width = (int)(dgvBill.Width * 0.25);
        }

        void HienThiDSKhachHang()
        {
            dgvCustomer.DataSource = null;
            bLoadAdmin.LoadKhachHang(dgvCustomer, cbbSearchNameKH);
            dgvCustomer.Columns[0].Width = (int)(dgvCustomer.Width * 0.33);
            dgvCustomer.Columns[1].Width = (int)(dgvCustomer.Width * 0.33);
            dgvCustomer.Columns[2].Width = (int)(dgvCustomer.Width * 0.33);

        }
        void HienThiDSNhanVien()
        {
            dgvEmployee.DataSource = null;
            bLoadAdmin.LoadEmployee(dgvEmployee, cbbSearchNameEmployee);
            dgvEmployee.Columns[0].Width = (int)(dgvEmployee.Width * 0.25);
            dgvEmployee.Columns[1].Width = (int)(dgvEmployee.Width * 0.25);
            dgvEmployee.Columns[2].Width = (int)(dgvEmployee.Width * 0.25);
            dgvEmployee.Columns[3].Width = (int)(dgvEmployee.Width * 0.25);

        }
        private void fhome_Load(object sender, EventArgs e)
        {
            HienThiDSTaiKhoan();
            HienThiDSSanPham();
            HienThiDSHoaDon();
            HienThiDSKhachHang();
            HienThiDSNhanVien();
        }

        //Click vào row trong datagridview sẽ đưa dữ liệu ra textbox
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProducts.Rows.Count)
            {
                txtIDProducts.Text = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbNameProduct.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbQuantityProduct.Text = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtbColorProduct.Text = dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtbOriginProducts.Text = dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPriceProduct.Text = dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAccount.Rows.Count)
            {
                txtbIDAccount.Text = dgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUserName.Text = dgvAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPassAccount.Text = dgvAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
                
            }
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvBill.Rows.Count)
            {
                txtbIDBill.Text = dgvBill.Rows[e.RowIndex].Cells["IDHD"].Value.ToString();
                cbbNameKH.Text = dgvBill.Rows[e.RowIndex].Cells["TenKH"].Value.ToString();
                dtDateBill.Text = dgvBill.Rows[e.RowIndex].Cells["NgayLap"].Value.ToString();

            }
        }
        //Click Thêm vào dữ liệu
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.IDSP = txtIDProducts.Text;
            sanPham.TenSP = txtbNameProduct.Text;
            sanPham.SLKho = int.Parse(txtbQuantityProduct.Text.ToString());
            sanPham.MauSac = txtbColorProduct.Text;
            sanPham.XuatXu = txtbOriginProducts.Text.ToString();
            sanPham.GiaBan = float.Parse(txtPriceProduct.Text.ToString());

            if(bAddAdmin.ThemSanPham(sanPham))
            {

                MessageBox.Show("Thêm sản phẩm thành công");
                bLoadAdmin.GetLoadProduct(dgvProducts, cbbSearchNameProduct);
                //txtIDProducts=
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }    
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.IDAcc = txtbIDAccount.Text;
            a.TenTK = txtUserName.Text;
            a.PassTK = int.Parse(txtPassAccount.Text);
            if (bAddAdmin.ThemTaikhoan(a))
            {

                MessageBox.Show("Thêm sản phẩm thành công");
                bLoadAdmin.GetLoadAccount(dgvAccount, cbbSearchNameAccount);
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại");
            }
        }

        //Click vào Edit 
        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.IDSP = txtIDProducts.Text;
            sanPham.TenSP = txtbNameProduct.Text;
            sanPham.SLKho = int.Parse(txtbQuantityProduct.Text);
            sanPham.MauSac = txtbColorProduct.Text;
            sanPham.XuatXu = txtbOriginProducts.Text.ToString();
            sanPham.GiaBan = float.Parse(txtPriceProduct.Text);

            if (bEditAdmin.EditProduct(sanPham))
            {
                MessageBox.Show("Sửa sản phẩm thành công");
                bLoadAdmin.GetLoadProduct(dgvProducts, cbbSearchNameProduct);
            }
            else
            {
                MessageBox.Show("Sửa sản phẩm thất bại");
            }
        }
        private void btnExitAccount_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.IDAcc = txtbIDAccount.Text;
            a.TenTK = txtUserName.Text;
            a.PassTK = int.Parse(txtPassAccount.Text);

            if(bEditAdmin.EditAccount(a))
            {
                MessageBox.Show("Sửa tài khoản thành công");
                bLoadAdmin.GetLoadAccount(dgvAccount, cbbSearchNameAccount);
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại");
            }
        }

        //Click vào delete
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.IDSP = txtIDProducts.Text;
            if (bDeleteAdmin.DeleteProducts(sp))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                bLoadAdmin.GetLoadProduct(dgvProducts, cbbSearchNameProduct);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            Account tk = new Account();
            tk.IDAcc = txtbIDAccount.Text;
            if (bDeleteAdmin.DeleteAccount(tk))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                bLoadAdmin.GetLoadAccount(dgvAccount, cbbSearchNameAccount);
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.IDHD = txtbIDBill.Text;
            if (bDeleteAdmin.DeleteBill(hd))
            {
                MessageBox.Show("Xóa hóa đơn thành công");
                bLoadAdmin.LoadBill(dgvBill, cbbSearchNameBill);
            }
            else
            {
                MessageBox.Show("Xóa hóa đơn thất bại");
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
                
        }

        private void dgvBill_DoubleClick(object sender, EventArgs e)
        {
            fCTDetails f = new fCTDetails();
            f.maHD = Convert.ToString(dgvBill.CurrentRow.Cells["IDHD"].Value);
            f.ShowDialog();
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

