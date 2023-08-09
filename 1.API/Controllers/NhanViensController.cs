using _1.API.ViewModels.KhachHang;
using _1.API.ViewModels.NhanVien;
using _2.Data.IRepositories;
using _2.Data.ModelsClass;
using Microsoft.AspNetCore.Mvc;

namespace _1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanViensController : ControllerBase
    {
        private IAllRepositories<NhanVien> _repo;


        public NhanViensController(IAllRepositories<NhanVien> repo)
        {
            _repo = repo;

        }

        [HttpGet]
        [Route("Get-All")]
        public async Task<IActionResult> GetAllNhanVien()
        {
            var result = await _repo.GetAllAsync();
            if (result == null) return Ok("Không có NhanVien");
            return Ok(result);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetNhanVienById(Guid id)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null) return Ok("Không tìm thấy NhanVien");
            return Ok(result);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateNhanVien([FromBody] CreateNhanVien ccv)
        {
            NhanVien cv = new NhanVien()
            {
                Id = Guid.NewGuid(),
                IdChucVu = ccv.IdChucVu,
                Ten = ccv.Ten,
                Email = ccv.Email,
                MatKhau = ccv.MatKhau,
                GioiTinh = ccv.GioiTinh,
                Sdt = ccv.Sdt,
                DiaChi = ccv.DiaChi,
                TrangThai = ccv.TrangThai,
                AnhNhanVien = ccv.AnhNhanVien,
            };
            try
            {
                var result = await _repo.AddOneAsyn(cv);
                return Ok(cv);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Tạo mới không thành công");
            }

        }

        [HttpPost]
        [Route("Update/{id}")]
        public async Task<IActionResult> UpdateNhanVien(Guid id, [FromBody] UpdateNhanVien ucv)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy NhanVien");
            }
            else
            {
                result.DiaChi = ucv.DiaChi;
                result.Ten = ucv.Ten;
                result.Email = ucv.Email;
                result.MatKhau = ucv.MatKhau;
                result.GioiTinh = ucv.GioiTinh;
                result.Sdt = ucv.Sdt;
                result.TrangThai = ucv.TrangThai;
                result.IdChucVu = ucv.IdChucVu;
                result.AnhNhanVien = ucv.AnhNhanVien;
                try
                {
                    await _repo.UpdateOneAsyn(result);
                    return Ok(result);
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Update không thành công");
                }


            }

        }
        [HttpGet]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy NhanVien");
            }
            else
            {
                try
                {
                    await _repo.DeleteOneAsyn(result);
                    return Ok("Xóa thành công");
                }
                catch (Exception ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Xóa không thành công");
                }


            }
        }
    }
}
