using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nasa.BLL;
using Nasa.Common.Req;
using Nasa.DAL.Models;
using QLBH.Common.Req;
using QLBH.Common.Rsp;
using System;
using System.Threading.Tasks;

namespace NasaHackathon.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {
        private readonly PlantSvc plantSvc;
        public PlantController(PlantSvc plantService)
        {
            plantSvc = plantService ?? throw new ArgumentNullException(nameof(plantService));
        }
        [HttpPost("get-plant-by-id")]
        public IActionResult GetPlantById([FromBody] SimpleReq req)
        {
            var res = plantSvc.Read(req.Id);
            return Ok(res);
        }

        [HttpPost("get-plant-by-name")]
        public IActionResult GetByName(string name)
        {
            var response = plantSvc.GetByName(name);
            return Ok(response.Data);
        }

        [HttpGet("get-all-plants")]
        public IActionResult GetAllPlants()
        {
            var res = plantSvc.GetAllPlants(); // Bạn cần triển khai phương thức GetAllPlants trong PlantSvc
            return Ok(res);
        }

  

        [HttpPost("create-plant")]
        public async Task<IActionResult> CreatePlant([FromBody] PlantReq plantDto)
        {
            var result = await plantSvc.CreatePlant(plantDto);

            // Kiểm tra xem việc tạo cây có thành công không
            if (!result.Success || result.Data == null)
            {
                return BadRequest(result.Message); // Hoặc một thông điệp lỗi khác
            }

            // Lấy cây từ Data
            var plant = result.Data as Plant;

            // Trả về kết quả với status code 201
            return CreatedAtAction("GetPlantById", new { id = plant.Id }, plantDto);
        }

    }
}
