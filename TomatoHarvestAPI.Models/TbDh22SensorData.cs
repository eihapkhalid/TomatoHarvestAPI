using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomatoHarvestAPI.Models
{
    public class TbDh22SensorData
    {
        [Key]
        public int Dh22SensorDataId { get; set; }
        public string Dh22SensorIdentifier { get; set; } //رقم مميز لكل حساس
        public double Temperature { get; set; }
        public double Humidity { get; set; }
    }
}
