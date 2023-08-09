using _1.API.ViewModels.Loai;
using _1.API.ViewModels.SanPham;
using _2.Data.IRepositories;
using _2.Data.ModelsClass;
using Microsoft.AspNetCore.Mvc;

namespace _1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamsController : ControllerBase
    {
        private IAllRepositories<SanPham> _repo;


        public SanPhamsController(IAllRepositories<SanPham> repo)
        {
            _repo = repo;

        }

        [HttpGet]
        [Route("Get-All")]
        public async Task<IActionResult> GetAllSanPham()
        {
            var result = await _repo.GetAllAsync();
            if (result == null) return Ok("Không có SanPham");
            return Ok(result);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetSanPhamById(Guid id)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null) return Ok("Không tìm thấy SanPham");
            return Ok(result);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateSanPham([FromBody] CreateSanPham ccv)
        {
            SanPham cv = new SanPham()
            {
                Id = Guid.NewGuid(),
                IdLoai = ccv.IdLoai,
                Ten = ccv.Ten,
                GiaBan = ccv.GiaBan,
                GiaNhap = ccv.GiaNhap,
                SoLuong = ccv.SoLuong,
                TrangThai = ccv.TrangThai,
                LinkAnh = ccv.LinkAnh,
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
        public async Task<IActionResult> UpdateSanPham(Guid id, [FromBody] UpdateSanPham ucv)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy SanPham");
            }
            else
            {
                result.TrangThai = ucv.TrangThai;
                result.IdLoai = ucv.IdLoai;
                result.Ten = ucv.Ten;
                result.GiaNhap = ucv.GiaNhap;
                result.GiaBan = ucv.GiaBan;
                result.SoLuong = ucv.SoLuong;
                result.LinkAnh = ucv.LinkAnh;
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
                return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy SanPham");
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
