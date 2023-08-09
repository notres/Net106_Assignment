using System.ComponentModel.DataAnnotations;

namespace _2.Data.ModelClient.DangNhap
{
    public class QuenMK
    {
        [Required(ErrorMessage = "Vui lòng không để trống số điện thoại")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Vui lòng nhập đúng số điện thoại")]
        public string SDT { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống Email")]
        [RegularExpression(@"^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@" + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$", ErrorMessage = "Vui lòng nhập đúng email")]
        public string Email { get; set; }
    }
}
