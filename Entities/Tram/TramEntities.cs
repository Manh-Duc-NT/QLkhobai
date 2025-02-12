using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Tram
{
    public class TramEntities : BaseEntities
    {
        [Required]
        [MaxLength(250)]
        public string Ten { get; set; }
        public string HinhAnh { get; set; }
        public int KhuVuc { get; set; }
        public double SoLuongXe { get; set; }
        public long NguoiQuanLy { get; set; }
        public DateTime ThoiGianMoCua { get; set; }
        public DateTime ThoiGianDongCua { get; set; }
    }
}
