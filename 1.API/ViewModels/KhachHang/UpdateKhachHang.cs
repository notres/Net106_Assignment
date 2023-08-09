using System.ComponentModel.DataAnnotations;

namespace _1.API.ViewModels.KhachHang
{
    public class UpdateKhachHang
    {
        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string Ten { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập email")]
        [RegularExpression(@"^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@" + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$", ErrorMessage = "Vui lòng nhập đúng email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Tối thiểu 6 ký tự, tối đa 30 ký tự")]
        public string MatKhau { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string DiaChi { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giới tính")]
        public bool GioiTinh { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Nhập đúng số điện thoại")]
        public string Sdt { get; set; }
    }
}
