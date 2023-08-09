namespace _1.API.ViewModels.SanPham
{
    public class SanPhamView
    {
        public Guid Id { get; set; }
        public Guid? IdLoai { get; set; }
        public string? Ten { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? GiaBan { get; set; }
        public int? SoLuong { get; set; }
        public string? TrangThai { get; set; }
        public string? LinkAnh { get; set; }
    }
}
