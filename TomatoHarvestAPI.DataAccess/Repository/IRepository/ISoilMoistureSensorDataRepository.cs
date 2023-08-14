using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomatoHarvestAPI.Models;

namespace TomatoHarvestAPI.DataAccess.Repository.IRepository
{
    public interface ISoilMoistureSensorDataRepository : IRepository<TbSoilMoistureSensorData>
    {
        void Update(TbSoilMoistureSensorData obj);
    }
}
