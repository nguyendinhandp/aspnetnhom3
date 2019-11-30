using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nhom3.Models;

namespace Nhom3.Controllers
{
    public class KetQuaHocTapController : Controller
    {
        // get sinh vien
        private SinhVien GetSinhVien(int masv)
        {
            return this.database.SinhVien.FirstOrDefault(x=>x.MaSV.Equals(masv));
        }

        //get monhoc
        private MonHoc GetMonHoc(int mamh)
        {
            return this.database.MonHoc.FirstOrDefault(x=>x.MaMon.Equals(mamh));
        }
        private DatabaseContext database { get; set; } = new DatabaseContext();
        //xem diem
        public IActionResult XemDiem(int? MaMon,int? MaLop,int? MaSv)
        {
            var result = database
                .KetQuaHocTap
                ;
            IQueryable<KetQuaHocTap> query = result.AsQueryable();
            if(MaMon != null)
            {
                query = query.Where(x => x.MaMon.Equals(MaMon));
            }
            if(MaLop != null)
            {
                query = query.Where(x => x.MaMon.Equals(MaLop));
            }
             if(MaSv != null)
            {
                query = query.Where(x => x.MaSV.Equals(MaSv));
            } 
                var r = query.ToList()
                .Select(x =>
                {
                    return new KetQuaHocTapDTO
                    {
                        SinhVien = this.GetSinhVien(x.MaSV),
                        MonHoc = this.GetMonHoc(x.MaMon),
                        DCK = x.DCK,
                        DGK = x.DGK
                    };
                })
                ;
            //this.ViewBag.Result = database.KetQuaHocTap
            //    .Where(x => x.MaMon.Equals(MaMon))
            //    .Join(
            //        database.MonHoc,
            //        kq => kq.MaMon,
            //        mh => mh.MaMon,
            //        (kq,mh) => new
            //        {
            //            kq.MaSV,
            //            kq.MaLHP,
            //            mh.TenMon
            //        }
            //    )
            //    .Join(
            //        database.SinhVien,
            //        kq => kq.MaSV,
            //        sv => sv.MaSV,
            //        (kq,sv) => new
            //        {
            //            sv.HoTen
            //        }
            //    )
            //    .ToList();
            this.ViewBag.Result = r;
            return View();
        }
    }
}