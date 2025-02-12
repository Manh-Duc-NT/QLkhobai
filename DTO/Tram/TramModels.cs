using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Tram
{
    public class TramModels
    {
        public long Id { get; set; }
        public string Ten { get; set; }
        public string HinhAnh { get; set; }
        public int KhuVuc { get; set; }
        public double SoLuongXe { get; set; }
        public long NguoiQuanLy { get; set; }
        public DateTime ThoiGianMoCua { get; set; }
        public DateTime ThoiGianDongCua { get; set; }
    }
}
