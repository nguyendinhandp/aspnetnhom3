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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<KetQuaHocTap>().HasKey(table => new {
                table.MaLHP,
                table.MaMon,
                table.MaSV
            });
        }
        public DbSet<Khoa> Khoa { get; set; }
        public DbSet<LopHocPhan> LopHocPhan { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<SinhVien> SinhVien { get; set; }
        public DbSet<KetQuaHocTap> KetQuaHocTap { get; set; }
    }
}
