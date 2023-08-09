namespace _1.API.ViewModels.HoaDon
{
    public class UpdateHoaDon
    {
        public Guid Id { get; set; }
        public Guid? IdKhachHang { get; set; }
        public Guid? IdNhanVien { get; set; }
        public DateTime? NgayTao { get; set; }
        public decimal TongTien { get; set; }
        public int? TrangThai { get; set; }
        public string? DiaChi { get; set; }
    }
}
