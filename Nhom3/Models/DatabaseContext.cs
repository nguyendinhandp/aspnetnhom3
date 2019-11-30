using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom3.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<LopHocPhan> LopHocPhan { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<SinhVien> SinhVien { get; set; }
    }
}
