using Entities.LichDatTram;
using Entities.NguoiDung;
using Entities.Tram;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("Core_Context") { }

        public virtual DbSet<TramEntities> Trams { get; set; }
        public virtual DbSet<LichDatTramEntities> LichDatTrams { get; set; }
        public virtual DbSet<NguoiDungEntities> NguoiDungs { get; set; }
    }
}
