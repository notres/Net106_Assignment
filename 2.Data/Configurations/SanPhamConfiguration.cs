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
    public class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable(nameof(SanPham));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Ten).IsRequired();
            builder.Property(x => x.GiaNhap).IsRequired();
            builder.Property(x => x.GiaNhap).IsRequired();
            builder.Property(x => x.SoLuong).IsRequired();
            builder.Property(x => x.TrangThai).IsRequired();
            builder.Property(x => x.LinkAnh);

            builder.Property(x => x.IdLoai).IsRequired();

            builder.HasOne(x=>x.loai).WithMany(x=>x.sanPhams).HasForeignKey(x=>x.IdLoai);
        }
    }
}
