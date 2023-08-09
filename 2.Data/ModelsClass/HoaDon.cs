using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.ModelsClass
{
    public class HoaDon
    {
        public HoaDon() 
        { 
            hoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }
        public Guid Id { get; set; }
        public string? MaHoaDon { get; set; }
        public Guid? IdKhachHang { get; set; }
        public Guid? IdNhanVien { get; set; }
        public DateTime? NgayTao { get; set; }
        public decimal TongTien { get; set; }
        public int? TrangThai { get; set; }
        public string? DiaChi { get; set; }
        public KhachHang? khachHang { get; set; }
        public NhanVien? nhanVien { get; set; }
        public virtual ICollection<HoaDonChiTiet> hoaDonChiTiets { get; set; }
    }
}
