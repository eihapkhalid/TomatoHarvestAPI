using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoHarvestAPI.Models
{
    public class TbSoilMoistureSensorData
    {
        [Key]
        public int SoilMoistureSensorDataId { get; set; }
        public string SoilMoistureSensorIdentifier { get; set; } //رقم مميز لكل حساس
        public int SoilMoistureLevel { get; set; }
    }
}
