using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.ModelsClass
{
    public class GioHangChiTiet
    {
        public Guid Id { get; set; }
        public Guid? IdGioHang { get; set; }
        public Guid? IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }

        public GioHang gioHang { get; set; }
        public SanPham sanpham { get; set; }
    }
}
