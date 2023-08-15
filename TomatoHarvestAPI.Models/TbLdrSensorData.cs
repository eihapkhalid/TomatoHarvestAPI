using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoHarvestAPI.Models
{
    public class TbLdrSensorData
    {
        [Key]
        public int LdrSensorDataId { get; set; }
        public string LdrSensorIdentifier { get; set; } //رقم مميز لكل حساس
        public int LightIntensity { get; set; }
    }
}
