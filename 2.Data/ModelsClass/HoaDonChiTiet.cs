using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.ModelsClass
{
    public class HoaDonChiTiet
    {
        public Guid Id { get; set; }
        public Guid? IdHoaDon { get; set; }
        public Guid? IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }

        public HoaDon hoaDon { get; set; }
        public SanPham sanpham { get; set; }

    }
}
