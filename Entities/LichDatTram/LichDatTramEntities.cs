using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.LichDatTram
{
    public class LichDatTramEntities : BaseEntities
    {
        public long Tram { get; set; }
        public string TenTaiXe { get; set; }
        public string BienSoXe { get; set; }
        public DateTime ThoiGianDen { get; set; }
        public DateTime ThoiGianDi { get; set; }
    }
}
