using DTO.NguoiDung;
using Entities;
using Entities.NguoiDung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;

namespace QuanLyKhoBai
{
    public partial class frm_NguoiDung : Form
    {
        private readonly BaseContext baseContext;

        public frm_NguoiDung()
        {
            InitializeComponent();
            baseContext = new BaseContext();
            LoadDropdownChucVu();
            BindingGridview();
        }
        private void LoadDropdownChucVu()
        {
            var dataTable = new DataTable();

            var data = new List<SelectListItem>()
            {
                new SelectListItem(){ Value = "1", Text = "Nhân viên"},
                new SelectListItem(){ Value = "2", Text = "Quản trị"}
            }.ToList();

            if (data != null && data.Any())
            {
                dataTable = data.ToDataTable<SelectListItem>();
            }
            cbChucVu.DisplayMember = "Text";
            cbChucVu.ValueMember = "Value";
            cbChucVu.DataSource = dataTable;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var name = txtTenNguoiDung.Text;
            var ngaySinh = dtNgaySinh.Value;
            var email = txtEmail.Text;
            var sdt = txtSDT.Text;
            int chucVu = Convert.ToInt32(cbChucVu.SelectedValue);
            var tenDN = txtTenDN.Text;
            var mK = txtMK.Text;
            var diaChi = txtDiaChi.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên người dùng là bắt buộc.");
                txtTenNguoiDung.Focus();
                return;
            }
            var Entity = new NguoiDungEntities
            {
                Ten = name,
                NgaySinh = Convert.ToDateTime(ngaySinh),
                Email = email,
                SDT = sdt,
                ChucVu = chucVu,
                TenDangNhap = tenDN,
                MatKhau = mK,
                DiaChi = diaChi,
                NgayTao = DateTime.Now
            };
            baseContext.NguoiDungs.Add(Entity);
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                MessageBox.Show("Thêm mới người dùng thành công.");
                txtTenNguoiDung.Text = string.Empty;
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể tạo thông tin người dùng lúc này.");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var Id = Convert.ToInt64(txtMaNguoiDung.Text);
            var name = txtTenNguoiDung.Text;
            var ngaySinh = dtNgaySinh.Value;
            var email = txtEmail.Text;
            var sdt = txtSDT.Text;
            int chucVu = Convert.ToInt32(cbChucVu.SelectedValue);
            var tenDN = txtTenDN.Text;
            var mK = txtMK.Text;
            var diaChi = txtDiaChi.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên người dùng là bắt buộc.");
                txtTenNguoiDung.Focus();
                return;
            }

            var Entity = baseContext.NguoiDungs.FirstOrDefault(z => z.Id == Id);
            if (Entity == null)
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.");
                return;
            }
            Entity.Ten = name;
            Entity.NgaySinh = ngaySinh;
            Entity.Email = email;
            Entity.SDT = sdt;
            Entity.ChucVu = chucVu;
            Entity.TenDangNhap = tenDN;
            Entity.MatKhau = mK;
            Entity.DiaChi = diaChi;
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                txtMaNguoiDung.Text = string.Empty;
                txtTenNguoiDung.Text = string.Empty;
                MessageBox.Show("Cập nhật thông tin người dùng thành công.");
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin người dùng lúc này.");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt32(txtMaNguoiDung.Text);
            var Entity = baseContext.NguoiDungs.FirstOrDefault(z => z.Id == id);
            if (Entity == null)
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.");
                return;
            }
            baseContext.NguoiDungs.Remove(Entity);
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể xóa thông tin dùng lúc này.");
            }
        }

        private void grNguoiMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = grNguoiMuon.Rows[rowIndex];
            txtMaNguoiDung.Text = row.Cells[0].Value?.ToString();
            txtTenNguoiDung.Text = row.Cells[1].Value?.ToString();
            txtEmail.Text = row.Cells[3].Value?.ToString();
            txtTenDN.Text = row.Cells[4].Value.ToString();
            txtSDT.Text = row.Cells[6].Value?.ToString();
            txtDiaChi.Text = row.Cells[7].Value?.ToString();
            txtMK.Text = row.Cells[5].Value?.ToString();
            cbChucVu.SelectedValue = row.Cells[8].Value?.ToString();
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }


        private void BindingGridview()
        {
            List<NguoiDungModels> data = baseContext.NguoiDungs.Select(z => new NguoiDungModels
            {
                Id = z.Id,
                Ten = z.Ten,
                NgaySinh = z.NgaySinh,
                Email = z.Email,
                TenDangNhap = z.TenDangNhap,
                MatKhau =z.MatKhau,
                SDT = z.SDT,
                ChucVu = z.ChucVu,
                DiaChi = z.DiaChi
            }).ToList();
            DataTable table = new DataTable();
            if (data != null && data.Any())
            {
                table = data.ToDataTable<NguoiDungModels>();
            }
            grNguoiMuon.DataSource = table;
            grNguoiMuon.AutoGenerateColumns = false;
        }
    }
}
