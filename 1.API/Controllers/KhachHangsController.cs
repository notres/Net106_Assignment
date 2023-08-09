using _1.API.ViewModels.HoaDon;
using _1.API.ViewModels.KhachHang;
using _2.Data.IRepositories;
using _2.Data.ModelsClass;
using Microsoft.AspNetCore.Mvc;

namespace _1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangsController : ControllerBase
    {
        private IAllRepositories<KhachHang> _repo;
        private IAllRepositories<GioHang> _repoGioHang;


        public KhachHangsController(IAllRepositories<KhachHang> repo, IAllRepositories<GioHang> repoGioHang)
        {
            _repo = repo;
            _repoGioHang = repoGioHang;
        }

        [HttpGet]
        [Route("Get-All")]
        public async Task<IActionResult> GetAllKhachHang()
        {
            var result = await _repo.GetAllAsync();
            if (result == null) return Ok("Không có KhachHang");
            return Ok(result);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetKhachHangById(Guid id)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null) return Ok("Không tìm thấy KhachHang");
            return Ok(result);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateKhachHang([FromBody] CreateKhachHang ccv)
        {
            KhachHang cv = new KhachHang()
            {
                Id = Guid.NewGuid(),
                Ten = ccv.Ten,
                Email = ccv.Email,
                MatKhau = ccv.MatKhau,
                GioiTinh = ccv.GioiTinh,
                Sdt = ccv.Sdt,
                DiaChi = ccv.DiaChi,
            };
            try
            {
                var result = await _repo.AddOneAsyn(cv);
                GioHang giohang = new GioHang()
                {
                    Id = Guid.NewGuid(),
                    IdKhachHang = result.Id
                };
                await _repoGioHang.AddOneAsyn(giohang);
                return Ok(cv);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Tạo mới không thành công");
            }

        }

        [HttpPost]
        [Route("Update/{id}")]
        public async Task<IActionResult> UpdateKhachHang(Guid id, [FromBody] UpdateKhachHang ucv)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy KhachHang");
            }
            else
            {
                result.DiaChi = ucv.DiaChi;
                result.Ten = ucv.Ten;
                result.Email = ucv.Email;
                result.MatKhau = ucv.MatKhau;
                result.GioiTinh = ucv.GioiTinh;
                result.Sdt = ucv.Sdt;
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy KhachHang");
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
