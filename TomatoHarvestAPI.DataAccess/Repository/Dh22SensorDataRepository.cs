using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomatoHarvestAPI.DataAccess.Data;
using TomatoHarvestAPI.DataAccess.Repository.IRepository;
using TomatoHarvestAPI.Models;

namespace TomatoHarvestAPI.DataAccess.Repository
{
    public class Dh22SensorDataRepository : Repository<TbDh22SensorData>, IDh22SensorDataRepository
    {
        #region dependency injection
        private ApplicationDbContext _db;
        public Dh22SensorDataRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        #endregion

        #region Update
        public void Update(TbDh22SensorData obj)
        {
            _db.TbDh22SensorDatas.Update(obj);
        }
        #endregion
    }
}
