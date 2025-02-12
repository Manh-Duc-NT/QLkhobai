using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.NguoiDung
{
    public class NguoiDungEntities : BaseEntities
    {
        [Required]
        [MaxLength(250)]
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
