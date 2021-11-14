using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Design;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Nhom2
{
    public partial class Chart : DbContext
    {
        public Chart()
            : base("name=Chart")
        {
        }

        public virtual DbSet<PhieuThu> PhieuThus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhieuThu>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<PhieuThu>()
                .Property(e => e.SoTienThu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhieuThu>()
                .Property(e => e.SDT)
                .IsFixedLength();
        }
    }
}
