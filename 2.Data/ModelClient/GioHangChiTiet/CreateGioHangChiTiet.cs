namespace _1.API.ViewModels.GioHangChiTiet
{
    public class CreateGioHangChiTiet
    {
        public Guid? IdGioHang { get; set; }
        public Guid? IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
    }
}
