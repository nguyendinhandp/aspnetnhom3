using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

// tao model monhoc
namespace Nhom3.Models
{
    public class MonHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoTinChi  { get; set; }
    }
}
