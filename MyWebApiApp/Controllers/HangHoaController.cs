using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApiApp.Model;

namespace MyWebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        public static List<HangHoa> hanghoas = new List<HangHoa>();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(hanghoas);
        }
        [HttpPost]
        public IActionResult Create(HangHoaVM hanghoaVm)
        {
            var hanghoa = new HangHoa
            {
                MaHangHoa = Guid.NewGuid(),
                TenHangHoa = hanghoaVm.TenHangHoa,
                Dongia = hanghoaVm.Dongia
            };
            hanghoas.Add(hanghoa);
            return Ok(new
            {
                Succes = true,
                Data = hanghoa
            });
        }
        [HttpGet("{id}")]
        public IActionResult GetById(string id) 
        {   
            try
            {
                var hanghoa = hanghoas.SingleOrDefault(hh => hh.MaHangHoa == Guid.Parse(id));
                if (hanghoa == null)
                {
                    return NotFound();
                }
                return Ok(hanghoa);
            } 
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Edit(string id, HangHoa hanghoaEdit)
        {   
            try
            {
                var hanghoa = hanghoas.SingleOrDefault(hh => hh.MaHangHoa == Guid.Parse(id));
                if (hanghoa == null)
                {
                    return NotFound();
                }
                if (id != hanghoa.MaHangHoa.ToString())
                {
                    return BadRequest();
                }
                //Update
                hanghoa.TenHangHoa = hanghoaEdit.TenHangHoa;
                hanghoa.Dongia = hanghoaEdit.Dongia;
                return Ok();
            }
            catch { return BadRequest(); } 
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                var hanghoa = hanghoas.SingleOrDefault(hh => hh.MaHangHoa == Guid.Parse(id));
                if (hanghoa == null)
                {
                    return NotFound();
                }
                if (id != hanghoa.MaHangHoa.ToString())
                {
                    return BadRequest();
                }
                //Update
                hanghoas.Remove(hanghoa);
                return Ok();
            }
            catch { return BadRequest(); }
        }
    }
    
}
