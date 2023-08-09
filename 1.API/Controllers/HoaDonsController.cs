using _1.API.ViewModels.HoaDon;
using _1.API.ViewModels.HoaDonChiTiet;
using _2.Data.IRepositories;
using _2.Data.ModelsClass;
using Microsoft.AspNetCore.Mvc;

namespace _1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonsController : ControllerBase
    {
        private IAllRepositories<HoaDon> _repo;
        private IAllRepositories<HoaDonChiTiet> _hoaDonCTrepo;

        public HoaDonsController(IAllRepositories<HoaDon> repo, IAllRepositories<HoaDonChiTiet> hoaDonCTrepo)
        {
            _repo = repo;
            _hoaDonCTrepo = hoaDonCTrepo;
        }

        [HttpGet]
        [Route("Get-All")]
        public async Task<IActionResult> GetAllHoaDon()
        {
            var result = await _repo.GetAllAsync();
            if (result == null) return Ok("Không có HoaDon");
            return Ok(result);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetHoaDonById(Guid id)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null) return Ok("Không tìm thấy HoaDon");
            return Ok(result);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateHoaDon([FromBody] CreateHoaDon ccv)
        {
            var lsthoadon = await _repo.GetAllAsync();
            HoaDon cv = new HoaDon()
            {
                Id = ccv.Id,
                MaHoaDon = "HD" + (lsthoadon.ToList().Count() + 1),
                IdKhachHang = ccv.IdKhachHang,
                IdNhanVien = ccv.IdNhanVien,
                NgayTao =  ccv.NgayTao,
                TongTien = ccv.TongTien,
                TrangThai  = ccv.TrangThai,
                DiaChi = ccv.DiaChi,
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
        public async Task<IActionResult> UpdateHoaDon(Guid id, [FromBody] UpdateHoaDon ucv)
        {
            var result = await _repo.GetByIdAsync(id);
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy HoaDon");
            }
            else
            {
                result.MaHoaDon = ucv.MaHoaDon;
                result.IdKhachHang = ucv.IdKhachHang;
                result.IdNhanVien = ucv.IdNhanVien;
                result.NgayTao = ucv.NgayTao;
                result.TongTien = ucv.TongTien;
                result.TrangThai = ucv.TrangThai;
                result.DiaChi = ucv.DiaChi;
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
            var lsthoadonct = await _hoaDonCTrepo.GetAllAsync();
            lsthoadonct = lsthoadonct.ToList().Where(p => p.IdHoaDon == result.Id);
            if (result == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Không tìm thấy HoaDon");
            }
            else
            {
                try
                {
                    foreach (var item in lsthoadonct)
                    {
                        await _hoaDonCTrepo.DeleteOneAsyn(item);
                    }
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
