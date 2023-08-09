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
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Ten).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.MatKhau).IsRequired();
            builder.Property(x => x.DiaChi).IsRequired();
            builder.Property(x => x.GioiTinh).IsRequired();
            builder.Property(x => x.Sdt).IsRequired();
            builder.Property(x => x.TrangThai).IsRequired();
            builder.Property(x => x.IdChucVu).IsRequired();
            builder.Property(x => x.AnhNhanVien).IsRequired();

            builder.HasOne(x => x.IdGuiBcNavigation).WithMany(x => x.InverseIdGuiBcNavigation);
            builder.HasOne(x => x.chucVu).WithMany(x => x.nhanViens).HasForeignKey(x => x.IdChucVu);
        }
    }
}
