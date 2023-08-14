using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoHarvestAPI.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        void Save();
        public IDh22SensorDataRepository TbTbDh22SensorData { get; }
        public ILdrSensorDataRepository TbLdrSensorData { get; }
        public ISoilMoistureSensorDataRepository TbSoilMoistureSensorData { get; }

    }
}
