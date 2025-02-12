using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.NguoiDung
{
    public class NguoiDungModels
    {
        public long Id { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public int ChucVu { get; set; }
    }
}
