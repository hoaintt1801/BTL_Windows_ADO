using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BTL_Nhom2
{
    [Table("PhieuThu")]
    public partial class PhieuThu
    {
        [Key]
        [StringLength(20)]
        public string MaPT { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        public DateTime? NgayLap { get; set; }

        [StringLength(20)]
        public string NguoiLapPhieu { get; set; }

        [Column(TypeName = "money")]
        public decimal? SoTienThu { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }
    }

}
