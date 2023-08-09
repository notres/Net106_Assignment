using _1.API.ViewModels.GioHang;
using _1.API.ViewModels.HoaDonChiTiet;
using _2.Data.IRepositories;
using _2.Data.ModelsClass;
using Microsoft.AspNetCore.Mvc;

namespace _1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonChiTietsController : ControllerBase
    {
        private IAllRepositories<HoaDonChiTiet> _repo;


        public HoaDonChiTietsController(IAllRepositories<HoaDonChiTiet> repo)
        {
            _repo = repo;

        }

        [HttpGet]
        [Route("Get-All")]
        public async Task<IActionResult> GetAllHoaDonChiTiet()
        {
            var result = await _repo.GetAllAsync();
            if (result == null) return Ok("Không có HoaDonChiTiet");
            return Ok(result);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetHoaDonChiTietById(Guid id)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null) return Ok("Không tìm thấy HoaDonChiTiet");
            return Ok(result);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateHoaDonChiTiet([FromBody] CreateHoaDonChiTiet ccv)
        {
            HoaDonChiTiet cv = new HoaDonChiTiet()
            {
                Id = Guid.NewGuid(),
                IdHoaDon = ccv.IdHoaDon,
                IdSanPham = ccv.IdSanPham,
                SoLuong = ccv.SoLuong,
                GiaBan = ccv.GiaBan,
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
        public async Task<IActionResult> UpdateHoaDonChiTiet(Guid id, [FromBody] UpdateHoaDonChiTiet ucv)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy HoaDonChiTiet");
            }
            else
            {
                result.IdHoaDon = ucv.IdHoaDon;
                result.IdSanPham = ucv.IdSanPham;
                result.SoLuong = ucv.SoLuong;
                result.GiaBan = ucv.GiaBan;
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy HoaDonChiTiet");
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
