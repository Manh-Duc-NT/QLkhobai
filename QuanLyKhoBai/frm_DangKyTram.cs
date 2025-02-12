using DTO.LichDatTram;
using Entities;
using Entities.LichDatTram;
using QuanLyKhoBai;
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
    public partial class frm_DangKyTram : Form
    {
        private readonly BaseContext baseContext;

        public frm_DangKyTram()
        {
            InitializeComponent();
            baseContext = new BaseContext();
            LoadDropdownTram();
            BindingGridview();
        }
        private void LoadDropdownTram()
        {
            var dataTable = new DataTable();

            var data = baseContext.Trams.Select(s => new SelectListItem()
            {
                Value = s.Id.ToString(),
                Text = s.Ten
            }).ToList();
            if (data != null && data.Any())
            {
                dataTable = data.ToDataTable<SelectListItem>();
            }
            cbTram.DisplayMember = "Text";
            cbTram.ValueMember = "Value";
            cbTram.DataSource = dataTable;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var name = txtTenTaiXe.Text;
            var bienSoXe = txtBienSo.Text;
            int tram = Convert.ToInt32(cbTram.SelectedValue);
            var thoiGianDen = Convert.ToDateTime(dtBD.Value);
            var thoiGianDi = Convert.ToDateTime(dtKT.Value);
            var soLuongXeHienTai = baseContext.LichDatTrams.Where(w => w.Tram == tram).ToList().Count();
            var soLuongXeChoPhep = baseContext.Trams.FirstOrDefault(w => w.Id == tram).SoLuongXe;
            if (soLuongXeHienTai > soLuongXeChoPhep)
            {
                MessageBox.Show("Số lượng xe vượt quá cho phép");
                txtTenTaiXe.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên tài xế là bắt buộc.");
                txtTenTaiXe.Focus();
                return;
            }
            var Entity = new LichDatTramEntities
            {
                TenTaiXe = name,
                BienSoXe = bienSoXe,
                Tram = tram,
                ThoiGianDen = thoiGianDen,
                ThoiGianDi = thoiGianDi,
                NgayTao = DateTime.Now
            };
            baseContext.LichDatTrams.Add(Entity);
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                MessageBox.Show("Thêm mới lịch đặt trạm thành công.");
                txtTenTaiXe.Text = string.Empty;
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể tạo thông tinlịch đặt trạm lúc này.");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var Id = Convert.ToInt64(txtMaLichDatTram.Text);
            var name = txtTenTaiXe.Text;
            var bienSoXe = txtBienSo.Text;
            int tram = Convert.ToInt32(cbTram.SelectedValue);
            var thoiGianDen = Convert.ToDateTime(dtBD.Value);
            var thoiGianDi = Convert.ToDateTime(dtKT.Value);
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên lịch đặt trạm là bắt buộc.");
                txtTenTaiXe.Focus();
                return;
            }

            var Entity = baseContext.LichDatTrams.FirstOrDefault(z => z.Id == Id);
            if (Entity == null)
            {
                MessageBox.Show("Không tìm thấy thông tin lịch đặt trạm.");
                return;
            }
            Entity.TenTaiXe = name;
            Entity.BienSoXe = bienSoXe;
            Entity.Tram = tram;
            Entity.ThoiGianDen = thoiGianDen;
            Entity.ThoiGianDi = thoiGianDi;
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                txtMaLichDatTram.Text = string.Empty;
                txtTenTaiXe.Text = string.Empty;
                MessageBox.Show("Cập nhật thông tin lịch đặt trạm thành công.");
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin lịch đặt trạm lúc này.");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt32(txtMaLichDatTram.Text);
            var Entity = baseContext.LichDatTrams.FirstOrDefault(z => z.Id == id);
            if (Entity == null)
            {
                MessageBox.Show("Không tìm thấy thông tin lịch đặt trạm.");
                return;
            }
            baseContext.LichDatTrams.Remove(Entity);
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể xóa thông tin lịch đặt trạm lúc này.");
            }
        }

        private void BindingGridview()
        {
            List<LichDatTramModels> data = baseContext.LichDatTrams.Select(z => new LichDatTramModels
            {
                Id = z.Id,
                TenTaiXe = z.TenTaiXe,
                BienSoXe = z.BienSoXe,
                Tram = z.Tram,
                ThoiGianDen = z.ThoiGianDen,
                ThoiGianDi = z.ThoiGianDi,
            }).ToList();
            DataTable table = new DataTable();
            if (data != null && data.Any())
            {
                table = data.ToDataTable<LichDatTramModels>();
            }
            grLichDatTram.DataSource = table;
            grLichDatTram.AutoGenerateColumns = false;
        }

        private void grLichDatTram_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = grLichDatTram.Rows[rowIndex];
            txtMaLichDatTram.Text = row.Cells[0].Value?.ToString();
            txtTenTaiXe.Text = row.Cells[2].Value?.ToString();
            txtBienSo.Text = row.Cells[3].Value?.ToString();
            cbTram.SelectedValue = row.Cells[1].Value.ToString();
            dtBD.Value = Convert.ToDateTime(row.Cells[4].Value?.ToString());
            dtKT.Value = Convert.ToDateTime(row.Cells[5].Value?.ToString());
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }
    }
}
