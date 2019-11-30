using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

//ketquahoctap
namespace Nhom3.Models
{
    public class KetQuaHocTap
    {
        [Key]
        public int MaLHP { get;  set; }
        [Key]
        public int MaMon { get; set; }
        [Key]
        public int MaSV { get; set; }

        public double DGK { get; set; } // diem giua ky
        public double DCK { get; set; }  // diem cuoi ky
    }
}
