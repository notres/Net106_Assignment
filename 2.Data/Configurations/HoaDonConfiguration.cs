using _2.Data.ModelsClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Data.Configurations
{
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable(nameof(HoaDon));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.MaHoaDon);
            builder.Property(x => x.NgayTao).IsRequired();
            builder.Property(x => x.TongTien).IsRequired();
            builder.Property(x => x.TrangThai).IsRequired();
            builder.Property(x => x.DiaChi).IsRequired();
            builder.Property(x => x.IdKhachHang).IsRequired();
            builder.Property(x => x.IdNhanVien);

            builder.HasOne(x => x.khachHang).WithMany(x => x.hoaDons).HasForeignKey(x => x.IdKhachHang);
            builder.HasOne(x => x.nhanVien).WithMany(x => x.hoaDons).HasForeignKey(x => x.IdNhanVien);

        }
    }
}
