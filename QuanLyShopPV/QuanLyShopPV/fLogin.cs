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
    
    public partial class fLogin : Form
    {
        BUS_DangNhap bDangNhap = new BUS_DangNhap();
        public fLogin()
        {
            InitializeComponent();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
            if(Login(username, password))
            { 
                    fManager f = new fManager();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();    
            }
            else
                MessageBox.Show("Bạn vui lòng nhập lại tên đăng nhập và mật khẩu");
        }
        bool Login(string username, string password)
        {
            txtUserName.Text = "";
            txtPassWord.Text = "";
            return bDangNhap.GetDangNhap(username, password);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?","Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
    }
}
