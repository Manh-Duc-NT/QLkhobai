using DTO.LichDatTram;
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
using System.Web.Mvc;
using System.Windows.Forms;

namespace QuanLyKhoBai
{
    public partial class frm_LuanChuyenTram : Form
    {
        private readonly BaseContext baseContext;

        public frm_LuanChuyenTram()
        {
            InitializeComponent();
            baseContext = new BaseContext();
            BindingGridview();
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
            grDanhSachDangKy.DataSource = table;
            grDanhSachDangKy.AutoGenerateColumns = false;
        }

        private void grDanhSachDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = grDanhSachDangKy.Rows[rowIndex];
            lbMaTramDK.Text = row.Cells[0].Value?.ToString();
            txtTaiXe.Text = row.Cells[2].Value?.ToString();

            var tram = Convert.ToInt32(row.Cells[1].Value?.ToString());
            var dataTable = new DataTable();

            var data = baseContext.Trams.Where(w => w.Id != tram).Select(s => new SelectListItem()
            {
                Value = s.Id.ToString(),
                Text = s.Ten
            }).ToList();
            if (data != null && data.Any())
            {
                dataTable = data.ToDataTable<SelectListItem>();
            }
            cbTramMoi.DisplayMember = "Text";
            cbTramMoi.ValueMember = "Value";
            cbTramMoi.DataSource = dataTable;
        }

        private void btnLuanChuyen_Click(object sender, EventArgs e)
        {
            var tram = Convert.ToInt32(lbMaTramDK.Text);
            var tramOld = baseContext.LichDatTrams.Where(w => w.Id != tram).FirstOrDefault();
            if (tramOld != null)
            {
                tramOld.Tram = Convert.ToInt32(cbTramMoi.SelectedValue);
                var Result = baseContext.SaveChanges() > 0;
                BindingGridview();
            }
        }

        private void cbTramMoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grDanhSachDangKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
