using System.ComponentModel.DataAnnotations;

namespace _1.API.ViewModels.SanPham
{
    public class UpdateSanPham
    {
        [Required(ErrorMessage = "Vui lòng chọn loại sản phẩm")]
        public Guid? IdLoai { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string Ten { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá nhập")]
        public decimal GiaNhap { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập giá bán")]
        public decimal GiaBan { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số lượng")]
        public int SoLuong { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn trạng thái")]
        public bool TrangThai { get; set; }
        public string? LinkAnh { get; set; }
    }
}
