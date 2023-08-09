using _2.Data.ModelsClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPham>().HasData(
                new SanPham()
                {
                    Id = new Guid("7CB5F225-8DB2-4D48-9F73-68A42B78C1D2"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Áo Blazer Nam CALIBER phong cách Hàn Quốc áo khoác nam cao cấp dáng vest năng động hai màu đen nâu Unisex AK01",
                    SoLuong = 10,
                    GiaBan = 250000,
                    GiaNhap = 200000,
                    LinkAnh = "sp1.jpg",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F30"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Áo Len Nam Cổ Lọ Lông Cừu Cao Cấp Dày Dặn Mềm Mịn Cực Ấm Kiểu Dáng Hàn Quốc Form Rộng Faviti",
                    SoLuong = 10,
                    GiaBan = 150000,
                    GiaNhap = 100000,
                    LinkAnh = "sp2.jpg",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F31"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Áo Thun Local Brand Unisex Teelab Premium Basic Tee TS063",
                    SoLuong = 10,
                    GiaBan = 300000,
                    GiaNhap = 250000,
                    LinkAnh = "sp3.jpg",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F32"),
                    IdLoai = new Guid("22516479-1DFE-4780-B8E0-85C885882AFF"),
                    Ten = "Quần jean nam dài, quần bò nam màu đen chất co dãn thoải mái",
                    SoLuong = 10,
                    GiaBan = 200000,
                    GiaNhap = 150000,
                    LinkAnh = "sp4.jpg",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F33"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Áo Hoodie Local Brand Unisex Teelab Special Collection Premium HD044",
                    SoLuong = 10,
                    GiaBan = 500000,
                    GiaNhap = 450000,
                    LinkAnh = "sp5.png",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F34"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Áo Polo Local Brand Karants Essentials Polo Shirt Premium - KR15",
                    SoLuong = 10,
                    GiaBan = 200000,
                    GiaNhap = 150000,
                    LinkAnh = "sp6.jpg",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F35"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Áo Thun Local Brand Unisex Karants Signature Logo Brand - KR03",
                    SoLuong = 10,
                    GiaBan = 250000,
                    GiaNhap = 200000,
                    LinkAnh = "sp7.jpg",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F36"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Áo Thun Unisex Form Rộng Tay Lỡ IN NỔI Oversize Local Brand Karants 100% Cotton - KR13",
                    SoLuong = 10,
                    GiaBan = 190000,
                    GiaNhap = 150000,
                    LinkAnh = "sp8.jpg",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F37"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Áo polo nam nữ local brand unisex Outerity Cá Sấu Cross - Italics / Màu Trắng&Đen Localbrand Outerity",
                    SoLuong = 10,
                    GiaBan = 180000,
                    GiaNhap = 150000,
                    LinkAnh = "sp9.jpg",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F38"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Áo thun Local Brand Something AT Urban",
                    SoLuong = 10,
                    GiaBan = 280000,
                    GiaNhap = 250000,
                    LinkAnh = "sp10.jpg",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F39"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Áo Polo Local Brand Unisex Karants Special Collection Premium - KR08",
                    SoLuong = 10,
                    GiaBan = 300000,
                    GiaNhap = 250000,
                    LinkAnh = "sp11.jpg",
                    TrangThai = true
                },
                new SanPham()
                {
                    Id = new Guid("F433CBCC-5300-45CE-BD6C-C41DC87B3F40"),
                    IdLoai = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Áo thun unisex MONSTER X STREET Mèo Lan Can phông tay lỡ nam nữ form rộng Local Brand",
                    SoLuong = 10,
                    GiaBan = 200000,
                    GiaNhap = 150000,
                    LinkAnh = "sp12.jpg",
                    TrangThai = true
                });

            modelBuilder.Entity<Loai>().HasData(
                new Loai()
                {
                    Id = new Guid("BC387D89-BEBE-4897-BAF0-0EA4E7028A13"),
                    Ten = "Áo nam",
                    TrangThai = true
                },
                new Loai()
                {
                    Id = new Guid("22516479-1DFE-4780-B8E0-85C885882AFF"),
                    Ten = "Quần nam",
                    TrangThai = true
                });
            modelBuilder.Entity<KhachHang>().HasData(
                new KhachHang()
                {
                    Id = new Guid("9FD94A59-1AB2-4EAE-9654-767481E96BFE"),
                    Ten = "Tung",
                    Email = "tunght@fpt.edu.vn",
                    MatKhau = "123456",
                    DiaChi = "hn",
                    GioiTinh = true,
                    Sdt = "0987654321"
                });
            modelBuilder.Entity<GioHang>().HasData(
                new GioHang()
                {
                    Id = new Guid("4F7B6227-FD02-407A-8191-604739739697"),
                    IdKhachHang = new Guid("9FD94A59-1AB2-4EAE-9654-767481E96BFE")
                });
            modelBuilder.Entity<NhanVien>().HasData(
            new NhanVien()
            {
                Id = new Guid("B54E5B6D-2309-4844-99F6-50B18F665440"),
                Ten = "tien",
                Email = "tien@gmail.com",
                MatKhau = "123456",
                DiaChi = "hn",
                GioiTinh = true,
                Sdt = "0987654322",
                TrangThai = true,
                IdChucVu = new Guid("26C5F722-3BAA-4DF7-B473-2374B39E02A2"),
                AnhNhanVien = "tien.png"
            },
            new NhanVien()
            {
                Id = new Guid("B764E8B0-FE90-42C5-95D3-B854620D274B"),
                Ten = "nga",
                Email = "nga@gmail.com",
                MatKhau = "123456",
                DiaChi = "hn",
                GioiTinh = false,
                Sdt = "0987654323",
                TrangThai = true,
                IdChucVu = new Guid("6FC0F38F-B421-4FEF-8361-8136825AA354"),
                AnhNhanVien = "nga.png"
            });
            modelBuilder.Entity<ChucVu>().HasData(
                new ChucVu()
                {
                    Id = new Guid("6FC0F38F-B421-4FEF-8361-8136825AA354"),
                    Ten = "Nhân Viên"
                },
                new ChucVu()
                {
                    Id = new Guid("26C5F722-3BAA-4DF7-B473-2374B39E02A2"),
                    Ten = "Quản lý"
                });
        }
    }
}
