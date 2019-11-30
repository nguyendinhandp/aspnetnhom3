﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nhom3.Models;

namespace Nhom3.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20191130030728_KetQuaDangKy_EditTable")]
    partial class KetQuaDangKy_EditTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nhom3.Models.KetQuaHocTap", b =>
                {
                    b.Property<int>("MaLHP");

                    b.Property<int>("MaMon");

                    b.Property<int>("MaSV");

                    b.Property<double>("DCK");

                    b.Property<double>("DGK");

                    b.HasKey("MaLHP", "MaMon", "MaSV");

                    b.ToTable("KetQuaHocTap");
                });

            modelBuilder.Entity("Nhom3.Models.Khoa", b =>
                {
                    b.Property<int>("MaKhoa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenKhoa");

                    b.HasKey("MaKhoa");

                    b.ToTable("Khoa");
                });

            modelBuilder.Entity("Nhom3.Models.LopHocPhan", b =>
                {
                    b.Property<int>("MaLHP")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DiemCuoiKy");

                    b.Property<double>("DiemGK");

                    b.Property<int>("HocKy");

                    b.Property<int>("Mon");

                    b.Property<string>("NamHoc");

                    b.HasKey("MaLHP");

                    b.ToTable("LopHocPhan");
                });

            modelBuilder.Entity("Nhom3.Models.MonHoc", b =>
                {
                    b.Property<int>("MaMon")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SoTinChi");

                    b.Property<string>("TenMon");

                    b.HasKey("MaMon");

                    b.ToTable("MonHoc");
                });

            modelBuilder.Entity("Nhom3.Models.SinhVien", b =>
                {
                    b.Property<int>("MaSV")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DienThoai");

                    b.Property<string>("HoTen");

                    b.Property<DateTime>("NgaySinh");

                    b.HasKey("MaSV");

                    b.ToTable("SinhVien");
                });
#pragma warning restore 612, 618
        }
    }
}
