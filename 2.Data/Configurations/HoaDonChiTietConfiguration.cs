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
    public class HoaDonChiTietConfiguration : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.SoLuong).IsRequired();
            builder.Property(x=>x.GiaBan).IsRequired();
            builder.Property(x=>x.IdHoaDon);
            builder.Property(x=>x.IdSanPham);

            builder.HasOne(x => x.hoaDon).WithMany(x => x.hoaDonChiTiets).HasForeignKey(x => x.IdHoaDon);
            builder.HasOne(x => x.sanpham).WithMany(x => x.hoaDonChiTiets).HasForeignKey(x => x.IdSanPham);
        }
    }
}
