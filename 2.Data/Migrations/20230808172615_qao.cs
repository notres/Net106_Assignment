using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2.Data.Migrations
{
    public partial class qao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGuiBaoCao = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    IdGuiBcNavigationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdChucVu",
                        column: x => x.IdChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanVien_NhanVien_IdGuiBcNavigationId",
                        column: x => x.IdGuiBcNavigationId,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHang_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    LinkAnh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPham_Loai_IdLoai",
                        column: x => x.IdLoai,
                        principalTable: "Loai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GioHangChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_GioHang_IdGioHang",
                        column: x => x.IdGioHang,
                        principalTable: "GioHang",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_SanPham_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPham",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_SanPham_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPham",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "Id", "Ten" },
                values: new object[,]
                {
                    { new Guid("26c5f722-3baa-4df7-b473-2374b39e02a2"), "Quản lý" },
                    { new Guid("6fc0f38f-b421-4fef-8361-8136825aa354"), "Nhân Viên" }
                });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "Id", "DiaChi", "Email", "GioiTinh", "MatKhau", "Sdt", "Ten" },
                values: new object[] { new Guid("9fd94a59-1ab2-4eae-9654-767481e96bfe"), "hn", "tunght@fpt.edu.vn", true, "123456", "0987654321", "Tung" });

            migrationBuilder.InsertData(
                table: "Loai",
                columns: new[] { "Id", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("22516479-1dfe-4780-b8e0-85c885882aff"), "Quần nam", true },
                    { new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "Áo nam", true }
                });

            migrationBuilder.InsertData(
                table: "GioHang",
                columns: new[] { "Id", "IdKhachHang" },
                values: new object[] { new Guid("4f7b6227-fd02-407a-8191-604739739697"), new Guid("9fd94a59-1ab2-4eae-9654-767481e96bfe") });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "AnhNhanVien", "DiaChi", "Email", "GioiTinh", "IdChucVu", "IdGuiBaoCao", "IdGuiBcNavigationId", "MatKhau", "Sdt", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("b54e5b6d-2309-4844-99f6-50b18f665440"), "tien.png", "hn", "tien@gmail.com", true, new Guid("26c5f722-3baa-4df7-b473-2374b39e02a2"), null, null, "123456", "0987654322", "tien", true },
                    { new Guid("b764e8b0-fe90-42c5-95d3-b854620d274b"), "nga.png", "hn", "nga@gmail.com", false, new Guid("6fc0f38f-b421-4fef-8361-8136825aa354"), null, null, "123456", "0987654323", "nga", true }
                });

            migrationBuilder.InsertData(
                table: "SanPham",
                columns: new[] { "Id", "GiaBan", "GiaNhap", "IdLoai", "LinkAnh", "SoLuong", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("7cb5f225-8db2-4d48-9f73-68a42b78c1d2"), 250000m, 200000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "sp1.jpg", 10, "Áo Blazer Nam CALIBER phong cách Hàn Quốc áo khoác nam cao cấp dáng vest năng động hai màu đen nâu Unisex AK01", true },
                    { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f30"), 150000m, 100000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "sp2.jpg", 10, "Áo Len Nam Cổ Lọ Lông Cừu Cao Cấp Dày Dặn Mềm Mịn Cực Ấm Kiểu Dáng Hàn Quốc Form Rộng Faviti", true },
                    { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f31"), 300000m, 250000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "sp3.jpg", 10, "Áo Thun Local Brand Unisex Teelab Premium Basic Tee TS063", true },
                    { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f32"), 200000m, 150000m, new Guid("22516479-1dfe-4780-b8e0-85c885882aff"), "sp4.jpg", 10, "Quần jean nam dài, quần bò nam màu đen chất co dãn thoải mái", true },
                    { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f33"), 500000m, 450000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "sp5.png", 10, "Áo Hoodie Local Brand Unisex Teelab Special Collection Premium HD044", true },
                    { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f34"), 200000m, 150000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "sp6.jpg", 10, "Áo Polo Local Brand Karants Essentials Polo Shirt Premium - KR15", true },
                    { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f35"), 250000m, 200000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "sp7.jpg", 10, "Áo Thun Local Brand Unisex Karants Signature Logo Brand - KR03", true },
                    { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f36"), 190000m, 150000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "sp8.jpg", 10, "Áo Thun Unisex Form Rộng Tay Lỡ IN NỔI Oversize Local Brand Karants 100% Cotton - KR13", true },
                    { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f37"), 180000m, 150000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "sp9.jpg", 10, "Áo polo nam nữ local brand unisex Outerity Cá Sấu Cross - Italics / Màu Trắng&Đen Localbrand Outerity", true },
                    { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f38"), 280000m, 250000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "sp10.jpg", 10, "Áo thun Local Brand Something AT Urban", true },
                    { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f39"), 300000m, 250000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "sp11.jpg", 10, "Áo Polo Local Brand Unisex Karants Special Collection Premium - KR08", true },
                    { new Guid("f433cbcc-5300-45ce-bd6c-c41dc87b3f40"), 200000m, 150000m, new Guid("bc387d89-bebe-4897-baf0-0ea4e7028a13"), "sp12.jpg", 10, "Áo thun unisex MONSTER X STREET Mèo Lan Can phông tay lỡ nam nữ form rộng Local Brand", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IdKhachHang",
                table: "GioHang",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_IdGioHang",
                table: "GioHangChiTiet",
                column: "IdGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_IdSanPham",
                table: "GioHangChiTiet",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhachHang",
                table: "HoaDon",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdSanPham",
                table: "HoaDonChiTiet",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdChucVu",
                table: "NhanVien",
                column: "IdChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdGuiBcNavigationId",
                table: "NhanVien",
                column: "IdGuiBcNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IdLoai",
                table: "SanPham",
                column: "IdLoai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Loai");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
