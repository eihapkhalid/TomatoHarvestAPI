﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomatoHarvestAPI.DataAccess.Data;
using TomatoHarvestAPI.DataAccess.Repository.IRepository;
using TomatoHarvestAPI.Models;

namespace TomatoHarvestAPI.DataAccess.Repository
{
    public class SoilMoistureSensorDataRepository : Repository<TbSoilMoistureSensorData>, ISoilMoistureSensorDataRepository
    {
        #region dependency injection
        private ApplicationDbContext _db;
        public SoilMoistureSensorDataRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        #endregion

        #region Update
        public void Update(TbSoilMoistureSensorData obj)
        {
            _db.TbSoilMoistureSensorDatas.Update(obj);
        }
        #endregion
    }
}
