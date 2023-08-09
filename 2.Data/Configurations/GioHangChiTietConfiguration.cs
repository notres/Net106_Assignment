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
    public class GioHangChiTietConfiguration : IEntityTypeConfiguration<GioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.ToTable("GioHangChiTiet");
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.SoLuong).IsRequired();
            builder.Property(x=>x.GiaBan).IsRequired();
            builder.Property(x=>x.IdGioHang);
            builder.Property(x=>x.IdSanPham);

            builder.HasOne(x => x.gioHang).WithMany(x => x.gioHangChiTiets).HasForeignKey(x => x.IdGioHang);
            builder.HasOne(x => x.sanpham).WithMany(x => x.gioHangChiTiets).HasForeignKey(x => x.IdSanPham);
        }
    }
}
