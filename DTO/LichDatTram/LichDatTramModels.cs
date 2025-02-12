using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.LichDatTram
{
    public class LichDatTramModels
    {
        public long Id { get; set; }
        public long Tram { get; set; }
        public string TenTaiXe { get; set; }
        public string BienSoXe { get; set; }
        public DateTime ThoiGianDen { get; set; }
        public DateTime ThoiGianDi { get; set; }
    }
}
