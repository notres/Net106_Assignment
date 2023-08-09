using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.API.ViewModels.SanPham
{
    public class CreateSanPham
    {
        [Required(ErrorMessage = "Vui lòng chọn loại sản phẩm")]
        public Guid? IdLoai { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string Ten { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá bán")]
        public decimal GiaBan { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá nhập")]
        public decimal GiaNhap { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số lượng")]
        [Range(1.0, 100.0, ErrorMessage = "Nhập số lượng trong khoảng 1 đến 100")]
        public int SoLuong { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn trạng thái")]
        public bool TrangThai { get; set; }
        public string? LinkAnh { get; set; }
    }
}
