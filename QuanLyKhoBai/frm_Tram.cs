using DTO.Tram;
using Entities;
using Entities.Tram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;

namespace QuanLyKhoBai
{
    public partial class frm_Tram : Form
    {
        private readonly BaseContext baseContext;

        public frm_Tram()
        {
            InitializeComponent();
            baseContext = new BaseContext();
            LoadDropdownKhuVuc();
            LoadDropdownNguoiQuanLy();
            BindingGridview();
        }
        private void LoadDropdownKhuVuc()
        {
            var dataTable = new DataTable();

            var data = new List<SelectListItem>()
            {
                new SelectListItem(){ Value = "1", Text = "Hà Nội"},
                new SelectListItem(){ Value = "2", Text = "Hồ Chí Minh"},
                new SelectListItem(){ Value = "3", Text = "Đà Nẵng"}
            }.ToList();

            if (data != null && data.Any())
            {
                dataTable = data.ToDataTable<SelectListItem>();
            }
            cbKhuVuc.DisplayMember = "Text";
            cbKhuVuc.ValueMember = "Value";
            cbKhuVuc.DataSource = dataTable;
        }

        private void LoadDropdownNguoiQuanLy()
        {
            var dataTable = new DataTable();

            var data = baseContext.NguoiDungs.Where(w => w.ChucVu == 2).Select(s => new SelectListItem()
            {
                Value = s.Id.ToString(),
                Text = s.Ten
            }).ToList();
            if (data != null && data.Any())
            {
                dataTable = data.ToDataTable<SelectListItem>();
            }
            cbNguoiQuanLy.DisplayMember = "Text";
            cbNguoiQuanLy.ValueMember = "Value";
            cbNguoiQuanLy.DataSource = dataTable;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var name = txtTenTram.Text;
            int khuVuc = Convert.ToInt32(cbKhuVuc.SelectedValue);
            int soLuongXe = Convert.ToInt32(nbSLX.Value);
            long nguoiQuanLy = Convert.ToInt32(cbNguoiQuanLy.SelectedValue);
            DateTime tgbd = Convert.ToDateTime(dtBD.Value);
            DateTime tgkt = Convert.ToDateTime(dtDC.Value);
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên trạm bị là bắt buộc.");
                txtTenTram.Focus();
                return;
            }
            var Entity = new TramEntities
            {
                Ten = name,
                KhuVuc = khuVuc,
                SoLuongXe = soLuongXe,
                NguoiQuanLy = nguoiQuanLy,
                ThoiGianMoCua = tgbd,
                ThoiGianDongCua = tgkt,
                NgayTao = DateTime.Now,
            };
            if (picTram.Image != null)
            {
                var image = ImageToBase64(picTram.Image, System.Drawing.Imaging.ImageFormat.Png);
                Entity.HinhAnh = image;
            }
            baseContext.Trams.Add(Entity);
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                MessageBox.Show("Thêm mới trạm thành công.");
                txtTenTram.Text = string.Empty;
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể tạo thông tin trạm lúc này.");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var Id = Convert.ToInt64(txtMaTram.Text);
            var name = txtTenTram.Text;
            int khuVuc = Convert.ToInt32(cbKhuVuc.SelectedValue);
            int soLuongXe = Convert.ToInt32(nbSLX.Value);
            long nguoiQuanLy = Convert.ToInt32(cbNguoiQuanLy.SelectedValue);
            DateTime tgbd = Convert.ToDateTime(dtBD.Value);
            DateTime tgkt = Convert.ToDateTime(dtDC.Value);
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên trạm là bắt buộc.");
                txtTenTram.Focus();
                return;
            }

            var Entity = baseContext.Trams.FirstOrDefault(z => z.Id == Id);
            if (Entity == null)
            {
                MessageBox.Show("Không tìm thấy thông tin trạm.");
                return;
            }
            Entity.Ten = name;
            Entity.KhuVuc = khuVuc;
            Entity.SoLuongXe = soLuongXe;
            Entity.NguoiQuanLy = nguoiQuanLy;
            Entity.ThoiGianMoCua = tgbd;
            Entity.ThoiGianDongCua = tgkt;
            if (picTram.Image != null)
            {
                var image = ImageToBase64(picTram.Image, System.Drawing.Imaging.ImageFormat.Png);
                Entity.HinhAnh = image;
            }
            
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                txtMaTram.Text = string.Empty;
                txtTenTram.Text = string.Empty;
                MessageBox.Show("Cập nhật thông tin trạm thành công.");
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật thông tin trạm lúc này.");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt32(txtMaTram.Text);
            var Entity = baseContext.Trams.FirstOrDefault(z => z.Id == id);
            if (Entity == null)
            {
                MessageBox.Show("Không tìm thấy thông tin trạm.");
                return;
            }
            baseContext.Trams.Remove(Entity);
            var Result = baseContext.SaveChanges() > 0;
            if (Result)
            {
                BindingGridview();
            }
            else
            {
                MessageBox.Show("Không thể xóa thông tin trạm lúc này.");
            }
        }

        private void grThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = grThietBi.Rows[rowIndex];
            txtMaTram.Text = row.Cells[0].Value?.ToString();
            txtTenTram.Text = row.Cells[1].Value?.ToString();
            cbKhuVuc.SelectedValue = Convert.ToInt32(row.Cells[3].Value?.ToString());
            nbSLX.Value = Convert.ToDecimal(row.Cells[4].Value?.ToString());
            cbNguoiQuanLy.SelectedValue = Convert.ToInt32(row.Cells[5].Value?.ToString());
            dtBD.Value = Convert.ToDateTime(row.Cells[6].Value?.ToString());
            dtDC.Value = Convert.ToDateTime(row.Cells[7].Value?.ToString());
            // Convert base 64 string to byte[]
            var pic = row.Cells[2].Value?.ToString();
            if (!string.IsNullOrWhiteSpace(pic))
            {
                byte[] imageBytes = Convert.FromBase64String(row.Cells[2].Value?.ToString());
                // Convert byte[] to Image
                using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    picTram.Image = Image.FromStream(ms, true);
                }
            }            
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }


        private void BindingGridview()
        {
            List<TramModels> data = baseContext.Trams.Select(z => new TramModels
            {
                Id = z.Id,
                Ten = z.Ten,
                KhuVuc = z.KhuVuc,
                SoLuongXe = z.SoLuongXe,                
                NguoiQuanLy = z.NguoiQuanLy,
                ThoiGianMoCua = z.ThoiGianMoCua,
                ThoiGianDongCua = z.ThoiGianDongCua,
                HinhAnh = z.HinhAnh,
            }).ToList();
            DataTable table = new DataTable();
            if (data != null && data.Any())
            {
                table = data.ToDataTable<TramModels>();
            }
            grThietBi.DataSource = table;
            grThietBi.AutoGenerateColumns = false;
        }

        private void btn_HinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picTram.Image = new Bitmap(opnfd.FileName);
            }
        }
        public string ImageToBase64(Image image,
          System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
    }
}
