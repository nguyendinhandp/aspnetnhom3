using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom3.Models
{
    public class LopHocPhan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaLHP { get; set; }

        public string NamHoc { get; set; }
        public int HocKy { get; set; }
        public int Mon { get; set; }
        public double DiemGK { get; set; }
        public double DiemCuoiKy { get; set; }

        
    }
}
