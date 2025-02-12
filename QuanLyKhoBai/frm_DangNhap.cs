using Entities;
using QuanLyKhoBai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoBai
{
    public partial class frm_DangNhap : Form
    {
        BaseContext db;
        public frm_DangNhap()
        {
            db = new BaseContext();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            var tenDN = txtTenDN.Text;
            var mk = txtMK.Text;
            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập hoặc mật khẩu!!!!");
                return;
            }
            var user = db.NguoiDungs.AsQueryable().Where(w => w.TenDangNhap == tenDN.Trim() && w.MatKhau == mk.Trim()).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!!!!");
                return;
            }
            frm_Main frm = new frm_Main();
            frm.Show();
        }
    }
}
