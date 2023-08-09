using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.ModelsClass
{
    public class SanPham
    {
        public SanPham()
        {
            gioHangChiTiets = new HashSet<GioHangChiTiet>();
            hoaDonChiTiets = new HashSet<HoaDonChiTiet>();

        }
        public Guid Id { get; set; }
        public Guid? IdLoai { get; set; }
        public string Ten { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong  { get; set; }
        public bool TrangThai { get; set; }
        public string? LinkAnh { get; set; }
        public Loai loai { get; set; }
        public virtual ICollection<GioHangChiTiet> gioHangChiTiets { get; set; }
        public virtual ICollection<HoaDonChiTiet> hoaDonChiTiets { get; set; }
    }
}
