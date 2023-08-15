using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TomatoHarvestAPI.DataAccess.Repository.IRepository;
using TomatoHarvestAPI.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        [HttpPost("PostDh22SensorData")]
        public IActionResult PostDh22SensorData([FromBody] List<TbDh22SensorData> sensorDataList)
        {
            if (sensorDataList == null || sensorDataList.Count == 0)
            {
                return BadRequest();
            }

            foreach (var data in sensorDataList)
            {
                var existingSensor = _unitOfWork.TbDh22SensorData.Get(s => s.Dh22SensorDataId == data.Dh22SensorDataId);
                if (existingSensor != null)
                {
                    existingSensor.Temperature = data.Temperature;
                    existingSensor.Humidity = data.Humidity;
                    existingSensor.Dh22SensorIdentifier = data.Dh22SensorIdentifier;
                    _unitOfWork.TbDh22SensorData.Update(existingSensor);
                }
                else
                {
                    _unitOfWork.TbDh22SensorData.Add(data);
                }
            }

            _unitOfWork.Save();

            return Ok();
        }
        #endregion

        #region GET All Dh22SensorData:
        [HttpGet]
        [Route("GetAllDh22SensorData")]
        public List<TbDh22SensorData> GetDh22SensorData()
        {
            return _unitOfWork.TbDh22SensorData.GetAll().ToList();
        }
        #endregion

        #region GET Dh22SensorData By Id:
        [HttpGet("GetDh22SensorData/{id}")]
        public TbDh22SensorData GetDh22SensorData(int id)
        {
            return _unitOfWork.TbDh22SensorData.Get(S => S.Dh22SensorDataId == id);
        }
        #endregion

        #endregion

        #region LdrSensorData

        #region PostLdrSensorData
        [HttpPost("PostLdrSensorData")]
        public IActionResult PostLdrSensorData([FromBody] List<TbLdrSensorData> sensorDataList)
        {
            if (sensorDataList == null || sensorDataList.Count == 0)
            {
                return BadRequest();
            }
            foreach (var data in sensorDataList)
            {
                var existingSensor = _unitOfWork.TbLdrSensorData.Get(s => s.LdrSensorDataId == data.LdrSensorDataId);
                if (existingSensor != null)
                {
                    existingSensor.LightIntensity = data.LightIntensity;
                    existingSensor.LdrSensorIdentifier = data.LdrSensorIdentifier;
                    _unitOfWork.TbLdrSensorData.Update(existingSensor);
                }
                else
                {
                    _unitOfWork.TbLdrSensorData.Add(data);
                }
            }
            _unitOfWork.Save();

            return Ok();
        }

        #endregion

        
        #region GET All LdrSensorData:
        [HttpGet]
        [Route("GetAllLdrSensorData")]
        public List<TbLdrSensorData> GetLdrSensorData()
        {
            return _unitOfWork.TbLdrSensorData.GetAll().ToList();
        }
        #endregion

        #region GET LdrSensorData By Id:
        [HttpGet("GetLdrSensorData/{id}")]
        public TbLdrSensorData GetLdrSensorData(int id)
        {
            return _unitOfWork.TbLdrSensorData.Get(S => S.LdrSensorDataId == id);
        }
        #endregion

        #endregion

        #region SoilMoistureSensorData

        #region PostSoilMoistureSensorData
        [HttpPost("PostSoilMoistureSensorData")]
        public IActionResult PostSoilMoistureSensorData([FromBody] List<TbSoilMoistureSensorData> sensorDataList)
        {
            if (sensorDataList == null || sensorDataList.Count == 0)
            {
                return BadRequest();
            }
            foreach (var data in sensorDataList)
            {
                var existingSensor = _unitOfWork.TbSoilMoistureSensorData.Get(s => s.SoilMoistureSensorDataId == data.SoilMoistureSensorDataId);
                if (existingSensor != null)
                {
                    existingSensor.SoilMoistureLevel = data.SoilMoistureLevel;
                    existingSensor.SoilMoistureSensorIdentifier = data.SoilMoistureSensorIdentifier;
                    _unitOfWork.TbSoilMoistureSensorData.Update(existingSensor);
                }
                {
                    _unitOfWork.TbSoilMoistureSensorData.Add(data);
                }
            }
            _unitOfWork.Save();

            return Ok();
        }

        #endregion
        
        #region GET All SoilMoistureSensorData:
        [HttpGet]
        [Route("GetAllSoilMoistureSensorData")]
        public List<TbSoilMoistureSensorData> GetSoilMoistureSensorData()
        {
            return _unitOfWork.TbSoilMoistureSensorData.GetAll().ToList();
        }
        #endregion

        #region GET SoilMoistureSensorData By Id:
        [HttpGet("GetSoilMoistureSensorData/{id}")]
        public TbSoilMoistureSensorData GetSoilMoistureSensorData(int id)
        {
            return _unitOfWork.TbSoilMoistureSensorData.Get(S => S.SoilMoistureSensorDataId == id);
        }
        #endregion


        #endregion


    }
}
