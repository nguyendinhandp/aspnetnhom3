using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom3.Models
{
    public class KetQuaHocTapDTO
    {
        public SinhVien SinhVien { get; set; }
        public MonHoc MonHoc { get; set; }
        public LopHocPhan LopHocPhan { get; set; }
        public double DGK { get; set; }
        public double DCK { get; set; }
    }
}
