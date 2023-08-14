using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TomatoHarvestAPI.DataAccess.Repository.IRepository;
using TomatoHarvestAPI.Models;

namespace TomatoHarvestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorDataController : ControllerBase
    {
        #region Dependency Injection
        private readonly IUnitOfWork _unitOfWork;
        public SensorDataController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region PostDh22SensorData
        [HttpPost("dh22")]
        public IActionResult PostDh22SensorData([FromBody] TbDh22SensorData data, int dh22SensorDataId)
        {
            if (data == null)
            {
                return BadRequest();
            }

            var existingSensor = _unitOfWork.TbDh22SensorData.Get(s => s.Dh22SensorDataId == dh22SensorDataId);
            if (existingSensor != null)
            {
                existingSensor.Temperature = data.Temperature;
                existingSensor.Humidity = data.Humidity;
                _unitOfWork.TbDh22SensorData.Update(existingSensor);
            }

            _unitOfWork.Save();

            return Ok();
        }
        #endregion

        #region PostLdrSensorData
        [HttpPost("dh22")]
        public IActionResult PostLdrSensorData([FromBody] TbLdrSensorData data, int ldrSensorDataId)
        {
            if (data == null)
            {
                return BadRequest();
            }

            var existingSensor = _unitOfWork.TbLdrSensorData.Get(s => s.LdrSensorDataId == ldrSensorDataId);
            if (existingSensor != null)
            {
                existingSensor.LightIntensity = data.LightIntensity;
                _unitOfWork.TbLdrSensorData.Update(existingSensor);
            }

            _unitOfWork.Save();

            return Ok();
        }
        #endregion

        #region PostSoilMoistureSensorData
        [HttpPost("dh22")]
        public IActionResult PostSoilMoistureSensorData([FromBody] TbSoilMoistureSensorData data, int soilMoistureSensorDataId)
        {
            if (data == null)
            {
                return BadRequest();
            }

            var existingSensor = _unitOfWork.TbSoilMoistureSensorData.Get(s => s.SoilMoistureSensorDataId == soilMoistureSensorDataId);
            if (existingSensor != null)
            {
                existingSensor.SoilMoistureLevel = data.SoilMoistureLevel;
                _unitOfWork.TbSoilMoistureSensorData.Update(existingSensor);
            }

            _unitOfWork.Save();

            return Ok();
        }
        #endregion
    }
}
