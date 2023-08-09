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
    public class GioHangConfiguration : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.ToTable(nameof(GioHang));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdKhachHang);

            builder.HasOne(x => x.khachHang).WithMany(x => x.gioHangs).HasForeignKey(x => x.IdKhachHang);
        }
    }
}
