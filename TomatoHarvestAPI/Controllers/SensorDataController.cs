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

        #region Dh22SensorData

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

        #region GET All Dh22SensorData:
        [HttpGet]
        [Route("Get")]
        public List<TbDh22SensorData> GetDh22SensorData()
        {
            return _unitOfWork.TbDh22SensorData.GetAll().ToList();
        }
        #endregion

        #region GET Dh22SensorData By Id:
        [HttpGet("{id}")]
        [Route("Get/{id}")]
        public TbDh22SensorData GetDh22SensorData(int dh22SensorDataId)
        {
            return _unitOfWork.TbDh22SensorData.Get(S => S.Dh22SensorDataId == dh22SensorDataId);
        }
        #endregion

        #endregion

        #region LdrSensorData

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

        #region GET All LdrSensorData:
        [HttpGet]
        [Route("Get")]
        public List<TbLdrSensorData> GetLdrSensorData()
        {
            return _unitOfWork.TbLdrSensorData.GetAll().ToList();
        }
        #endregion

        #region GET LdrSensorData By Id:
        [HttpGet("{id}")]
        [Route("Get/{id}")]
        public TbLdrSensorData GetLdrSensorData(int ldrSensorDataId)
        {
            return _unitOfWork.TbLdrSensorData.Get(S => S.LdrSensorDataId == ldrSensorDataId);
        }
        #endregion

        #endregion

        #region SoilMoistureSensorData

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

        #region GET All SoilMoistureSensorData:
        [HttpGet]
        [Route("Get")]
        public List<TbSoilMoistureSensorData> GetSoilMoistureSensorData()
        {
            return _unitOfWork.TbSoilMoistureSensorData.GetAll().ToList();
        }
        #endregion

        #region GET SoilMoistureSensorData By Id:
        [HttpGet("{id}")]
        [Route("Get/{id}")]
        public TbSoilMoistureSensorData GetSoilMoistureSensorData(int soilMoistureSensorDataId)
        {
            return _unitOfWork.TbSoilMoistureSensorData.Get(S => S.SoilMoistureSensorDataId == soilMoistureSensorDataId);
        }
        #endregion 

        #endregion


    }
}
