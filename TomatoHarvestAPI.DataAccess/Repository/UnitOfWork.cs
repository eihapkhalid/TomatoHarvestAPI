using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomatoHarvestAPI.DataAccess.Data;
using TomatoHarvestAPI.DataAccess.Repository.IRepository;

namespace TomatoHarvestAPI.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        #region dependency injection
        private ApplicationDbContext _db;
        public IDh22SensorDataRepository TbDh22SensorData { get; private set; }
        public ILdrSensorDataRepository TbLdrSensorData { get; private set; }
        public ISoilMoistureSensorDataRepository TbSoilMoistureSensorData { get; private set; }
        public IUserRepository TbUser { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            TbDh22SensorData = new Dh22SensorDataRepository(_db);
            TbLdrSensorData = new LdrSensorDataRepository(_db);
            TbSoilMoistureSensorData = new SoilMoistureSensorDataRepository(_db);
            TbUser = new UseraRepository(_db);
        }
        #endregion

        #region Save
        public void Save()
        {
            try
            {
                int savedChanges = _db.SaveChanges();
                if (savedChanges > 0)
                {
                    Console.WriteLine("Data saved successfully. Number of affected rows: " + savedChanges);

                }
                else
                {
                    Console.WriteLine("No data changes to save.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while saving data to the database: " + ex.Message);
                // يمكنك التعامل مع الاستثناء هنا، مثلاً طباعة رسالة الخطأ أو تسجيلها
            }
        }
        #endregion

    }
}
