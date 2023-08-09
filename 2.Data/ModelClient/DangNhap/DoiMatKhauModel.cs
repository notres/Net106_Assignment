using System.ComponentModel.DataAnnotations;

namespace _2.Data.ModelClient.DangNhap
{
    public class DoiMatKhauModel 
    {
        [Required(ErrorMessage = "Vui lòng không để trống Email")]
        [RegularExpression(@"^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@" + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$", ErrorMessage = "Vui lòng nhập đúng email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống Sdt")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Vui lòng nhập đúng số điện thoại")]
        public string Sdt { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Mật khẩu cũ")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Mật khẩu ít nhất 6 ký tự")]
        public string MatKhau { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Mật khẩu mới")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Mật khẩu ít nhất 6 ký tự")]
        public string MatKhauMoi { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập lại Mật khẩu mới")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Mật khẩu ít nhất 6 ký tự")]
        public string NhapLaiMkm { get; set; }

    }
}
