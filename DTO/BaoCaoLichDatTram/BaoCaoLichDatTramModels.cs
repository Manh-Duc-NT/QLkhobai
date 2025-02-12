using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.BaoCaoLichDatTram
{
    public class BaoCaoLichDatTramModels
    {
        public long? MaTram { get; set; }
        public string Ten { get; set; }
        public int SoLuongXe { get; set; }
        public DateTime ThoiGianDen { get; set; }
        public DateTime ThoiGianDi { get; set; }
    }
}
