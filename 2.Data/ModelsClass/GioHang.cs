using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.ModelsClass
{
    public class GioHang
    {
        public GioHang() 
        {
            gioHangChiTiets = new HashSet<GioHangChiTiet>();
        }
        public Guid Id { get; set; }
        public Guid IdKhachHang { get; set; }
        public KhachHang khachHang { get; set;}

        public virtual ICollection<GioHangChiTiet> gioHangChiTiets { get; set; }
    }
}
