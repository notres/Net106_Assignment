﻿namespace _1.API.ViewModels.HoaDonChiTiet
{
    public class UpdateHoaDonChiTiet
    {
        public Guid? IdHoaDon { get; set; }
        public Guid? IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
    }
}
