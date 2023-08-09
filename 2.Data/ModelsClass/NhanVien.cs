using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.ModelsClass
{
    public class NhanVien
    {
        public NhanVien() 
        {
            hoaDons = new HashSet<HoaDon>();
            InverseIdGuiBcNavigation = new HashSet<NhanVien>();
        }
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? IdGuiBaoCao { get; set; }
        public Guid? IdChucVu { get; set; }
        public string? Ten { get; set; }
        public string? Email { get; set; }
        public string? MatKhau { get; set; }
        public string? DiaChi { get; set; }
        public string? AnhNhanVien { get; set; }
        public bool GioiTinh { get; set; }
        public string? Sdt { get; set; }
        public bool TrangThai { get; set; }
        public ChucVu? chucVu { get; set; }
        public virtual NhanVien? IdGuiBcNavigation { get; set; }
        public virtual ICollection<HoaDon> hoaDons { get; set; }
        public virtual ICollection<NhanVien> InverseIdGuiBcNavigation { get; set; }
    }
}
